using CZBK.ItcastOA.Model;
using CZBK.ItcastOA.Model.EnumType;
using CZBK.ItcastOA.Model.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CZBK.ItcastOA.WebApp.Controllers
{
    public class UserInfoController :BaseController //Controller
    {
        //
        // GET: /UserInfo/
        IBLL.IUserInfoService UserInfoService{get;set;}
        public ActionResult Index()
        {
            return View();
        }

        #region 获取用户列表数据
        public ActionResult GetUserInfoList()
        {
            int pageIndex = Request["page"] != null ? int.Parse(Request["page"]) : 1;
            int pageSize = Request["rows"] != null ? int.Parse(Request["rows"]) : 5;
            //接收搜索条件
            string userName = Request["name"];
            string userRemark = Request["remark"];
             int totalCount=0;
            //构建搜索条件.
            UserInfoSearch userInfoSearch = new UserInfoSearch() { 
              UserName=userName,
              UserRemark=userRemark,
              PageIndex=pageIndex,
              PageSize=pageSize,
              TotalCount=totalCount
            };
            short delFlag = (short)DeleteEnumType.Normarl;
            //根据构建好的搜索条件完成搜索
            var userInfoList = UserInfoService.LoadSearchEntities(userInfoSearch, delFlag);
           
           
            //获取分页数据。
            //var userInfoList= UserInfoService.LoadPageEntities<int>(pageIndex, pageSize, out totalCount, c => c.DelFlag == delFlag, c => c.ID,true);

            var temp = from u in userInfoList
                       select new {
                           ID=u.ID,
                       UName=u.UName,
                       UPwd=u.UPwd,
                       Remark=u.Remark,
                       SubTime=u.SubTime
                       };

            return Json(new { rows = temp, total = userInfoSearch.TotalCount }, JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 删除用户数据
        public ActionResult DeleteUserInfo()
        {
            string strId=Request["strId"];
            string[]strIds=strId.Split(',');
            List<int> list = new List<int>();
            foreach (string id in strIds)
            {
                list.Add(Convert.ToInt32(id));
            }
            //将list集合存储的的要删除的记录的编号传递到业务层.
            if (UserInfoService.DeleteEntities(list))
            {
                return Content("ok");
            }
            else
            {
                return Content("no");
            }
        }
        #endregion

        #region 添加用户数据
        public ActionResult AddUserInfo(UserInfo userInfo)
        {
            userInfo.DelFlag = 0;
            userInfo.ModifiedOn = DateTime.Now;
            userInfo.SubTime = DateTime.Now;
            UserInfoService.AddEntity(userInfo);
            return Content("ok");
        }
        #endregion
        #region 展示要修改的数据
        public ActionResult ShowEditInfo()
        {
            int id = int.Parse(Request["id"]);
           var userInfo= UserInfoService.LoadEntities(u=>u.ID==id).FirstOrDefault();
           return Json(userInfo, JsonRequestBehavior.AllowGet);
        }

        #endregion
        #region 完成用户数据的更新
         public ActionResult EditUserInfo(UserInfo userInfo)
        {
        
            userInfo.ModifiedOn = DateTime.Now;
            if (UserInfoService.EditEntity(userInfo))
            {
                return Content("ok");
            }
            else
            {
                return Content("no");
            }
        }
        #endregion
       

    }
}
