using CZBK.ItcastProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CZBK.ItcastProject.WebApp._2015_6_3
{
    /// <summary>
    /// EditUserInfo 的摘要说明
    /// </summary>
    public class EditUserInfo : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            UserInfo userInfo = new UserInfo();
            userInfo.UserName = context.Request["txtEditUserName"];
            userInfo.UserPass = context.Request["txtEditUserPwd"];
            userInfo.Email = context.Request["txtEditUserMail"];
            userInfo.Id = Convert.ToInt32(context.Request["txtEditUserId"]);
            userInfo.RegTime = Convert.ToDateTime(context.Request["txtEditRegTime"]);
            BLL.UserInfoService UserInfoService = new BLL.UserInfoService();
            if (UserInfoService.EditUserInfo(userInfo))
            {
                context.Response.Write("yes");
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