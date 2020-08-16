using CZBK.ItcastOA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CZBK.ItcastOA.WebApp.Controllers
{
    public class UserInfoController : Controller
    {
        //
        // GET: /UserInfo/
        IBLL.IUserInfoService bll = new BLL.UserInfoService();
        public ActionResult Index()
        {
            ViewData.Model = bll.LoadEntities(c=>true);
            return View();
        }

    }
}
