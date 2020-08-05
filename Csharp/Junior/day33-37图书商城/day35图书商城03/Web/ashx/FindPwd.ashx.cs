using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookShop.Web.ashx
{
    /// <summary>
    /// FindPwd 的摘要说明
    /// </summary>
    public class FindPwd : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            string name = context.Request["name"];
            string mail=context.Request["mail"];
            BLL.UserManager UserInfoManager = new BLL.UserManager();
            Model.User userInfo = UserInfoManager.GetModel(name);
            if (userInfo != null)
            {
                if (userInfo.Mail == mail)
                {
                    UserInfoManager.FindUserPwd(userInfo);//找回用户的密码
                }
                else
                {
                    context.Response.Write("邮箱错误!!");
                }
            }
            else
            {
                context.Response.Write("查无此人!!");
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