using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace CZBK.ItcastProject.Common
{
   public class ValidateSessionHttpModule:IHttpModule
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }
       /// <summary>
       /// 完成请求管道中事件的注册。
       /// </summary>
       /// <param name="context"></param>
        public void Init(HttpApplication context)
        {
           context.AcquireRequestState+=context_AcquireRequestState;
        }
        public void context_AcquireRequestState(object sender, EventArgs e)
        {
            HttpApplication application = sender as HttpApplication;
            HttpContext context=application.Context;//获取当前的HttpContext
           string url= context.Request.Url.ToString();//获取用户请求的URL地址。
           if (url.Contains("Admin"))
           {
               if (context.Session["userInfo"] == null)
               {
                   context.Response.Redirect("/Login.aspx");
               }
           }
        }
    }
}
