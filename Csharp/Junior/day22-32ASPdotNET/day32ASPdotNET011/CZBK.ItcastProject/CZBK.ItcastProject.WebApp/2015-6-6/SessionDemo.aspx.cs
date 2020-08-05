using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CZBK.ItcastProject.WebApp._2015_6_6
{
    public partial class SessionDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["str"] = "itcast.com";
            Response.Redirect("ReadSessionDemo.aspx");
        }
    }
}