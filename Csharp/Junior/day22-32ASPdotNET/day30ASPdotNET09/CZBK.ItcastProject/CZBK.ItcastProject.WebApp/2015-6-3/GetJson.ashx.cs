﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CZBK.ItcastProject.WebApp._2015_6_3
{
    /// <summary>
    /// GetJson 的摘要说明
    /// </summary>
    public class GetJson : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Write("{\"Name\":\"zhangsan\",\"Age\":\"12\"}");
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