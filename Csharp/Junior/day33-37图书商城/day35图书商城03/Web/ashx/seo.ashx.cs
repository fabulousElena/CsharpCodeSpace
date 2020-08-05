using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookShop.Web.ashx
{
    /// <summary>
    /// seo 的摘要说明
    /// </summary>
    public class seo : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Write("asdfasfjaslkfjasklfjasdklfja");
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}