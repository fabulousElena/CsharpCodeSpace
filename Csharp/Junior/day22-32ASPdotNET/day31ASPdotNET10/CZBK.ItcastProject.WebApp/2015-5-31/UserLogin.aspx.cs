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
            else
            {
                //判断Cookie中的值。
                CheckCookieInfo();
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
                //判断用户是否选择了“自动登录”
                if (!string.IsNullOrEmpty(Request.Form["autoLogin"]))//页面上如果有多个复选框时，只能将选中复选框的的值提交到服务端。
                {
                    HttpCookie cookie1 = new HttpCookie("cp1",userName);
                    HttpCookie cookie2 = new HttpCookie("cp2", Common.WebCommon.GetMd5String(Common.WebCommon.GetMd5String(userPwd)));
                    cookie1.Expires = DateTime.Now.AddDays(7);
                    cookie2.Expires = DateTime.Now.AddDays(7);
                    Response.Cookies.Add(cookie1);
                    Response.Cookies.Add(cookie2);
                }

                Session["userInfo"] = userInfo;
                Response.Redirect("UserInfoList.aspx");
            }
            else
            {
                Msg = msg;
            }
        }

        #endregion

        #region 校验Cookie信息.
        protected void CheckCookieInfo()
        {
            if (Request.Cookies["cp1"] != null && Request.Cookies["cp2"] != null)
            {
                string userName = Request.Cookies["cp1"].Value;
                string userPwd = Request.Cookies["cp2"].Value;
                //校验
                BLL.UserInfoService UserInfoService = new BLL.UserInfoService();
                UserInfo userInfo=UserInfoService.GetUserInfo(userName);
                if (userInfo != null)
                {
                    //注意：在添加用户或注册用户时一定要将用户输入的密码加密以后在存储到数据库中。
                    if (userPwd == Common.WebCommon.GetMd5String(Common.WebCommon.GetMd5String(userInfo.UserPass)))
                    {
                        Session["userInfo"] = userInfo;
                        Response.Redirect("UserInfoList.aspx");
                    }
                }
                Response.Cookies["cp1"].Expires = DateTime.Now.AddDays(-1);
                Response.Cookies["cp2"].Expires = DateTime.Now.AddDays(-1);
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