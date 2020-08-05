using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CZBK.ItcastProject.WebApp._2015_5_31
{
    public partial class CookieDemo2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //获取Cookie的值
            if (Request.Cookies["cp2"] != null)
            {
                Response.Write(Request.Cookies["cp2"].Value);
            }
        }
    }
}