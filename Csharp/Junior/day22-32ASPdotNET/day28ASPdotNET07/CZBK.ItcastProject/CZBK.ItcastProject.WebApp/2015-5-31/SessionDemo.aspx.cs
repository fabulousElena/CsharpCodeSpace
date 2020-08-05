using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CZBK.ItcastProject.WebApp._2015_5_31
{
    public partial class SessionDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                string name=Request.Form["txtName"];
                Session["userName"] = name;
              //  Session.Timeout = 30;
                Response.Redirect("Test.aspx");
            }

        }
    }
}