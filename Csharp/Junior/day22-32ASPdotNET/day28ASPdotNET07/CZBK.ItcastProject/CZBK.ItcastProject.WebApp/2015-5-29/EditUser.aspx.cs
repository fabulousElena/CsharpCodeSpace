using CZBK.ItcastProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CZBK.ItcastProject.WebApp._2015_5_29
{
    public partial class EditUser : System.Web.UI.Page
    {
        public UserInfo EditUserInfo { get; set; }
        BLL.UserInfoService UserInfoService = new BLL.UserInfoService();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ShowEditUserInfo();
            }
            else
            {
                UpdateUserInfo();
            }
        }
        /// <summary>
        /// 展示要修改的用户的信息
        /// </summary>
        protected void ShowEditUserInfo()
        {
            int id;
            if (int.TryParse(Request.QueryString["id"], out id))
            {
               
                UserInfo userInfo = UserInfoService.GetUserInfo(id);
                if (userInfo != null)
                {
                    EditUserInfo = userInfo;
                }
                else
                {
                    Response.Redirect("/Error.html");
                }
            }
            else
            {
                Response.Redirect("/Error.html");
            }
        }
        /// <summary>
        /// 完成数据的更新
        /// </summary>
        protected void UpdateUserInfo()
        {
            UserInfo userInfo = new UserInfo();
            userInfo.Id = Convert.ToInt32(Request.Form["txtId"]);
            userInfo.UserName=Request.Form["txtName"];
            userInfo.UserPass=Request.Form["txtPwd"];
            userInfo.Email = Request.Form["txtMail"];
            userInfo.RegTime = Convert.ToDateTime(Request.Form["txtRegTime"]);
            if (UserInfoService.EditUserInfo(userInfo))
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