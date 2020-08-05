using CZBK.ItcastProject.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace CZBK.ItcastProject.WebApp
{
    /// <summary>
    /// ShowEdit 的摘要说明
    /// </summary>
    public class ShowEdit : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            int id;
            if (int.TryParse(context.Request.QueryString["id"], out id))
            {
                BLL.UserInfoService UserInfoService = new BLL.UserInfoService();
                UserInfo userInfo=UserInfoService.GetUserInfo(id);
                if (userInfo != null)
                {
                    //读取模板文件，替换表单中的占位符.
                    string filePath = context.Request.MapPath("ShowEditUser.html");
                    string fileContent = File.ReadAllText(filePath);
                    fileContent = fileContent.Replace("$name",userInfo.UserName).Replace("$pwd",userInfo.UserPass).Replace("$mail",userInfo.Email).Replace("$Id",userInfo.Id.ToString());
                    context.Response.Write(fileContent);
                }
                else
                {
                    context.Response.Write("查无此人!!");
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