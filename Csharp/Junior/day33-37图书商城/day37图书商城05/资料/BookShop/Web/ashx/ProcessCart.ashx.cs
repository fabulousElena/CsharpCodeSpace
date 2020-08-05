using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookShop.Web.ashx
{
    /// <summary>
    /// ProcessCart 的摘要说明
    /// </summary>
    public class ProcessCart : IHttpHandler,System.Web.SessionState.IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            BLL.UserManager userManager = new BLL.UserManager();
            if (userManager.ValidateUserLogin())//判断是否登录
            {
                int bookId = Convert.ToInt32(context.Request["bookId"]);
                //判断数据库中是否有该商品.
                BLL.BookManager bookManager = new BLL.BookManager();
                Model.Book bookModel=bookManager.GetModel(bookId);
                if (bookModel != null)
                {
                    int userId=((Model.User)context.Session["userInfo"]).Id;//获取登录用户登录的ID。
                    BLL.CartManager cartManager = new BLL.CartManager();
                    Model.Cart cartModel=cartManager.GetModel(userId,bookId);
                    //如果购物车有该商品，更新数量加1，没有插入
                    if (cartModel != null)
                    {
                        cartModel.Count = cartModel.Count + 1;
                        cartManager.Update(cartModel);
                    }
                    else
                    {
                        Model.Cart modelCart = new Model.Cart();
                        modelCart.Count = 1;
                        modelCart.Book = bookModel;
                        modelCart.User = ((Model.User)context.Session["userInfo"]);
                        cartManager.Add(modelCart);
                    }
                    context.Response.Write("ok:商品成功添加到购物车");
                }
                else
                {
                    context.Response.Write("no:无此商品");
                }
                
            }
            else
            {
                context.Response.Write("login:没有登录");
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