using CZBK.ItcastProject.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;

namespace CZBK.ItcastProject.WebApp
{
    /// <summary>
    /// UserInfoList 的摘要说明
    /// </summary>
    public class UserInfoList : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            BLL.UserInfoService UserInfoService = new BLL.UserInfoService();
           List<UserInfo>list= UserInfoService.GetList();
           StringBuilder sb = new StringBuilder();
           foreach (UserInfo userInfo in list)
           {
               sb.AppendFormat("<tr><td>{0}</td><td>{1}</td><td>{2}</td><td>{3}</td><td>{4}</td><td><a href='DeleteUser.ashx?id={0}' class='deletes'>删除</a></td><td><a href='ShowDetail.ashx?uid={0}'>详细</a></td><td><a href='ShowEdit.ashx?id={0}'>编辑</a></td></tr>",userInfo.Id,userInfo.UserName,userInfo.UserPass,userInfo.Email,userInfo.RegTime);
           }
            //读取模板文件
           string filePath = context.Request.MapPath("UserInfoList.html");
           string fileCotent = File.ReadAllText(filePath);
           fileCotent = fileCotent.Replace("@tbody",sb.ToString());
           context.Response.Write(fileCotent);
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