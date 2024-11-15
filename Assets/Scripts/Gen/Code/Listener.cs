// generateTime 2024-11-14 20:17:00
// https://github.com/iohao/ioGame
using Pb.Common;
using IoGame.Sdk;

namespace IoGame.Gen
{
  /// <summary>
  /// Broadcast Listener；广播监听；
  /// </summary>
  /// <remarks>Author: https://github.com/iohao/ioGame</remarks>
  public static class Listener
  {
    private static readonly int bulletBroadcast_1_1 = CmdKit.MappingBroadcast(65537,"trigger bullet broadcast; cn:触发子弹广播");
    private static readonly int intValue_1_32 = CmdKit.MappingBroadcast(65568,"IntValue method description");
    private static readonly int longValue_1_33 = CmdKit.MappingBroadcast(65569,"LongValue");
    private static readonly int boolValue_1_34 = CmdKit.MappingBroadcast(65570,"BoolValue");
    private static readonly int stringValue_1_35 = CmdKit.MappingBroadcast(65571,"StringValue");
    private static readonly int userMessage_1_36 = CmdKit.MappingBroadcast(65572,"UserMessage");
    private static readonly int intValueList_1_42 = CmdKit.MappingBroadcast(65578,"IntValueList method description");
    private static readonly int longValueList_1_43 = CmdKit.MappingBroadcast(65579,"LongValueList");
    private static readonly int boolValueList_1_44 = CmdKit.MappingBroadcast(65580,"BoolValueList");
    private static readonly int stringValueList_1_45 = CmdKit.MappingBroadcast(65581,"StringValueList");
    private static readonly int userMessageList_1_46 = CmdKit.MappingBroadcast(65582,"UserMessageList");

    /// <summary>
    /// trigger bullet broadcast; cn:触发子弹广播
    /// </summary>
    /// <param name="callback"><see cref="BulletMessage"/> Bullet</param>
    /// <code>
    /// Listener.listenBulletBroadcast(result => {
    ///     // Bullet
    ///     const value = result.GetValue&lt;BulletMessage&gt;();
    /// });
    /// </code>
    public static void ListenBulletBroadcast(CallbackDelegate callback)
    {
      ListenCommand.Of(bulletBroadcast_1_1, callback);
    }

    /// <summary>
    /// IntValue method description
    /// </summary>
    /// <param name="callback"><see cref="int"/> biz data description</param>
    /// <code>
    /// Listener.listenIntValue(result => {
    ///     // biz data description
    ///     const value = result.GetInt();
    /// });
    /// </code>
    public static void ListenIntValue(CallbackDelegate callback)
    {
      ListenCommand.Of(intValue_1_32, callback);
    }

    /// <summary>
    /// LongValue
    /// </summary>
    /// <param name="callback"><see cref="long"/> LongValue</param>
    /// <code>
    /// Listener.listenLongValue(result => {
    ///     // LongValue
    ///     const value = result.GetLong();
    /// });
    /// </code>
    public static void ListenLongValue(CallbackDelegate callback)
    {
      ListenCommand.Of(longValue_1_33, callback);
    }

    /// <summary>
    /// BoolValue
    /// </summary>
    /// <param name="callback"><see cref="bool"/> BoolValue</param>
    /// <code>
    /// Listener.listenBoolValue(result => {
    ///     // BoolValue
    ///     const value = result.GetBool();
    /// });
    /// </code>
    public static void ListenBoolValue(CallbackDelegate callback)
    {
      ListenCommand.Of(boolValue_1_34, callback);
    }

    /// <summary>
    /// StringValue
    /// </summary>
    /// <param name="callback"><see cref="string"/> StringValue</param>
    /// <code>
    /// Listener.listenStringValue(result => {
    ///     // StringValue
    ///     const value = result.GetString();
    /// });
    /// </code>
    public static void ListenStringValue(CallbackDelegate callback)
    {
      ListenCommand.Of(stringValue_1_35, callback);
    }

    /// <summary>
    /// UserMessage
    /// </summary>
    /// <param name="callback"><see cref="UserMessage"/> User</param>
    /// <code>
    /// Listener.listenUserMessage(result => {
    ///     // User
    ///     const value = result.GetValue&lt;UserMessage&gt;();
    /// });
    /// </code>
    public static void ListenUserMessage(CallbackDelegate callback)
    {
      ListenCommand.Of(userMessage_1_36, callback);
    }

    /// <summary>
    /// IntValueList method description
    /// </summary>
    /// <param name="callback">list of <see cref="int"/> biz id list</param>
    /// <code>
    /// Listener.listenIntValueList(result => {
    ///     // biz id list
    ///     const value = result.ListInt();
    /// });
    /// </code>
    public static void ListenIntValueList(CallbackDelegate callback)
    {
      ListenCommand.Of(intValueList_1_42, callback);
    }

    /// <summary>
    /// LongValueList
    /// </summary>
    /// <param name="callback">list of <see cref="long"/> LongValueList</param>
    /// <code>
    /// Listener.listenLongValueList(result => {
    ///     // LongValueList
    ///     const value = result.ListLong();
    /// });
    /// </code>
    public static void ListenLongValueList(CallbackDelegate callback)
    {
      ListenCommand.Of(longValueList_1_43, callback);
    }

