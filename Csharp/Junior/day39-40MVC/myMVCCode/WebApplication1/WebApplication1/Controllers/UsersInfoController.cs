using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class UsersInfoController : Controller
    {

        // GET: UsersInfo
        public ActionResult UsersInfoView(int id)
        {
            ztest01Entities db = new ztest01Entities();
            //传递过来的页码
            int pageIndex = id;
            //var thisNum = Request["name"];
            //if (int.TryParse(Request["name"], out pageIndex))
            //{
            //    pageIndex = 1;
            //}
            //计算总的数据行数
            int dataCount = db.usersinfo.Where(u => true).Count();
            int eachPage = 20;
            //计算总的页数 每页20
            int pageCount =
            Convert.ToInt32(Math.Ceiling((double)dataCount / eachPage));

            pageIndex = pageIndex < 1 ? 1 : pageIndex;
            pageIndex = pageIndex > pageCount ? pageCount : pageIndex;


            var usersInfoList = db.usersinfo.Where<usersinfo>(u => true).OrderByDescending<usersinfo,int>(u=>u.uid).Skip<usersinfo>((pageIndex-1)*eachPage).Take<usersinfo>(eachPage);
               
            StringBuilder sb = new StringBuilder();
            foreach (var usersinfo in usersInfoList)
            {
                sb.AppendFormat("<tr><td>{0}</td><td>{1}</td><td>{2}</td><td>{3}</td><td>{4}</td><td><a href='/UsersInfo/ShowDetail/{0}'>详情</a>&nbsp;<a href='/UsersInfo/UpdateUser/{0}'>修改</a>&nbsp;<a href='/UsersInfo/DeleteUser/{0}'>删除</a></td></tr>", usersinfo.uid, usersinfo.uaccount, usersinfo.uemail, usersinfo.uphone, usersinfo.udatetime);
            }
            //ViewData["usersinfoList"] = sb.ToString();
            ViewData["pageIndex"] = pageIndex;
            ViewData["usersinfo"] = sb.ToString();
            

            return View();
        }
        /// <summary>
        /// 获得id并且展示详情
        /// </summary>
        /// <param name="id">参数必须和路由设置的id一致，路由叫id这里也是id</param>
        /// <returns></returns>
        public ActionResult ShowDetail(int id)
        {
            ztest01Entities db = new ztest01Entities();
            var ui = db.usersinfo.Where<usersinfo>(u => u.uid == id).FirstOrDefault();
            StringBuilder sb = new StringBuilder();
            sb.Append("<table border='1' >");
            sb.Append("<tr><th>编号</th><th>账号</th><th>邮箱</th><th>手机号</th><th>时间</th></tr>");
            sb.AppendFormat("<tr><td>{0}</td><td>{1}</td><td>{2}</td><td>{3}</td><td>{4}</td></tr>", ui.uid, ui.uaccount, ui.uemail, ui.uphone, ui.udatetime);
            sb.Append("</table>");
            ViewData["thisUser"] = sb.ToString();
            return Content(ViewData["thisUser"].ToString());
        }

        public ActionResult DeleteUser(int id)
        {
            ztest01Entities db = new ztest01Entities();
            var ui = db.usersinfo.Where<usersinfo>(u => u.uid == id).FirstOrDefault();
            db.usersinfo.Remove(ui);

            if (db.SaveChanges() > 0)
            {
                return RedirectToAction("UsersInfoView", "UsersInfo",new {id=1});


            }
            else
            {
                return Content("Error");
            }


        }

        public ActionResult UpdateUser(int id)
        {
            ztest01Entities db = new ztest01Entities();
            var ui = db.usersinfo.Where<usersinfo>(u => u.uid == id).FirstOrDefault();
            ViewData["uid"] = id;
            ViewData["uaccount"] = ui.uaccount;
            ViewData["upassword"] = ui.upassword;
            ViewData["uemail"] = ui.uemail;
            ViewData["uphone"] = ui.uphone;
            //return Content("UpdateUser");
            return View();
        }

        public ActionResult ExecuteUpdate(usersinfo ui)
        {
            ztest01Entities db = new ztest01Entities();
            var thisUi = db.usersinfo.Where(u => u.uid == ui.uid).FirstOrDefault();

            thisUi.uaccount = ui.uaccount;
            thisUi.upassword = ui.upassword;
            thisUi.uemail = ui.uemail;
            thisUi.uphone = ui.uphone;
            thisUi.udatetime = DateTime.Now.ToString();
            db.usersinfo.Attach(thisUi);

            db.Entry(thisUi).State = EntityState.Modified;
            if (db.SaveChanges() > 0)
            {
                return Content("修改成功");

            }
            else
            {
                return Content("失败");
            }



        }

    }
}