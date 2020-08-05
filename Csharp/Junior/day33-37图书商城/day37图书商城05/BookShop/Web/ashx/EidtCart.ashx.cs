using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookShop.Web.ashx
{
    /// <summary>
    /// EidtCart 的摘要说明
    /// </summary>
    public class EidtCart : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            string action = context.Request["action"];
            if (action == "edit")
            {
                int count = Convert.ToInt32(context.Request["count"]);
                int cartId = Convert.ToInt32(context.Request["cartId"]);
                BLL.CartManager cartManager = new BLL.CartManager();
                Model.Cart cartModel = cartManager.GetModel(cartId);
                cartModel.Count = count;
                cartManager.Update(cartModel);
                context.Response.Write("ok");
            }
            else if (action == "delete")
            {
                int cartId = Convert.ToInt32(context.Request["cartId"]);
                BLL.CartManager cartManager = new BLL.CartManager();
                cartManager.Delete(cartId);
                context.Response.Write("ok");
            }
            else
            {
                context.Response.Write("no");
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}