using System;
using System.Threading.Tasks;
using Google.Protobuf;
using IoGame.Gen;
using IoGame.Sdk;
using Pb.Common;
using UnityEngine;
using UnityWebSocket;

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
            // _socket.Poll();
        }

        private static void SocketInit()
        {
            IoGameSetting.Url = "ws://127.0.0.1:10100/websocket";

            // socket
            _socket = new IoGameUnityWebSocket();
            IoGameSetting.NetChannel = _socket;

            _socket.OnOpen += (_, _) =>
            {
                Debug.Log("WebSocket OnOpen new!");

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
            var heartbeatMessage = new ExternalMessage().ToByteArray();
            var counter = 0;

            while (true)
            {
                await Task.Delay(8000);
                Debug.Log($"-------- unity new ...HeartbeatMessage {counter++}");
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

        WebSocket _socket;

        public event EventHandler<OpenEventArgs> OnOpen = (_, _) => { Debug.Log("WebSocket OnOpen"); };

        public override void Prepare()
        {
            Url ??= IoGameSetting.Url;
            _socket = new WebSocket(Url);
            // 注册回调
            _socket.OnOpen += OnOpen;
            _socket.OnClose += (_, e) => { Debug.Log($"Connection closed! {e}"); };
            _socket.OnError += (_, e) => { Debug.LogError($"e {e}"); };
            _socket.OnMessage += (m, e) =>
            {
                var packet = e.RawData;
                AcceptMessage(ExternalMessage.Parser.ParseFrom(packet));
            };

            // 连接
            _socket.ConnectAsync();
        }

        public override void WriteAndFlush(byte[] bytes)
        {
            _socket.SendAsync(bytes);
        }
    }
}