using CZBK.ItcastProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CZBK.ItcastProject.WebApp._2015_6_2
{
    /// <summary>
    /// UserLogin 的摘要说明
    /// </summary>
    public class UserLogin : IHttpHandler,System.Web.SessionState.IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            string userName = context.Request["userName"];
            string userPwd=context.Request["userPwd"];
            BLL.UserInfoService UserInfoService = new BLL.UserInfoService();
            string msg = string.Empty;
            UserInfo userInfo = null;
            if (UserInfoService.ValidateUserInfo(userName, userPwd, out msg, out userInfo))
            {
                context.Session["userInfo"] = userInfo;
                context.Response.Write("ok:"+msg);
            }
            else
            {
                context.Response.Write("no:" + msg);
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}