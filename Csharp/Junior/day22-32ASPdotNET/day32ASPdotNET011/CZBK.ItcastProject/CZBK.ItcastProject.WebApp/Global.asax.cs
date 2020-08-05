using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace CZBK.ItcastProject.WebApp
{
    public class Global : System.Web.HttpApplication
    {
        /// <summary>
        /// Web应用程序第一次启动时调用该方法，并且该方法只被调用一次。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Application_Start(object sender, EventArgs e)
        {
           
        }
        /// <summary>
        /// 开始会话。（用户通过浏览器第一次访问我们网站中的某个页面，这时建立会话，但是当该用户通过浏览器再次访问其它的页面时，该方法不会被执行。SessionId）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Session_Start(object sender, EventArgs e)
        {// Application:服务端的状态保持机制。放在该对象中的数据是共享的。 Cache
            Application.Lock();
            int count = Convert.ToInt32(Application["count"]);
            count++;
            Application["count"] = count;
            Application.UnLock();
        }
        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        
        /// <summary>
        /// 全局的异常处理点。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Application_Error(object sender, EventArgs e)
        {
            //Exception ex = HttpContext.Current.Server.GetLastError();
            ///ex.Message
            ///写到日志中。
                //Log4Net
        }
        /// <summary>
        /// 会话结束
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Session_End(object sender, EventArgs e)
        {
            Application.Lock();
            int count = Convert.ToInt32(Application["count"]);
            count--;
            Application["count"] = count;
            Application.UnLock();
        }


        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}