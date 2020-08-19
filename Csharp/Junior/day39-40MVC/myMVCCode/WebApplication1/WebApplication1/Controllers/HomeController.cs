using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Register()
        {
            ViewBag.Message = "这是注册页.";
            return View();
        }
        [HttpPost]//只能接收post，优先处理post请求
        public ActionResult Register(usersinfo ui)
        {
            ui.udatetime = DateTime.Now.ToString();
            ztest01Entities db = new ztest01Entities();
            db.usersinfo.Add(ui);
            if (db.SaveChanges() > 0)
            {
                return Content("成功");
            }
            else
            {
                return Content("失败");
            }
            //return View();
        }

        //如果表单元素的name属性的值和实体类中的属性的名字保持一致，
        //那么表单中的数据会自动赋值给实体中的属性
        //public ActionResult Regist()
        //{
        //[HttpPost]//优先处理post请求
        public ActionResult Regist(usersinfo ui){
            //usersinfo ui = new usersinfo();
            //ui.uaccount = Request["username"];
            //ui.upassword = Request["userpass"];
            //ui.uemail = Request["useremail"];
            //ui.uphone = Request["userphone"];
            ui.udatetime = DateTime.Now.ToString();
            ztest01Entities db = new ztest01Entities();
            db.usersinfo.Add(ui);
            if (db.SaveChanges() > 0)
            {
                return Content("成功");
            }else
            {
                return Content("失败");
            }
        }

    }
}