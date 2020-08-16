using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.IO;
using System.Threading;

namespace BookShop.Web
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           // Path.Combine(
           // HttpRuntime.AppDomainAppPath
            //Request.MapPath();

      //  string filePath = HttpContext.Current.Request.MapPath("/Images/body.jpg");
            ParameterizedThreadStart par = new
             ParameterizedThreadStart(GetFilePath);
            Thread thread1 = new Thread(par);
            thread1.IsBackground = true;
            thread1.Start(HttpContext.Current);
            //GetFilePath();

        }
        protected void GetFilePath(object context)
        {
            Common.WebCommon.GetFilePath(context);
        }
    }
}
