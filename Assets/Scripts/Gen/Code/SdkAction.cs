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
  /// My SdkAction
  /// </summary>
  /// <remarks>Author: https://github.com/iohao/ioGame</remarks>
  public static class SdkAction
  {
    private static readonly int loginVerify_1_0 = CmdKit.MappingRequest(65536, "user login");
    private static readonly int triggerBroadcast_1_1 = CmdKit.MappingRequest(65537, "test broadcast");
    private static readonly int intValue_1_2 = CmdKit.MappingRequest(65538, "test int");
    private static readonly int longValue_1_3 = CmdKit.MappingRequest(65539, "test long");
    private static readonly int boolValue_1_4 = CmdKit.MappingRequest(65540, "test boolean");
    private static readonly int stringValue_1_5 = CmdKit.MappingRequest(65541, "test String");
    private static readonly int value_1_6 = CmdKit.MappingRequest(65542, "test Object；测试单个对象的接收与响应。");
    private static readonly int listInt_1_12 = CmdKit.MappingRequest(65548, "test int list");
    private static readonly int listLong_1_13 = CmdKit.MappingRequest(65549, "test Long list");
    private static readonly int listBool_1_14 = CmdKit.MappingRequest(65550, "test Boolean list");
    private static readonly int listString_1_15 = CmdKit.MappingRequest(65551, "test String list");
    private static readonly int listValue_1_16 = CmdKit.MappingRequest(65552, "test Object list");
    private static readonly int testError_1_20 = CmdKit.MappingRequest(65556, "test error code");
    private static readonly int noParam_1_60 = CmdKit.MappingRequest(65596, "noParam method test. 没有参数的方法测试");
    private static readonly int noReturn_1_61 = CmdKit.MappingRequest(65597, "noReturn method test. 没有返回值的方法测试");

    /// <summary>
    /// user login
    /// </summary>
    /// <param name="verifyMessage">loginVerify</param>
    /// <param name="callback"><see cref="UserMessage"/> User info</param>
    /// <returns>RequestCommand</returns>
    /// <code>
    /// // loginVerify
    /// LoginVerifyMessage verifyMessage = ...;
    /// SdkAction.ofLoginVerify(verifyMessage, result => {
    ///     // ioGame: your biz code.
    ///     // User info
    ///     var value = result.GetValue&lt;UserMessage&gt;();
    ///     result.Log(value);
    /// });
    /// </code>
    public static RequestCommand OfLoginVerify(LoginVerifyMessage verifyMessage, CallbackDelegate callback)
    {
        return RequestCommand.Of(loginVerify_1_0, verifyMessage).OnCallback(callback).Execute();
    }

    /// <summary>
    /// user login
    /// </summary>
    /// <param name="verifyMessage">loginVerify</param>
    /// <returns>ResponseResult，<see cref="UserMessage"/> User info</returns>
    /// <code>
    /// // loginVerify
    /// LoginVerifyMessage verifyMessage = ...;
    /// var result = await SdkAction.ofAwaitLoginVerify(verifyMessage);
    /// // ioGame: your biz code.
    /// // User info
    /// var value = result.GetValue&lt;UserMessage&gt;();
    /// result.Log(value);
    /// </code>
    public static async Task<ResponseResult> OfAwaitLoginVerify(LoginVerifyMessage verifyMessage)
    {
        return await RequestCommand.OfAwait(loginVerify_1_0, verifyMessage);
    }

    /// <summary>
    /// test broadcast
    /// </summary>
    /// <returns>RequestCommand void</returns>
    /// <code>
    /// SdkAction.ofTriggerBroadcast();
    /// </code>
    public static RequestCommand OfTriggerBroadcast()
    {
        return RequestCommand.Of(triggerBroadcast_1_1).Execute();
    }

    /// <summary>
    /// test int
    /// </summary>
    /// <param name="value">value</param>
    /// <param name="callback"><see cref="int"/> int value</param>
    /// <returns>RequestCommand</returns>
    /// <code>
    /// // value
    /// int value = ...;
    /// SdkAction.ofIntValue(value, result => {
    ///     // ioGame: your biz code.
    ///     // int value
    ///     var value = result.GetInt();
    ///     result.Log(value);
    /// });
    /// </code>
    public static RequestCommand OfIntValue(int value, CallbackDelegate callback)
    {
        return RequestCommand.OfInt(intValue_1_2, value).OnCallback(callback).Execute();
    }

    /// <summary>
    /// test int
    /// </summary>
    /// <param name="value">value</param>
    /// <returns>ResponseResult，<see cref="int"/> int value</returns>
    /// <code>
    /// // value
    /// int value = ...;
    /// var result = await SdkAction.ofAwaitIntValue(value);
    /// // ioGame: your biz code.
    /// // int value
    /// var value = result.GetInt();
    /// result.Log(value);
    /// </code>
    public static async Task<ResponseResult> OfAwaitIntValue(int value)
    {
        return await RequestCommand.OfAwaitInt(intValue_1_2, value);
    }

    /// <summary>
    /// test long
    /// </summary>
    /// <param name="value">value</param>
    /// <param name="callback"><see cref="long"/> long value</param>
    /// <returns>RequestCommand</returns>
    /// <code>
    /// // value
    /// long value = ...;
    /// SdkAction.ofLongValue(value, result => {
    ///     // ioGame: your biz code.
    ///     // long value
    ///     var value = result.GetLong();
    ///     result.Log(value);
    /// });
    /// </code>
    public static RequestCommand OfLongValue(long value, CallbackDelegate callback)
    {
        return RequestCommand.OfLong(longValue_1_3, value).OnCallback(callback).Execute();
    }

    /// <summary>
    /// test long
    /// </summary>
    /// <param name="value">value</param>
    /// <returns>ResponseResult，<see cref="long"/> long value</returns>
    /// <code>
    /// // value
    /// long value = ...;
    /// var result = await SdkAction.ofAwaitLongValue(value);
    /// // ioGame: your biz code.
    /// // long value
    /// var value = result.GetLong();
    /// result.Log(value);
    /// </code>
    public static async Task<ResponseResult> OfAwaitLongValue(long value)
    {
        return await RequestCommand.OfAwaitLong(longValue_1_3, value);
    }

    /// <summary>
    /// test boolean
    /// </summary>
    /// <param name="value">value</param>
    /// <param name="callback"><see cref="bool"/> boolean value</param>
    /// <returns>RequestCommand</returns>
    /// <code>
    /// // value
    /// bool value = ...;
    /// SdkAction.ofBoolValue(value, result => {
    ///     // ioGame: your biz code.
    ///     // boolean value
    ///     var value = result.GetBool();
    ///     result.Log(value);
    /// });
    /// </code>
    public static RequestCommand OfBoolValue(bool value, CallbackDelegate callback)
    {
        return RequestCommand.OfBool(boolValue_1_4, value).OnCallback(callback).Execute();
    }

    /// <summary>
    /// test boolean
    /// </summary>
    /// <param name="value">value</param>
    /// <returns>ResponseResult，<see cref="bool"/> boolean value</returns>
    /// <code>
    /// // value
    /// bool value = ...;
    /// var result = await SdkAction.ofAwaitBoolValue(value);
    /// // ioGame: your biz code.
    /// // boolean value
    /// var value = result.GetBool();
    /// result.Log(value);
    /// </code>
    public static async Task<ResponseResult> OfAwaitBoolValue(bool value)
    {
        return await RequestCommand.OfAwaitBool(boolValue_1_4, value);
    }

    /// <summary>
    /// test String
    /// </summary>
    /// <param name="value">value</param>
    /// <param name="callback"><see cref="string"/> String value</param>
    /// <returns>RequestCommand</returns>
    /// <code>
    /// // value
    /// string value = ...;
    /// SdkAction.ofStringValue(value, result => {
    ///     // ioGame: your biz code.
    ///     // String value
    ///     var value = result.GetString();
    ///     result.Log(value);
    /// });
    /// </code>
    public static RequestCommand OfStringValue(string value, CallbackDelegate callback)
    {
        return RequestCommand.OfString(stringValue_1_5, value).OnCallback(callback).Execute();
    }

    /// <summary>
    /// test String
    /// </summary>
    /// <param name="value">value</param>
    /// <returns>ResponseResult，<see cref="string"/> String value</returns>
    /// <code>
    /// // value
    /// string value = ...;
    /// var result = await SdkAction.ofAwaitStringValue(value);
    /// // ioGame: your biz code.
    /// // String value
    /// var value = result.GetString();
    /// result.Log(value);
    /// </code>
    public static async Task<ResponseResult> OfAwaitStringValue(string value)
    {
        return await RequestCommand.OfAwaitString(stringValue_1_5, value);
    }

    /// <summary>
    /// test Object；测试单个对象的接收与响应。
    /// </summary>
    /// <param name="loginVerifyMessage">loginVerify；登录对象。</param>
    /// <param name="callback"><see cref="UserMessage"/> UserMessage；用户数据。</param>
    /// <returns>RequestCommand</returns>
    /// <code>
    /// // loginVerify；登录对象。
    /// LoginVerifyMessage loginVerifyMessage = ...;
    /// SdkAction.ofValue(loginVerifyMessage, result => {
    ///     // ioGame: your biz code.
    ///     // UserMessage；用户数据。
    ///     var value = result.GetValue&lt;UserMessage&gt;();
    ///     result.Log(value);
    /// });
    /// </code>
    public static RequestCommand OfValue(LoginVerifyMessage loginVerifyMessage, CallbackDelegate callback)
    {
        return RequestCommand.Of(value_1_6, loginVerifyMessage).OnCallback(callback).Execute();
    }

    /// <summary>
    /// test Object；测试单个对象的接收与响应。
    /// </summary>
    /// <param name="loginVerifyMessage">loginVerify；登录对象。</param>
    /// <returns>ResponseResult，<see cref="UserMessage"/> UserMessage；用户数据。</returns>
    /// <code>
    /// // loginVerify；登录对象。
    /// LoginVerifyMessage loginVerifyMessage = ...;
    /// var result = await SdkAction.ofAwaitValue(loginVerifyMessage);
    /// // ioGame: your biz code.
    /// // UserMessage；用户数据。
    /// var value = result.GetValue&lt;UserMessage&gt;();
    /// result.Log(value);
    /// </code>
    public static async Task<ResponseResult> OfAwaitValue(LoginVerifyMessage loginVerifyMessage)
    {
        return await RequestCommand.OfAwait(value_1_6, loginVerifyMessage);
    }

    /// <summary>
    /// test int list
    /// </summary>
    /// <param name="value">value</param>
    /// <param name="callback">list of <see cref="int"/> int list</param>
    /// <returns>RequestCommand</returns>
    /// <code>
    /// // value
    /// List&lt;int&gt; value = ...;
    /// SdkAction.ofListInt(value, result => {
    ///     // ioGame: your biz code.
    ///     // int list
    ///     var value = result.ListInt();
    ///     result.Log(value);
    /// });
    /// </code>
    public static RequestCommand OfListInt(List<int> value, CallbackDelegate callback)
    {
        return RequestCommand.OfIntList(listInt_1_12, value).OnCallback(callback).Execute();
    }

    /// <summary>
    /// test int list
    /// </summary>
    /// <param name="value">value</param>
    /// <returns>ResponseResult，list of <see cref="int"/> int list</returns>
    /// <code>
    /// // value
    /// List&lt;int&gt; value = ...;
    /// var result = await SdkAction.ofAwaitListInt(value);
    /// // ioGame: your biz code.
    /// // int list
    /// var value = result.ListInt();
    /// result.Log(value);
    /// </code>
    public static async Task<ResponseResult> OfAwaitListInt(List<int> value)
    {
        return await RequestCommand.OfAwaitIntList(listInt_1_12, value);
    }

    /// <summary>
    /// test Long list
    /// </summary>
    /// <param name="value">value</param>
    /// <param name="callback">list of <see cref="long"/> Long list</param>
    /// <returns>RequestCommand</returns>
    /// <code>
    /// // value
    /// List&lt;long&gt; value = ...;
    /// SdkAction.ofListLong(value, result => {
    ///     // ioGame: your biz code.
    ///     // Long list
    ///     var value = result.ListLong();
    ///     result.Log(value);
    /// });
    /// </code>
    public static RequestCommand OfListLong(List<long> value, CallbackDelegate callback)
    {
        return RequestCommand.OfLongList(listLong_1_13, value).OnCallback(callback).Execute();
    }

    /// <summary>
    /// test Long list
    /// </summary>
    /// <param name="value">value</param>
    /// <returns>ResponseResult，list of <see cref="long"/> Long list</returns>
    /// <code>
    /// // value
    /// List&lt;long&gt; value = ...;
    /// var result = await SdkAction.ofAwaitListLong(value);
    /// // ioGame: your biz code.
    /// // Long list
    /// var value = result.ListLong();
    /// result.Log(value);
    /// </code>
    public static async Task<ResponseResult> OfAwaitListLong(List<long> value)
    {
        return await RequestCommand.OfAwaitLongList(listLong_1_13, value);
    }

    /// <summary>
    /// test Boolean list
    /// </summary>
    /// <param name="value">value</param>
    /// <param name="callback">list of <see cref="bool"/> Boolean list</param>
    /// <returns>RequestCommand</returns>
    /// <code>
    /// // value
    /// List&lt;bool&gt; value = ...;
    /// SdkAction.ofListBool(value, result => {
    ///     // ioGame: your biz code.
    ///     // Boolean list
    ///     var value = result.ListBool();
    ///     result.Log(value);
    /// });
    /// </code>
    public static RequestCommand OfListBool(List<bool> value, CallbackDelegate callback)
    {
        return RequestCommand.OfBoolList(listBool_1_14, value).OnCallback(callback).Execute();
    }

    /// <summary>
    /// test Boolean list
    /// </summary>
    /// <param name="value">value</param>
    /// <returns>ResponseResult，list of <see cref="bool"/> Boolean list</returns>
    /// <code>
    /// // value
    /// List&lt;bool&gt; value = ...;
    /// var result = await SdkAction.ofAwaitListBool(value);
    /// // ioGame: your biz code.
    /// // Boolean list
    /// var value = result.ListBool();
    /// result.Log(value);
    /// </code>
    public static async Task<ResponseResult> OfAwaitListBool(List<bool> value)
    {
        return await RequestCommand.OfAwaitBoolList(listBool_1_14, value);
    }

    /// <summary>
    /// test String list
    /// </summary>
    /// <param name="value">value</param>
    /// <param name="callback">list of <see cref="string"/> String list</param>
    /// <returns>RequestCommand</returns>
    /// <code>
    /// // value
    /// List&lt;string&gt; value = ...;
    /// SdkAction.ofListString(value, result => {
    ///     // ioGame: your biz code.
    ///     // String list
    ///     var value = result.ListString();
    ///     result.Log(value);
    /// });
    /// </code>
    public static RequestCommand OfListString(List<string> value, CallbackDelegate callback)
    {
        return RequestCommand.OfStringList(listString_1_15, value).OnCallback(callback).Execute();
    }

    /// <summary>
    /// test String list
    /// </summary>
    /// <param name="value">value</param>
    /// <returns>ResponseResult，list of <see cref="string"/> String list</returns>
    /// <code>
    /// // value
    /// List&lt;string&gt; value = ...;
    /// var result = await SdkAction.ofAwaitListString(value);
    /// // ioGame: your biz code.
    /// // String list
    /// var value = result.ListString();
    /// result.Log(value);
    /// </code>
    public static async Task<ResponseResult> OfAwaitListString(List<string> value)
    {
        return await RequestCommand.OfAwaitStringList(listString_1_15, value);
    }

    /// <summary>
    /// test Object list
    /// </summary>
    /// <param name="value">LoginVerifyMessage list</param>
    /// <param name="callback">list of <see cref="UserMessage"/> UserMessage list</param>
    /// <returns>RequestCommand</returns>
    /// <code>
    /// // LoginVerifyMessage list
    /// List&lt;LoginVerifyMessage&gt; value = ...;
    /// SdkAction.ofListValue(value, result => {
    ///     // ioGame: your biz code.
    ///     // UserMessage list
    ///     var value = result.ListValue&lt;UserMessage&gt;();
    ///     result.Log(value);
    /// });
    /// </code>
    public static RequestCommand OfListValue(List<LoginVerifyMessage> value, CallbackDelegate callback)
    {
        var dataList = value.Cast<IMessage>().ToList();
        return RequestCommand.OfValueList(listValue_1_16, dataList).OnCallback(callback).Execute();
    }

    /// <summary>
    /// test Object list
    /// </summary>
    /// <param name="value">LoginVerifyMessage list</param>
    /// <returns>ResponseResult，list of <see cref="UserMessage"/> UserMessage list</returns>
    /// <code>
    /// // LoginVerifyMessage list
    /// List&lt;LoginVerifyMessage&gt; value = ...;
    /// var result = await SdkAction.ofAwaitListValue(value);
    /// // ioGame: your biz code.
    /// // UserMessage list
    /// var value = result.ListValue&lt;UserMessage&gt;();
    /// result.Log(value);
    /// </code>
    public static async Task<ResponseResult> OfAwaitListValue(List<LoginVerifyMessage> value)
    {
        var dataList = value.Cast<IMessage>().ToList();
        return await RequestCommand.OfAwaitValueList(listValue_1_16, dataList);
    }

    /// <summary>
    /// test error code
    /// </summary>
    /// <param name="value">If the value is equal to 2, an error will be thrown</param>
    /// <param name="callback"><see cref="int"/> int</param>
    /// <returns>RequestCommand</returns>
    /// <code>
    /// // If the value is equal to 2, an error will be thrown
    /// int value = ...;
    /// SdkAction.ofTestError(value, result => {
    ///     // ioGame: your biz code.
    ///     // int
    ///     var value = result.GetInt();
    ///     result.Log(value);
    /// });
    /// </code>
    public static RequestCommand OfTestError(int value, CallbackDelegate callback)
    {
        return RequestCommand.OfInt(testError_1_20, value).OnCallback(callback).Execute();
    }

    /// <summary>
    /// test error code
    /// </summary>
    /// <param name="value">If the value is equal to 2, an error will be thrown</param>
    /// <returns>ResponseResult，<see cref="int"/> int</returns>
    /// <code>
    /// // If the value is equal to 2, an error will be thrown
    /// int value = ...;
    /// var result = await SdkAction.ofAwaitTestError(value);
    /// // ioGame: your biz code.
    /// // int
    /// var value = result.GetInt();
    /// result.Log(value);
    /// </code>
    public static async Task<ResponseResult> OfAwaitTestError(int value)
    {
        return await RequestCommand.OfAwaitInt(testError_1_20, value);
    }

    /// <summary>
    /// noParam method test. 没有参数的方法测试
    /// </summary>
    /// <param name="callback"><see cref="int"/> counter</param>
    /// <returns>RequestCommand</returns>
    /// <code>
    /// SdkAction.ofNoParam(result => {
    ///     // ioGame: your biz code.
    ///     // counter
    ///     var value = result.GetInt();
    ///     result.Log(value);
    /// });
    /// </code>
    public static RequestCommand OfNoParam(CallbackDelegate callback)
    {
        return RequestCommand.Of(noParam_1_60).OnCallback(callback).Execute();
    }

    /// <summary>
    /// noParam method test. 没有参数的方法测试
    /// </summary>
    /// <returns>ResponseResult，<see cref="int"/> counter</returns>
    /// <code>
    /// var result = await SdkAction.ofAwaitNoParam();
    /// // ioGame: your biz code.
    /// // counter
    /// var value = result.GetInt();
    /// result.Log(value);
    /// </code>
    public static async Task<ResponseResult> OfAwaitNoParam()
    {
        return await RequestCommand.OfAwait(noParam_1_60);
    }

    /// <summary>
    /// noReturn method test. 没有返回值的方法测试
    /// </summary>
    /// <param name="name">name</param>
    /// <returns>RequestCommand void</returns>
    /// <code>
    /// // name
    /// string name = ...;
    /// SdkAction.ofNoReturnMethod(name);
    /// </code>
    public static RequestCommand OfNoReturnMethod(string name)
    {
        return RequestCommand.OfString(noReturn_1_61, name).Execute();
    }

  }
}