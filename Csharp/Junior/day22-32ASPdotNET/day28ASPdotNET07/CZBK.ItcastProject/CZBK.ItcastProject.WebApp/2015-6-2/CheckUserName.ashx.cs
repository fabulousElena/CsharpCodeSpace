using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CZBK.ItcastProject.WebApp._2015_6_2
{
    /// <summary>
    /// CheckUserName 的摘要说明
    /// </summary>
    public class CheckUserName : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
           string userName=context.Request["name"];
           BLL.UserInfoService UserInfoService = new BLL.UserInfoService();
           if (UserInfoService.GetUserInfo(userName) != null)
           {
               context.Response.Write("此用户名已存在!!");
           }
           else
           {
               context.Response.Write("此用户名可用!!");
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