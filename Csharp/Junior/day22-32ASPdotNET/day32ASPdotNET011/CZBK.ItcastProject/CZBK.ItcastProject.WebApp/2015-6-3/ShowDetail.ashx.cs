using CZBK.ItcastProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CZBK.ItcastProject.WebApp._2015_6_3
{
    /// <summary>
    /// ShowDetail 的摘要说明
    /// </summary>
    public class ShowDetail : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            int id = Convert.ToInt32(context.Request["id"]);
            BLL.UserInfoService UserInfoService = new BLL.UserInfoService();
            UserInfo userInfo=UserInfoService.GetUserInfo(id);
            System.Web.Script.Serialization.JavaScriptSerializer js = new System.Web.Script.Serialization.JavaScriptSerializer();
            context.Response.Write(js.Serialize(userInfo));
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