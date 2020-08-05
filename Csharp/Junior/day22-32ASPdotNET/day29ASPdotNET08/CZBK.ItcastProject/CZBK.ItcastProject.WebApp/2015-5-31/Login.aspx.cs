using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CZBK.ItcastProject.WebApp._2015_5_31
{
    public partial class Login : System.Web.UI.Page
    {
        public string LoginUserName { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                string userName = Request.Form["txtName"];
                //写到Cookie中.
                Response.Cookies["userName"].Value = Server.UrlEncode(userName);
                Response.Cookies["userName"].Expires = DateTime.Now.AddDays(7);
               
            }
            else
            {
                //读Cookie。
                if (Request.Cookies["userName"] != null)
                {
                    string name =Server.UrlDecode(Request.Cookies["userName"].Value);
                    LoginUserName = name;
                    Response.Cookies["userName"].Value = Server.UrlEncode(name);
                    Response.Cookies["userName"].Expires = DateTime.Now.AddDays(7);
                }
            }
        }
    }
}