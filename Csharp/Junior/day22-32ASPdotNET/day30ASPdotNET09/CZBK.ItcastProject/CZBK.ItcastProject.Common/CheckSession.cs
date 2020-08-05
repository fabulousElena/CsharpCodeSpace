using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZBK.ItcastProject.Common
{
   public class CheckSession:System.Web.UI.Page
    {
       //Init事件：aspx初始化时触发.
       public void Page_Init(object sender, EventArgs e)
       {
           if (Session["userInfo"] == null)
           {
               Response.Redirect("UserLogin.aspx");
           }
       }

    }
}
