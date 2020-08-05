using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CZBK.ItcastProject.WebApp._2015_5_31
{
    /// <summary>
    /// ValidateImageCode 的摘要说明
    /// </summary>
    public class ValidateImageCode : IHttpHandler,System.Web.SessionState.IRequiresSessionState
    {
        //在一般处理程序中如果要使用Session必须实现.IRequiresSessionState接口.
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            Common.ValidateCode validateCode = new Common.ValidateCode();
           string code=validateCode.CreateValidateCode(4);
           context.Session["validateCode"] = code;
           validateCode.CreateValidateGraphic(code,context);
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