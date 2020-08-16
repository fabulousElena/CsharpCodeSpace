using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            UserInfo userInfo = new UserInfo();
            userInfo.Email = "sss@256.com";
            userInfo.RegTime = DateTime.Now;
            userInfo.UserName = "sss56";
            userInfo.UserPass="123456";
            EFFristModelEntities db = new EFFristModelEntities();
            db.UserInfo.Add(userInfo);//将数据添加到EF并且添加了添加标记。
            db.SaveChanges();//数据才会保存到数据库。,返回受影响的行数。
            Response.Write(userInfo.ID);
        }
        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button2_Click(object sender, EventArgs e)
        {
            EFFristModelEntities db = new EFFristModelEntities();
            //linq
            var  userInfoList = from u in db.UserInfo
                               where u.ID ==343
                               select u;
            int i = 0;

            foreach (UserInfo userInfo in userInfoList)//EF 延迟加载机制，数据用到的时候才去数据库中查询。不能用的时候不查询。
            {
                Response.Write(userInfo.UserName);
            }
            

            // select * from UserInfo where ID=343
            // from UserInfo
            // where ID=343
            // select *
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            EFFristModelEntities db = new EFFristModelEntities();
            //var userInfoList = from u in db.UserInfo
            //                   where u.ID == 345
            //                   select u;
            //UserInfo userInfo=userInfoList.FirstOrDefault();//返回第一个元素，如果没有的话，返回null
            //if (userInfo != null)
            //{
            //   // db.UserInfo.Remove(userInfo);
            //    db.Entry<UserInfo>(userInfo).State = System.Data.EntityState.Deleted;

            //    db.SaveChanges();
            //}
            //else
            //{
            //    Response.Write("要删除的数据不存在!!");
            //}

            UserInfo userInfo = new UserInfo() {ID=344};
            //db.UserInfo.Remove(userInfo);
            db.Entry<UserInfo>(userInfo).State = System.Data.EntityState.Deleted;
            db.SaveChanges();

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            EFFristModelEntities db = new EFFristModelEntities();
            var userInfoList = from u in db.UserInfo
                               where u.ID == 343
                               select u;
            var userInfo = userInfoList.FirstOrDefault();
            userInfo.UserPass = "666666";
            db.Entry<UserInfo>(userInfo).State = System.Data.EntityState.Modified;
            db.SaveChanges();
        }
    }
}