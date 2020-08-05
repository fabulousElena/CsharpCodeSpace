using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CZBK.ItcastProject.WebApp._2015_5_29
{
    /// <summary>
    /// Delete 的摘要说明
    /// </summary>
    public class Delete : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            int id;
            if (int.TryParse(context.Request.QueryString["id"], out id))
            {
                BLL.UserInfoService UserInfoService = new BLL.UserInfoService();
                if (UserInfoService.DeleteUserInfo(id))
                {
                    context.Response.Redirect("UserInfoList.aspx");
                }
                else
                {
                    context.Response.Redirect("/Error.html");
                }
            }
            else
            {
                context.Response.Write("参数错误!!");
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