// generateTime 2024-11-14 20:17:00
// https://github.com/iohao/ioGame

using System.Collections.Generic;
using IoGame.Sdk;

namespace IoGame.Gen
{
    /// <summary>
    /// GameCode、ErrorCode. 游戏错误码
    /// </summary>
    /// <remarks>Author: https://github.com/iohao/ioGame</remarks>
    public static class GameCode
    {
        /// <summary>
        /// 绑定的游戏逻辑服不存在
        /// </summary>
        public static readonly int FindBindingLogicServerNotExist = CmdKit.MappingErrorCode(-1008, "绑定的游戏逻辑服不存在");

        /// <summary>
        /// 强制玩家下线
        /// </summary>
        public static readonly int ForcedOffline = CmdKit.MappingErrorCode(-1007, "强制玩家下线");

        /// <summary>
        /// 数据不存在
        /// </summary>
        public static readonly int DataNotExist = CmdKit.MappingErrorCode(-1006, "数据不存在");

        /// <summary>
        /// class 不存在
        /// </summary>
        public static readonly int ClassNotExist = CmdKit.MappingErrorCode(-1005, "class 不存在");

        /// <summary>
        /// 请先登录
        /// </summary>
        public static readonly int VerifyIdentity = CmdKit.MappingErrorCode(-1004, "请先登录");

        /// <summary>
        /// 心跳超时相关
        /// </summary>
        public static readonly int IdleErrorCode = CmdKit.MappingErrorCode(-1003, "心跳超时相关");

        /// <summary>
        /// 路由错误
        /// </summary>
        public static readonly int CmdInfoErrorCode = CmdKit.MappingErrorCode(-1002, "路由错误");

        /// <summary>
        /// 参数验错误
        /// </summary>
        public static readonly int ValidateErrCode = CmdKit.MappingErrorCode(-1001, "参数验错误");

        /// <summary>
        /// 系统其它错误
        /// </summary>
        public static readonly int SystemOtherErrCode = CmdKit.MappingErrorCode(-1000, "系统其它错误");

        /// <summary>
        /// login error
        /// </summary>
        public static readonly int LoginError = CmdKit.MappingErrorCode(1, "login error");

        /// <summary>
        /// test error
        /// </summary>
        public static readonly int TestError = CmdKit.MappingErrorCode(2, "test error");

        public static void Init() {
            // trigger errorCodeMapping init.
            // 调用一次方法，触发错误码的初始化操作。
            var ints = new List<int>
            {
                FindBindingLogicServerNotExist,
                            ForcedOffline,
                            DataNotExist,
                            ClassNotExist,
                            VerifyIdentity,
                            IdleErrorCode,
                            CmdInfoErrorCode,
                            ValidateErrCode,
                            SystemOtherErrCode,
                            LoginError,
                            TestError,
            0
            };
        }
    }
}