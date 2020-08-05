using CZBK.ItcastProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CZBK.ItcastProject.WebApp._2015_6_3
{
    /// <summary>
    /// AddUserInfo 的摘要说明
    /// </summary>
    public class AddUserInfo : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            UserInfo userInfo = new UserInfo();
            userInfo.UserName = context.Request["txtUserName"];
            userInfo.UserPass = context.Request["txtUserPwd"];
            userInfo.Email = context.Request["txtUserMail"];
            userInfo.RegTime = DateTime.Now;
            BLL.UserInfoService UserInfoService = new BLL.UserInfoService();
            if (UserInfoService.AddUserInfo(userInfo))
            {
                context.Response.Write("ok");
            }
            else
            {
                 context.Response.Write("no");
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