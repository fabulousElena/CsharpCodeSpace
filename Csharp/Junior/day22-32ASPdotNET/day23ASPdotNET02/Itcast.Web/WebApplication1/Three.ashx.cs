using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    /// <summary>
    /// Three 的摘要说明
    /// </summary>
    public class Three : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Write("Hello World");
            context.Response.Write("sss");
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