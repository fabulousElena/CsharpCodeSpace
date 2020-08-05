using CZBK.ItcastProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CZBK.ItcastProject.WebApp._2015_5_30
{
    public partial class NewList : System.Web.UI.Page
    {
        public string StrHtml { get; set; }
        public int PageIndex { get; set; }
        public int PageCount { get; set; }
       
        protected void Page_Load(object sender, EventArgs e)
        {
            int pageSize=5;
            int pageIndex;
            if(!int.TryParse(Request.QueryString["pageIndex"],out pageIndex))
            {
                pageIndex=1;
            }
            BLL.UserInfoService UserInfoService = new BLL.UserInfoService();
            int pagecount = UserInfoService.GetPageCount(pageSize);//获取总页数
            PageCount = pagecount;
            //对当前页码值范围进行判断
            pageIndex = pageIndex < 1 ? 1 : pageIndex;
            pageIndex = pageIndex > pagecount ? pagecount : pageIndex;
            PageIndex = pageIndex;
           List<UserInfo>list= UserInfoService.GetPageList(pageIndex,pageSize);//获取分页数据
           StringBuilder sb = new StringBuilder();
           foreach (UserInfo userInfo in list)
           {
               sb.AppendFormat("<li><span>{0}</span><a href='#' target='_blank'>{1}</a></li>",userInfo.RegTime.ToShortDateString(),userInfo.UserName);
           }
           StrHtml = sb.ToString();
        }
    }
}