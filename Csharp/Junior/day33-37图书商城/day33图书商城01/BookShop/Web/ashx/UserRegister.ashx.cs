using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace BookShop.Web.ashx
{
    /// <summary>
    /// UserRegister 的摘要说明
    /// </summary>
    public class UserRegister : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            string txtEmail = context.Request["txtEmail"];
            string userName = context.Request["txtName"];
            Regex reg=new Regex(@"^\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$");
            if (!reg.IsMatch(txtEmail))
            {
                context.Response.Write("邮箱错误!!");
                return;
            }
           
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