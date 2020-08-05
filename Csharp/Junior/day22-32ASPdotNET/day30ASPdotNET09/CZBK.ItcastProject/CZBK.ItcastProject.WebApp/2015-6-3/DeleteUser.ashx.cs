using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CZBK.ItcastProject.WebApp._2015_6_3
{
    /// <summary>
    /// DeleteUser 的摘要说明
    /// </summary>
    public class DeleteUser : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            int id = Convert.ToInt32(context.Request["id"]);
            BLL.UserInfoService UserInfoService = new BLL.UserInfoService();
            if (UserInfoService.DeleteUserInfo(id))
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