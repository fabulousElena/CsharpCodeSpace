using CZBK.ItcastProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CZBK.ItcastProject.WebApp._2015_5_31
{
    public partial class UserLogin : System.Web.UI.Page
    {
        public string Msg { get; set; }
        public string UserName { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                //string userName = Request.Form["txtName"];
                //UserName = userName;
                if (CheckValidateCode())//先判断验证码是否正确.
                {
                    CheckUserInfo();
                }
                else
                {
                    //验证码错误
                    Msg = "验证码错误!!";

                }
            }
           
        }
        #region 判断用户名密码是否正确
        protected void CheckUserInfo()
        {
            //获取用户输入的用户名和密码.
            string userName = Request.Form["txtName"];
            UserName = userName;
            string userPwd = Request.Form["txtPwd"];
            //校验用户名密码.
            BLL.UserInfoService UserInfoService = new BLL.UserInfoService();
            string msg = string.Empty;
            UserInfo userInfo = null;
            //判断用户名与密码
            if (UserInfoService.ValidateUserInfo(userName, userPwd, out msg, out userInfo))
            {
                Session["userInfo"] = userInfo;
                Response.Redirect("UserInfoList.aspx");
            }
            else
            {
                Msg = msg;
            }
        }

        #endregion
       
        #region 判断验证码是否正确
        protected bool CheckValidateCode()
        {
            bool isSucess = false;
            if (Session["validateCode"] != null)//在使用Session时一定要校验是否为空
            {
                string txtCode = Request.Form["txtCode"];//获取用户输入的验证码。
                string sysCode = Session["validateCode"].ToString();
                if (sysCode.Equals(txtCode, StringComparison.InvariantCultureIgnoreCase))
                {
                    isSucess = true;
                    Session["validateCode"] = null;
                }
            }
            return isSucess;
        }

        #endregion
    }
}