// generateTime 2024-11-14 20:17:00
// https://github.com/iohao/ioGame
using Pb.Common;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Google.Protobuf;
using IoGame.Sdk;

namespace IoGame.Gen
{
  /// <summary>
  /// My Action; 我的 Action
  /// </summary>
  /// <remarks>Author: https://github.com/iohao/ioGame</remarks>
  public static class MyAction
  {
    private static readonly int hello_2_1 = CmdKit.MappingRequest(131073, "this is hello action. 这是我提供的 hello action。");
    private static readonly int loginVerify_2_2 = CmdKit.MappingRequest(131074, "我的登录验证 action。My loginVerify action");

    /// <summary>
    /// this is hello action. 这是我提供的 hello action。
    /// </summary>
    /// <param name="name">your name; 你的名字</param>
    /// <param name="callback"><see cref="string"/> 我的响应内容; My Response</param>
    /// <returns>RequestCommand</returns>
    /// <code>
    /// // your name; 你的名字
    /// string name = ...;
    /// MyAction.ofHello(name, result => {
    ///     // ioGame: your biz code.
    ///     // 我的响应内容; My Response
    ///     var value = result.GetString();
    ///     result.Log(value);
    /// });
    /// </code>
    public static RequestCommand OfHello(string name, CallbackDelegate callback)
    {
        return RequestCommand.OfString(hello_2_1, name).OnCallback(callback).Execute();
    }

    /// <summary>
    /// this is hello action. 这是我提供的 hello action。
    /// </summary>
    /// <param name="name">your name; 你的名字</param>
    /// <returns>ResponseResult，<see cref="string"/> 我的响应内容; My Response</returns>
    /// <code>
    /// // your name; 你的名字
    /// string name = ...;
    /// var result = await MyAction.ofAwaitHello(name);
    /// // ioGame: your biz code.
    /// // 我的响应内容; My Response
    /// var value = result.GetString();
    /// result.Log(value);
    /// </code>
    public static async Task<ResponseResult> OfAwaitHello(string name)
    {
        return await RequestCommand.OfAwaitString(hello_2_1, name);
    }

    /// <summary>
    /// 我的登录验证 action。My loginVerify action
    /// </summary>
    /// <param name="verifyMessage">我的验证信息。verifyMessage</param>
    /// <param name="callback"><see cref="UserMessage"/> 我的用户信息。My UserMessage</param>
    /// <returns>RequestCommand</returns>
    /// <code>
    /// // 我的验证信息。verifyMessage
    /// LoginVerifyMessage verifyMessage = ...;
    /// MyAction.ofLoginVerify(verifyMessage, result => {
    ///     // ioGame: your biz code.
    ///     // 我的用户信息。My UserMessage
    ///     var value = result.GetValue&lt;UserMessage&gt;();
    ///     result.Log(value);
    /// });
    /// </code>
    public static RequestCommand OfLoginVerify(LoginVerifyMessage verifyMessage, CallbackDelegate callback)
    {
        return RequestCommand.Of(loginVerify_2_2, verifyMessage).OnCallback(callback).Execute();
    }

    /// <summary>
    /// 我的登录验证 action。My loginVerify action
    /// </summary>
    /// <param name="verifyMessage">我的验证信息。verifyMessage</param>
    /// <returns>ResponseResult，<see cref="UserMessage"/> 我的用户信息。My UserMessage</returns>
    /// <code>
    /// // 我的验证信息。verifyMessage
    /// LoginVerifyMessage verifyMessage = ...;
    /// var result = await MyAction.ofAwaitLoginVerify(verifyMessage);
    /// // ioGame: your biz code.
    /// // 我的用户信息。My UserMessage
    /// var value = result.GetValue&lt;UserMessage&gt;();
    /// result.Log(value);
    /// </code>
    public static async Task<ResponseResult> OfAwaitLoginVerify(LoginVerifyMessage verifyMessage)
    {
        return await RequestCommand.OfAwait(loginVerify_2_2, verifyMessage);
    }

  }
}