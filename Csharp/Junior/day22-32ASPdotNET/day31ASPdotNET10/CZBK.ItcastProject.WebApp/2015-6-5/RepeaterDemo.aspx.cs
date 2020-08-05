using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CZBK.ItcastProject.WebApp._2015_6_5
{
    public partial class RepeaterDemo : System.Web.UI.Page
    {
        public int PageIndex { get; set; }
        public int PageCount { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            int pageIndex;
            if (!int.TryParse(Request["pageIndex"], out pageIndex))
            {
                pageIndex = 1;
            }
            int pageSize = 5;
            BLL.UserInfoService UserInfoService = new BLL.UserInfoService();
            int pageCount = UserInfoService.GetPageCount(pageSize);
            PageCount = pageCount;
            pageIndex = pageIndex < 1 ? 1 : pageIndex;
            pageIndex = pageIndex > pageCount ? pageCount : pageIndex;
            PageIndex = pageIndex;
            this.Repeater1.DataSource = UserInfoService.GetPageList(pageIndex,pageSize);
            this.Repeater1.DataBind();

           // ViewState["aaa"] = "asdafsdf";如果将整个页面的ViewState禁用掉，ViewState不能实现状态保持了。
        }


        //ItemCommand:只要是Repeater其它的服务端控件的事件被触发，那么Repetar的ItemCommand事件也会被触发。在ItemCommand事件中可以完成Repeater其它服务端控件事件的处理。
        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "BtnDeleteUser")//表示删除按钮事件触发了.
            {
                Response.Write(Convert.ToInt32(e.CommandArgument));
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}