using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BookShop.Web.Member
{
    public partial class Login : System.Web.UI.Page
    {
        public string Msg { get; set; }
        public string ReturnUrl = string.Empty;
        BLL.UserManager UserManager = new BLL.UserManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                UserLogin();
            }
            else
            {
                ReturnUrl = Request["returnUrl"];//如果能够接收到传递过来的参数（存储的是用户接下来要访问的URL地址），把数据存储到隐藏域中。
                //校验Cookie中是否有值
                CheckCookieInfo();

              
            }
        }
        /// <summary>
        /// 校验Cookie的值
        /// </summary>
        private void CheckCookieInfo()
        {
            if (Request.Cookies["cp1"] != null && Request.Cookies["cp2"] != null)
            {
                string userName = Request.Cookies["cp1"].Value;
                string userPwd = Request.Cookies["cp2"].Value;
                Model.User userInfo=UserManager.GetModel(userName);
                if (userInfo != null)
                {
                    if (userPwd == Common.WebCommon.GetMd5String(Common.WebCommon.GetMd5String(userInfo.LoginPwd)))
                    {
                        Session["userInfo"] = userInfo;
                        if (!string.IsNullOrEmpty(Request["returnUrl"]))
                        {
                            Response.Redirect(Request["returnUrl"]);
                        }
                        else
                        {
                            Response.Redirect("/Default.aspx");
                        }
                    }
                }
                Response.Cookies["cp1"].Expires = DateTime.Now.AddDays(-1);
                Response.Cookies["cp2"].Expires = DateTime.Now.AddDays(-1);
            }
        }

        private void UserLogin()
        {
            string userName = Request["txtLoginId"];
            string userPwd =Request["txtLoginPwd"];
            string msg = string.Empty;
            Model.User userInfo = null;
         
            bool b = UserManager.CheckUserInfo(userName, userPwd, out msg, out userInfo);
            if (b)
            {
                Session["userInfo"] = userInfo;
                //判断用户是否选择了”自动登录“
                if (!string.IsNullOrEmpty(Request["cbAutoLogin"]))
                {
                    HttpCookie cookie1 = new HttpCookie("cp1",userName);
                    HttpCookie cookie2 = new HttpCookie("cp2", Common.WebCommon.GetMd5String(Common.WebCommon.GetMd5String(userPwd)));
                    cookie1.Expires = DateTime.Now.AddDays(7);
                    cookie2.Expires = DateTime.Now.AddDays(7);
                    Response.Cookies.Add(cookie1);
                    Response.Cookies.Add(cookie2);
                }

                //单击提交按钮，会将隐藏域的值提交过来。
                if (string.IsNullOrEmpty(Request["hiddenReturnUrl"]))
                {
                    Response.Redirect("/Default.aspx");
                }
                else
                {
                    Response.Redirect(Request["hiddenReturnUrl"]);
                }
            }
            else
            {
                Msg = msg;
            }
        }
    }
}