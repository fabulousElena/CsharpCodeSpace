using CZBK.ItcastProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
namespace CZBK.ItcastProject.WebApp
{
    /// <summary>
    /// ShowDetail 的摘要说明
    /// </summary>
    public class ShowDetail : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            int id;
            if (int.TryParse(context.Request.QueryString["uid"], out id))
            {
                BLL.UserInfoService UserInfoService = new BLL.UserInfoService();
                UserInfo userInfo=UserInfoService.GetUserInfo(id);//获取用户的信息.
                if (userInfo != null)
                {
                    string filePath = context.Request.MapPath("Detail.html");
                   string fileContent=File.ReadAllText(filePath);
                   fileContent = fileContent.Replace("$name",userInfo.UserName).Replace("$pwd",userInfo.UserPass);
                   context.Response.Write(fileContent);
                }
                else
                {
                    context.Response.Redirect("Error.html");
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