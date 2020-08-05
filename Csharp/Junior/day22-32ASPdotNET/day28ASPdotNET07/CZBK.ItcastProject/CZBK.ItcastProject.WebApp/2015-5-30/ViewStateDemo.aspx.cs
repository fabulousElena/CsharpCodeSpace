using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CZBK.ItcastProject.WebApp._2015_5_30
{
    public partial class ViewStateDemo : System.Web.UI.Page
    {
        public int Count { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            int count = 0;
            if (ViewState["count"] != null)
            {
                count = Convert.ToInt32(ViewState["count"]);
                count++;
                Count = count;
            }
            ViewState["count"] = Count;//当我们把数据给了ViewState对象以后，该对象会将数据进行编码，然后存到__VIEWSTATE隐藏域中，然后返回给浏览器。
           //当用户通过浏览器单击“提交”按钮，会向服务端发送一个POST请求那么__VIEWSTATE隐藏域的值也会提交到服务端，那么服务端自动接收__VIEWSTATE隐藏域的值，并且再反编码，重新赋值给ViewState对象。
        }
    }
}