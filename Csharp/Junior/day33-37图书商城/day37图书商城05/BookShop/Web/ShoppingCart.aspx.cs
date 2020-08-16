using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BookShop.Web
{
    public partial class ShoppingCart : System.Web.UI.Page
    {
        public List<Model.Cart> CartList { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BLL.UserManager userManager = new BLL.UserManager();
                if (userManager.ValidateUserLogin())
                {
                    BindCartList();
                }
                else
                {
                    Common.WebCommon.RedirectPage();
                }
            }
        }
        protected void BindCartList()
        {
            BLL.CartManager cartManager = new BLL.CartManager();
            CartList = cartManager.GetModelList("UserId=" + ((Model.User)Session["userInfo"]).Id);
        }
    }
}