    /// <summary>
    /// BoolValueList
    /// </summary>
    /// <param name="callback">list of <see cref="bool"/> BoolValueList</param>
    /// <code>
    /// Listener.listenBoolValueList(result => {
    ///     // BoolValueList
    ///     const value = result.ListBool();
    /// });
    /// </code>
    public static void ListenBoolValueList(CallbackDelegate callback)
    {
      ListenCommand.Of(boolValueList_1_44, callback);
    }

    /// <summary>
    /// StringValueList
    /// </summary>
    /// <param name="callback">list of <see cref="string"/> StringValueList</param>
    /// <code>
    /// Listener.listenStringValueList(result => {
    ///     // StringValueList
    ///     const value = result.ListString();
    /// });
    /// </code>
    public static void ListenStringValueList(CallbackDelegate callback)
    {
      ListenCommand.Of(stringValueList_1_45, callback);
    }

    /// <summary>
    /// UserMessageList
    /// </summary>
    /// <param name="callback">list of <see cref="UserMessage"/> User</param>
    /// <code>
    /// Listener.listenUserMessageList(result => {
    ///     // User
    ///     const value = result.ListValue&lt;UserMessage&gt;();
    /// });
    /// </code>
    public static void ListenUserMessageList(CallbackDelegate callback)
    {
      ListenCommand.Of(userMessageList_1_46, callback);
    }

    public static void Listener_ioGame()
    {
      // all listener

      ListenBulletBroadcast(result =>
      {
        var mergeTitle = CmdKit.ToString(result.GetCmdMerge());
        var title = CmdKit.GetBroadcastTitle(result.GetCmdMerge());
        var value = result.GetValue<BulletMessage>();
        IoGameSetting.GameGameConsole.Log($"{mergeTitle}, {title}, {value}");
      });

      ListenIntValue(result =>
      {
        var mergeTitle = CmdKit.ToString(result.GetCmdMerge());
        var title = CmdKit.GetBroadcastTitle(result.GetCmdMerge());
        var value = result.GetInt();
        IoGameSetting.GameGameConsole.Log($"{mergeTitle}, {title}, {value}");
      });

      ListenLongValue(result =>
      {
        var mergeTitle = CmdKit.ToString(result.GetCmdMerge());
        var title = CmdKit.GetBroadcastTitle(result.GetCmdMerge());
        var value = result.GetLong();
        IoGameSetting.GameGameConsole.Log($"{mergeTitle}, {title}, {value}");
      });

      ListenBoolValue(result =>
      {
        var mergeTitle = CmdKit.ToString(result.GetCmdMerge());
        var title = CmdKit.GetBroadcastTitle(result.GetCmdMerge());
        var value = result.GetBool();
        IoGameSetting.GameGameConsole.Log($"{mergeTitle}, {title}, {value}");
      });

      ListenStringValue(result =>
      {
        var mergeTitle = CmdKit.ToString(result.GetCmdMerge());
        var title = CmdKit.GetBroadcastTitle(result.GetCmdMerge());
        var value = result.GetString();
        IoGameSetting.GameGameConsole.Log($"{mergeTitle}, {title}, {value}");
      });

      ListenUserMessage(result =>
      {
        var mergeTitle = CmdKit.ToString(result.GetCmdMerge());
        var title = CmdKit.GetBroadcastTitle(result.GetCmdMerge());
        var value = result.GetValue<UserMessage>();
        IoGameSetting.GameGameConsole.Log($"{mergeTitle}, {title}, {value}");
      });

      ListenIntValueList(result =>
      {
        var mergeTitle = CmdKit.ToString(result.GetCmdMerge());
        var title = CmdKit.GetBroadcastTitle(result.GetCmdMerge());
        var value = result.ListInt();
        IoGameSetting.GameGameConsole.Log($"{mergeTitle}, {title}, {value}");
      });

      ListenLongValueList(result =>
      {
        var mergeTitle = CmdKit.ToString(result.GetCmdMerge());
        var title = CmdKit.GetBroadcastTitle(result.GetCmdMerge());
        var value = result.ListLong();
        IoGameSetting.GameGameConsole.Log($"{mergeTitle}, {title}, {value}");
      });

      ListenBoolValueList(result =>
      {
        var mergeTitle = CmdKit.ToString(result.GetCmdMerge());
        var title = CmdKit.GetBroadcastTitle(result.GetCmdMerge());
        var value = result.ListBool();
        IoGameSetting.GameGameConsole.Log($"{mergeTitle}, {title}, {value}");
      });

      ListenStringValueList(result =>
      {
        var mergeTitle = CmdKit.ToString(result.GetCmdMerge());
        var title = CmdKit.GetBroadcastTitle(result.GetCmdMerge());
        var value = result.ListString();
        IoGameSetting.GameGameConsole.Log($"{mergeTitle}, {title}, {value}");
      });

      ListenUserMessageList(result =>
      {
        var mergeTitle = CmdKit.ToString(result.GetCmdMerge());
        var title = CmdKit.GetBroadcastTitle(result.GetCmdMerge());
        var value = result.ListValue<UserMessage>();
        IoGameSetting.GameGameConsole.Log($"{mergeTitle}, {title}, {value}");
      });
    }
  }
}