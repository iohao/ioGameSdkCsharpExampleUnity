using System.Threading.Tasks;
using Google.Protobuf;
using IoGame.Gen;
using IoGame.Sdk;
using Pb.Common;
using UnityEngine;
using NativeWebSocket;

namespace Config
{
    public abstract class MyNetConfig
    {
        private static IoGameUnityWebSocket _socket;
        public static long CurrentTimeMillis { get; set; }

        public static void StartNet()
        {
            // biz code init
            GameCode.Init();
            Index.Listen();

            // --------- IoGameSetting ---------
            IoGameSetting.EnableDevMode = true;
            // China or Us
            IoGameSetting.SetLanguage(IoGameLanguage.China);
            // message callback. 回调监听
            IoGameSetting.ListenMessageCallback = new MyListenMessageCallback();
            IoGameSetting.GameGameConsole = new MyGameConsole();

            // socket
            SocketInit();

            IoGameSetting.StartNet();
        }

        public static void Poll()
        {
            // Receiving server messages
            _socket.Poll();
        }

        private static void SocketInit()
        {
            IoGameSetting.Url = "ws://127.0.0.1:10100/websocket";

            // socket
            _socket = new IoGameUnityWebSocket();
            IoGameSetting.NetChannel = _socket;

            _socket.OnOpen += () =>
            {
                // login
                var loginVerifyMessage = new LoginVerifyMessage { Jwt = "1234567" };
                SdkAction.OfLoginVerify(loginVerifyMessage, result =>
                {
                    var userMessage = result.GetValue<UserMessage>();
                    result.Log($"userMessage: {userMessage}");
                });

                // heartbeat
                IdleTimer();
            };
        }

        private static async void IdleTimer()
        {
            /*
             * This may be a bug in WebSocket. The message cannot be empty.
             *
             * cn: 似乎该 unity WebSocket 库不支持发送空数组；这里用 cmdMerge 占位，以便让心跳可以顺利发送到服务器。
             */
            var heartbeatMessage = new ExternalMessage { CmdCode = 0, CmdMerge = 1 }.ToByteArray();

            var counter = 0;

            while (true)
            {
                await Task.Delay(8000);
                Debug.Log($"-------- unity...HeartbeatMessage {counter++}");
                // Send heartbeat to server. 发送心跳给服务器
                IoGameSetting.NetChannel.WriteAndFlush(heartbeatMessage);
            }
        }
    }

    internal class MyListenMessageCallback : SimpleListenMessageCallback
    {
        public override void OnIdleCallback(ExternalMessage message)
        {
            var dataBytes = message.Data.ToByteArray();
            var longValue = new LongValue();
            longValue.MergeFrom(new CodedInputStream(dataBytes));
            /*
             * Synchronize the time of each heartbeat with that of the server.
             * 每次心跳与服务器的时间同步
             */
            MyNetConfig.CurrentTimeMillis = longValue.Value;
        }
    }

    internal class MyGameConsole : IGameConsole
    {
        public void Log(object value)
        {
            Debug.Log(value);
        }
    }

    public sealed class IoGameUnityWebSocket : SimpleNetChannel
    {
        public string Url { set; get; }
        private WebSocket _socket;
        public event WebSocketOpenEventHandler OnOpen = () => { Debug.Log("WebSocket OnOpen"); };
        public event WebSocketErrorEventHandler OnError = e => { Debug.LogError($"e {e}"); };
        public event WebSocketCloseEventHandler OnClose = e => { Debug.Log($"Connection closed! {e}"); };
        public event WebSocketMessageEventHandler OnMessage;

        public override void Prepare()
        {
            Url ??= IoGameSetting.Url;
            _socket = new WebSocket(Url);

            _socket.OnOpen += OnOpen;
            _socket.OnError += OnError;
            _socket.OnClose += OnClose;
            _socket.OnMessage += OnMessage ?? (packet => { AcceptMessage(ExternalMessage.Parser.ParseFrom(packet)); });

            _socket.Connect().GetAwaiter().OnCompleted(() => { });
        }

        public override void WriteAndFlush(byte[] bytes)
        {
            if (_socket.State == WebSocketState.Open)
                _socket.Send(bytes);
        }

        public void Poll()
        {
#if !UNITY_WEBGL || UNITY_EDITOR
            _socket.DispatchMessageQueue();
#endif
        }
    }
}