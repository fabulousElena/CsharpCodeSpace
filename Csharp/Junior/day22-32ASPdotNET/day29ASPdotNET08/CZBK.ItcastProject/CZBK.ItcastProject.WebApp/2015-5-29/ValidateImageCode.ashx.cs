using CZBK.ItcastProject.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CZBK.ItcastProject.WebApp._2015_5_29
{
    /// <summary>
    /// ValidateImageCode 的摘要说明
    /// </summary>
    public class ValidateImageCode : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            ValidateCode validateCode = new ValidateCode();
            string code=validateCode.CreateValidateCode(4);
            validateCode.CreateValidateGraphic(code, context);
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