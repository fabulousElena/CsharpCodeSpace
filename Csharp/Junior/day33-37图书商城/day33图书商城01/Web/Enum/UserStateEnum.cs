using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookShop.Web.Enum
{
    public enum UserStateEnum
    {
        /// <summary>
        /// 用户已经被锁定
        /// </summary>
        LockState=0,
        /// <summary>
        /// 用户正常状态
        /// </summary>
        NormalState=1
    }
}