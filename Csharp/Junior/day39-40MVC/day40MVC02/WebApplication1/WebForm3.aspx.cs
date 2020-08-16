using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            EFFristModelEntities db = null;
            if (HttpContext.Current.Items["db"] == null)
            {
                db = new EFFristModelEntities();
                HttpContext.Current.Items["db"] = db;
            }
            else
            {
                db = HttpContext.Current.Items["db"] as EFFristModelEntities;
            }

           var userInfoList = from u in db.UserInfo
                               where u.ID == 343
                               select  new{UName=u.UserName,UPwd=u.UserPass};
            foreach (var userInfo in userInfoList)
            {
                Response.Write(userInfo.UName+":"+userInfo.UPwd);
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
          //  Func<UserInfo, bool> whereLambda = u => { return u.ID == 343; };
          
            EFFristModelEntities db = new EFFristModelEntities();
        // var userInfoList = db.UserInfo.Where<UserInfo>(u=>u.ID==3);
           
            //select * from UserInfo where id=343
            //升序排序
          // var userInfoList = db.UserInfo.Where<UserInfo>(U => true).OrderBy<UserInfo, int>(u => u.ID);
            //降序排序
         //var userInfoList = db.UserInfo.Where<UserInfo>(U => true).OrderByDescending(u => u.ID);

            int pageIndex = 2;
            int pageSize = 2;
            var userInfoList = (from u in db.UserInfo
                                where u.ID > 0
                                orderby u.RegTime ascending, u.ID descending
                                select u).Skip<UserInfo>((pageIndex - 1) * pageSize).Take<UserInfo>(pageSize);
         
      //   var userInfoList = db.UserInfo.Where<UserInfo>(U => true).OrderByDescending(u => u.UserPass).ThenByDescending<UserInfo, int>(u => u.ID);//Skip:表示跳过多少条记录, Take取多少条记录

      
            foreach (var userInfo in userInfoList)
            {
             
                    Response.Write(userInfo.UserName + "<br/>");
              
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string str ="ttttt";
          Response.Write (str.MyStr());
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            EFFristModelEntities db = new EFFristModelEntities();
          
            var userInfoList = db.UserInfo.Where<UserInfo>(u => u.ID >0);
        
            int i = 0;
            int count = userInfoList.Count();
            Response.Write(count);

        }
    }
}