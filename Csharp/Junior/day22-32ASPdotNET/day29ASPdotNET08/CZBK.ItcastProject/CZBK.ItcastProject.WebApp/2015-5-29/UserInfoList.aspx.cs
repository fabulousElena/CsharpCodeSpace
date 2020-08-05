using CZBK.ItcastProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CZBK.ItcastProject.WebApp._2015_5_29
{
    public partial class UserInfoList : System.Web.UI.Page
    {
        public string StrHtml { get; set; }
        public List<UserInfo> UserList { get; set; }
        /// <summary>
        /// 页面加载完成以后。Load事件  Form_Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            BLL.UserInfoService UserInfoService = new BLL.UserInfoService();
            List<UserInfo>list=UserInfoService.GetList();
            UserList = list;
           
            //StringBuilder sb = new StringBuilder();
            //foreach (UserInfo userInfo in list)
            //{
            //    sb.AppendFormat("<tr><td>{0}</td><td>{1}</td><td>{2}</td><td>{3}</td><td>{4}</td></tr>",userInfo.Id,userInfo.UserName,userInfo.UserPass,userInfo.Email,userInfo.RegTime.ToShortDateString());
            //}
            //StrHtml = sb.ToString();
        }
    }
}