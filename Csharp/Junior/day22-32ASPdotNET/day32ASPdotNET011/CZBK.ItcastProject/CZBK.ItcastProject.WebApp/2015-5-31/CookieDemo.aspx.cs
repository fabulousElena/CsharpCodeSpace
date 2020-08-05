using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CZBK.ItcastProject.WebApp._2015_5_31
{
    public partial class CookieDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Cookie:是一个客户端状态保持机制，（网站的数据是存在客户端），与隐藏域与ViewState对象都属于这种客户端状态保持，Cookie中存储的是关于网站相关的文本字符串数据。Cookie的存储方式有两种，如果不指定过期时间，那么存储在客户端浏览器内存中，如果指定了过期时间，那么存储在客户端的磁盘上。Cookie是与具体的网站有关的，如果我们将Cookie设置了过期时间，那么当用户在指定时间内访问我们的网站，那么属于我们网站的Cookie数据会放在请求报文中发送过来，其它网站的Cookie不会发送。

            //创建Cookie.
           // Response.Cookies["cp1"].Value = "itcast";


            //创建Cookie并且指定过期时间.
            //Response.Cookies["cp2"].Value = "laowang";
            //Response.Cookies["cp2"].Expires = DateTime.Now.AddDays(3);

            //删除Cookie
           // Response.Cookies["cp2"].Expires = DateTime.Now.AddDays(-1);


            //Cookie跨域(域名)
            Response.Cookies["cp3"].Value = "laowang";
           // Response.Cookies["cp3"].Domain = "xxx.com";//设置主域的。
            Response.Cookies["cp3"].Path = "/2015-5-31";
            Response.Cookies["cp3"].Expires = DateTime.Now.AddDays(3);


            //另外一种创建Cookie的方式。
            HttpCookie cookie1 = new HttpCookie("cp4","sssss");
            cookie1.Expires = DateTime.Now.AddDays(3);
            Response.Cookies.Add(cookie1);
            
        }
    }
}