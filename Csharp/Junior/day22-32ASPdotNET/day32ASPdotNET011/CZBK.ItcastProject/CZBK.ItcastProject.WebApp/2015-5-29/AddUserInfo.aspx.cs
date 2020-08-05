using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CZBK.ItcastProject.WebApp._2015_5_29
{
    public partial class AddUserInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //如果隐藏域的值不为空，表示用户单击了提交按钮发出了POST请求
           // if (!string.IsNullOrEmpty(Request.Form["isPostBack"]))
            //IsPostBack：如果是POST请求该属性的值为true,如果是GET请求该属性的值为false.
            //IsPostBack：是根据__VIEWSTATE隐藏域进行判断的，如果是POST请求那么该隐藏域的值会提交到服务端，那么IsPostBack属性也就为true.如果将form标签的runat="server"去掉，那么就不能用该属性进行判断是POST请求还是GET请求。因为去掉form标签的runat="server",那么就不会再产生 __VIEWSTATE隐藏域了。
            if(IsPostBack)//
            {
                InsertUserInfo();
            }
        }
        protected void InsertUserInfo()
        {
            Model.UserInfo UserInfo = new Model.UserInfo();
            UserInfo.UserName=Request.Form["txtName"];
            UserInfo.UserPass = Request.Form["txtPwd"];
            UserInfo.Email = Request.Form["txtMail"];
            UserInfo.RegTime = DateTime.Now;
            BLL.UserInfoService UserInfoService = new BLL.UserInfoService();
            if (UserInfoService.AddUserInfo(UserInfo))
            {
                Response.Redirect("UserInfoList.aspx");
            }
            else
            {
                Response.Redirect("/Error.html");
            }
        }
    }
}