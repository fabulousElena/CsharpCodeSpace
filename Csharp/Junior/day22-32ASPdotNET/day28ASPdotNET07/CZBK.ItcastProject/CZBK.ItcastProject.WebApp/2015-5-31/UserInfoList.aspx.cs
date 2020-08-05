using CZBK.ItcastProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CZBK.ItcastProject.WebApp._2015_5_31
{
    public partial class UserInfoList :Common.CheckSession
    {
      
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Session["userInfo"] == null)
            //{
            //    Response.Redirect("UserLogin.aspx");
            //}
            //else
            //{
            //    Response.Write("欢迎"+((UserInfo)Session["userInfo"]).UserName+"登录本系统");
            //}
        }
    }
}