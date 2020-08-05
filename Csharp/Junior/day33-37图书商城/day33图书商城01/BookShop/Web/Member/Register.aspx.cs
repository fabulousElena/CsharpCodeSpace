using BookShop.Web.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BookShop.Web.Member
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                if (Common.WebCommon.CheckValidateCode(Request["txtCode"]))//完成验证码校验
                {
                    AddUserInfo();
                }
            }
        }
        #region 完成用户注册
        protected void AddUserInfo()
        {
            Model.User userInfo = new Model.User();
            userInfo.Address = Request["txtAddress"];
            userInfo.LoginId=Request["txtName"];
            userInfo.LoginPwd=Request["txtPwd"];
            userInfo.Mail = Request["txtEmail"];
            userInfo.Name = Request["txtRealName"];
            userInfo.Phone=Request["txtPhone"];
              
         
            userInfo.UserState.Id =Convert.ToInt32(UserStateEnum.NormalState);
            BLL.UserManager userManager = new BLL.UserManager();
            string msg=string.Empty;
            if (userManager.Add(userInfo, out msg) > 0)
            {
                Session["userInfo"] = userInfo;
                Response.Redirect("/Default.aspx");
            }
            else
            {
                Response.Redirect("/ShowMsg.aspx?msg="+msg+"&txt=首页"+"&url=/Default.aspx");
            }

        }
        #endregion

        #region 验证码校验
        //protected bool CheckSession()
        //{
        //    //bool isSucess = false;
        //    //if (Session["vCode"] != null)
        //    //{
        //    //    string txtCode = Request["txtCode"];
        //    //    string sysCode = Session["vCode"].ToString();
        //    //    if (sysCode.Equals(txtCode, StringComparison.InvariantCultureIgnoreCase))
        //    //    {
        //    //        isSucess = true;
        //    //        Session["vCode"] = null;
        //    //    }

        //    //}
        //    //return isSucess;
         
        //}
        #endregion
       
    }
}