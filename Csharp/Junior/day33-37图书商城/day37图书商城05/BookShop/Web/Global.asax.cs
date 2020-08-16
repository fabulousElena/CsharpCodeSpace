using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace BookShop.Web
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {

        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 请求管道中第一个事件触发以后调用的方法，完成URL重写。
        /// URL重写。
       ///带参数的URL地址进行改写。改写成不带参数的。
        //BookDetail.aspx?id=2;   BookDetail_2.aspx

        //为什么将带参数的URL地址改成不带参数的？URL重写的目的就是SEO。

        //SEO.

        //怎样进行URL重写？

        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            string url = Request.AppRelativeCurrentExecutionFilePath;//~/BookDetail_4976.aspx
            Match match=Regex.Match(url, @"~/BookDetail_(\d+).aspx");
            if (match.Success)
            {
                Context.RewritePath("/BookDetail.aspx?id="+match.Groups[1].Value);
            }

            //Match match = Regex.Match(url, @"~/BookDetail_(\d+).aspx");
            //if (match.Success)
            //{
            //    Context.RewritePath("/BookDetail.aspx?id=" + match.Groups[1].Value);
            //}




        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}