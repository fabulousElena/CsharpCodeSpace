using CZBK.ItcastProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CZBK.ItcastProject.WebApp._2015_6_6
{
    public partial class ShOWDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request["id"]);
            BLL.UserInfoService UserInfoService = new BLL.UserInfoService();
            UserInfo userInfo=UserInfoService.GetUserInfo(id);
            List<UserInfo> list = new List<UserInfo>();
            list.Add(userInfo);
            this.DetailsView1.DataSource = list;
            this.DetailsView1.DataBind();
        }
    }
}