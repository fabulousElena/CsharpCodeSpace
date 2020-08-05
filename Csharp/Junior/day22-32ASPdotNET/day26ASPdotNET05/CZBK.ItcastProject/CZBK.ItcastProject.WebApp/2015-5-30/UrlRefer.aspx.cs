using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CZBK.ItcastProject.WebApp._2015_5_30
{
    public partial class UrlRefer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            Response.Write(Request.Url.ToString());//获取当前请求的URL地址。
            Response.Write("<hr/>");
            //Response.Clear();
           // Respons面的代码不会被执行。
          //  Responsee.End();//后.Write(Request.UrlReferrer.ToString());//请求的来源
            //盗链。

        

        }
    }
}