using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    /// <summary>
    /// Two 的摘要说明
    /// </summary>
    public class Two : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Write("Hello World");
            SqlHelper helper = new SqlHelper();
           context.Response.Write(helper.Add(3,6));
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