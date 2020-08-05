using CZBK.ItcastProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CZBK.ItcastProject.WebApp
{
    /// <summary>
    /// EidtUser 的摘要说明
    /// </summary>
    public class EidtUser : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            //接收数据.
          //  UserInfo userInfo = new UserInfo();
           int id = Convert.ToInt32(context.Request.Form["txtId"]);//接收隐藏中的值
           BLL.UserInfoService UserInfoService = new BLL.UserInfoService();
           UserInfo userInfo=UserInfoService.GetUserInfo(id);
           userInfo.UserName = context.Request.Form["txtName"];
           userInfo.UserPass = context.Request.Form["txtPwd"];
           userInfo.Email = context.Request.Form["txtMail"];
           if (UserInfoService.EditUserInfo(userInfo))
           {
               context.Response.Redirect("UserInfoList.ashx");
             
               
           }
           else
           {
               context.Response.Redirect("Error.html");
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