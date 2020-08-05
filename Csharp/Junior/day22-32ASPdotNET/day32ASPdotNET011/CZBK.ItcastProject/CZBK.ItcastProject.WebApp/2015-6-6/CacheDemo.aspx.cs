using CZBK.ItcastProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Caching;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CZBK.ItcastProject.WebApp._2015_6_6
{
    public partial class CacheDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
                //判断缓存中是否有数据.
                if (Cache["userInfoList"] == null)
                {
                    BLL.UserInfoService UserInfoService = new BLL.UserInfoService();
                    List<UserInfo> list = UserInfoService.GetList();
                    //将数据放到缓存中。
                    //  Cache["userInfoList"] = list;

                    Cache.Insert("userInfoList", list, null, DateTime.Now.AddSeconds(5), TimeSpan.Zero, System.Web.Caching.CacheItemPriority.Normal, RemoveCache);
                    Response.Write("数据来自数据库");
                    //Cache.Remove("userInfoList");//移除缓存
                }
                else
                {
                    List<UserInfo> list = (List<UserInfo>)Cache["userInfoList"];

                }
                Response.Write("数据来自缓存");
           
       
        }
        protected void RemoveCache(string key, object value, CacheItemRemovedReason reason)
        {
            if (reason == CacheItemRemovedReason.Expired)
            {
                //缓存移除的原因写到日志中。
            }
        }
    }
}