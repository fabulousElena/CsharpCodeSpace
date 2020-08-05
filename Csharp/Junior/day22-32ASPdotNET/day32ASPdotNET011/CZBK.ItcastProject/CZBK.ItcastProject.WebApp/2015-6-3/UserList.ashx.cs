using CZBK.ItcastProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CZBK.ItcastProject.WebApp._2015_6_3
{
    /// <summary>
    /// UserList 的摘要说明
    /// </summary>
    public class UserList : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            int pageIndex;
            if (!int.TryParse(context.Request["pageIndex"], out pageIndex))
            {
                pageIndex = 1;
            }
            int pageSize = 5;
            BLL.UserInfoService UserInfoService = new BLL.UserInfoService();
            int pageCount = UserInfoService.GetPageCount(pageSize);//获取总页数.
            //判断当前页码值的取值范围。
            pageIndex = pageIndex < 1 ? 1 : pageIndex;
            pageIndex=pageIndex>pageCount?pageCount:pageIndex;
            //获取分页数据
            List<UserInfo>list=UserInfoService.GetPageList(pageIndex,pageSize);
            //获取页码条。
            string pageBar = Common.PageBarHelper.GetPagaBar(pageIndex, pageCount);

            System.Web.Script.Serialization.JavaScriptSerializer js = new System.Web.Script.Serialization.JavaScriptSerializer();
            string str = js.Serialize(new  { UList = list, MyPageBar = pageBar });//将数据序列化成JSON字符串。匿名类。
          context.Response.Write(str);
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