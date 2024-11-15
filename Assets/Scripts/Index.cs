using System.Collections.Generic;
using System.Threading.Tasks;
using IoGame.Gen;
using Pb.Common;
using UnityEngine;

public class Index
{
    public static async Task OnIntValue()
    {
        Log("------- OnIntValue ------");
        const int value = 1;

        // code style: callback.
        SdkAction.OfIntValue(value, result =>
        {
            // value
            result.Log(result.GetInt());
        });

        // code style: await promise.
        var result = await SdkAction.OfAwaitIntValue(value);
        result.Log(result.GetInt());
    }

    public static async Task OnLongValue()
    {
        Log("------- OnLongValue ------");
        const long value = long.MaxValue;

        // code style: callback.
        SdkAction.OfLongValue(value, result =>
        {
            // value
            result.Log(result.GetLong());
        });

        // code style: await promise.
        var result = await SdkAction.OfAwaitLongValue(value);
        result.Log(result.GetLong());
    }

    public static async Task OnBoolValue()
    {
        Log("------- OnBoolValue ------");
        const bool value = true;

        // code style: callback.
        SdkAction.OfBoolValue(value, result =>
        {
            // value
            result.Log(result.GetBool());
        });

        // code style: await promise.
        var result = await SdkAction.OfAwaitBoolValue(value);
        result.Log(result.GetBool());
    }

    public static async Task OnStringValue()
    {
        Log("------- OnStringValue ------");
        const string value = "ioGame - ";

        // code style: callback.
        SdkAction.OfStringValue(value, result =>
        {
            // value
            result.Log(result.GetString());
        });

        // code style: await promise.
        var result = await SdkAction.OfAwaitStringValue(value);
        result.Log(result.GetString());
    }

    public static async Task OnValueObject()
    {
        Log("------- OnValueObject ------");
        var value = new LoginVerifyMessage { Jwt = "10" };

        // code style: callback.
        SdkAction.OfValue(value, result =>
        {
            var userMessage = result.GetValue<UserMessage>();
            result.Log(userMessage);
        });

        // code style: await promise.
        var result = await SdkAction.OfAwaitValue(value);
        var userMessage = result.GetValue<UserMessage>();
        result.Log(userMessage);
    }

    public static async Task OnListInt()
    {
        Log("------- OnListInt ------");
        var valueList = new List<int> { 1, 2 };

        // code style: callback.
        SdkAction.OfListInt(valueList, result =>
        {
            // value
            result.Log(result.ListInt());
        });

        // code style: await promise.
        var result = await SdkAction.OfAwaitListInt(valueList);
        result.Log(result.ListInt());
    }

    public static async Task OnListLong()
    {
        Log("------- OnListLong ------");
        var valueList = new List<long> { long.MaxValue, long.MaxValue - 1 };

        // code style: callback.
        SdkAction.OfListLong(valueList, result =>
        {
            // value
            result.Log(result.ListLong());
        });

        // code style: await promise.
        var result = await SdkAction.OfAwaitListLong(valueList);
        result.Log(result.ListLong());
    }

    public static async Task OnListBool()
    {
        Log("------- OnListBool ------");
        var valueList = new List<bool> { true, false };

        // code style: callback.
        SdkAction.OfListBool(valueList, result =>
        {
            // value
            result.Log(result.ListBool());
        });

        // code style: await promise.
        var result = await SdkAction.OfAwaitListBool(valueList);
        result.Log(result.ListBool());
    }

    public static async Task OnListString()
    {
        Log("------- OnListString ------");
        var valueList = new List<string> { "ioGame - " };

        // code style: callback.
        SdkAction.OfListString(valueList, result =>
        {
            // value
            result.Log(result.ListString());
        });

        // code style: await promise.
        var result = await SdkAction.OfAwaitListString(valueList);
        result.Log(result.ListString());
    }

    public static async Task OnListValue()
    {
        Log("------- OnListValue ------");
        var valueList = new List<LoginVerifyMessage> { new() { Jwt = "10" }, new() { Jwt = "11" } };

        // code style: callback.
        SdkAction.OfListValue(valueList, result =>
        {
            var userMessageList = result.ListValue<UserMessage>();
            result.Log(userMessageList);
        });

        // code style: await promise.
        var result = await SdkAction.OfAwaitListValue(valueList);
        var userMessageList = result.ListValue<UserMessage>();
        result.Log(userMessageList);
    }

    private static int _testErrorValue = 1;

    public static async Task OnTestError()
    {
        if (_testErrorValue > 2)
            _testErrorValue = 1;

        var value = _testErrorValue++;
        Log("------- OnTestError ------");

        // code style: callback.
        SdkAction.OfTestError(value, result =>
        {
            // value
            result.Log(result.GetInt());
        }).OnError(result =>
        {
            // error
            result.Log(result.GetErrorInfo());
        });

        // code style: await promise.
        var result = await SdkAction.OfAwaitTestError(value);
        if (result.Success())
            result.Log(result.GetInt());
        else
            result.Log(result.GetErrorInfo());
    }

    public static void OnTriggerBroadcast()
    {
        // Clicking here will trigger the broadcast.
        Log("------- OnTriggerBroadcast ------");
        SdkAction.OfTriggerBroadcast();
    }

    public static void Listen()
    {
        // listen single value
        Listener.ListenIntValue(result => { result.Log(result.GetInt()); });
        Listener.ListenLongValue(result => { result.Log(result.GetLong()); });
        Listener.ListenBoolValue(result => { result.Log(result.GetBool()); });
        Listener.ListenStringValue(result => { result.Log(result.GetString()); });
        Listener.ListenUserMessage(result =>
        {
            var userMessage = result.GetValue<UserMessage>();
            result.Log(userMessage);
        });

        // listen list value
        Listener.ListenIntValueList(result => { result.ListInt(); });
        Listener.ListenLongValueList(result => { result.ListLong(); });
        Listener.ListenBoolValueList(result => { result.ListBool(); });
        Listener.ListenStringValueList(result => { result.ListString(); });
        Listener.ListenUserMessageList(result =>
        {
            var userMessageList = result.ListValue<UserMessage>();
            result.Log(userMessageList);
        });

        // other
        Listener.ListenBulletBroadcast(result =>
        {
            var bulletMessage = result.GetValue<BulletMessage>();
            result.Log(bulletMessage);
        });
    }

    private static void Log(string value)
    {
        Debug.Log(value);
    }
}