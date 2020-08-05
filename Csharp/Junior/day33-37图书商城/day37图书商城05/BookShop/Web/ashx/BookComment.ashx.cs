using BookShop.Web.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookShop.Web.ashx
{
    /// <summary>
    /// BookComment 的摘要说明
    /// </summary>
    public class BookComment : IHttpHandler
    {
        BLL.BookCommentManager bll = new BLL.BookCommentManager();
        BLL.Articel_WordsManager articelManager = new BLL.Articel_WordsManager();
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            string action = context.Request["action"];
            if (action == "add")
            {
                AddComment(context);//添加评论
            }
            else if (action == "load")//加载评论
            {
                LoadComment(context);
            }
            else
            {
                context.Response.Write("参数错误!!");
            }
        }
        /// <summary>
        /// 加载评论
        /// </summary>
        private void LoadComment(HttpContext context)
        {
            int bookId = Convert.ToInt32(context.Request["bookId"]);
            List<Model.BookComment>list=bll.GetModelList("BookId="+bookId);//获取指定书下面的评论
            List<BookCommentViewModel> newList = new List<BookCommentViewModel>();
            foreach (Model.BookComment bookComment in list)
            {
                ViewModel.BookCommentViewModel viewModel = new BookCommentViewModel();
                viewModel.Msg =Common.WebCommon.UbbToHtml(bookComment.Msg);//将UBB编码转成HTML编码
                TimeSpan ts=DateTime.Now-bookComment.CreateDateTime;
                viewModel.CreateDateTime = Common.WebCommon.GetTimeSpan(ts);//获取评论的时间.
                newList.Add(viewModel);
            }
            System.Web.Script.Serialization.JavaScriptSerializer js = new System.Web.Script.Serialization.JavaScriptSerializer();
            context.Response.Write(js.Serialize(newList));
        }
        /// <summary>
        /// 添加评论
        /// </summary>
        /// <param name="context"></param>
        private void AddComment(HttpContext context)
        {
            
            string msg=context.Request["msg"];//接收用户发布的评论
            //判断是否含有禁用词
            if (articelManager.CheckForbid(msg))
            {
                context.Response.Write("no:评论中含有禁用词");
            }
            else if (articelManager.CheckMod(msg))//表示审查词
            {
                AddMsg(context, msg, 0);

            }
            else//替换词
            {
                AddMsg(context, msg, 1);
            }
        }
        /// <summary>
        /// 添加评论
        /// </summary>
        /// <param name="context"></param>
        /// <param name="msg"></param>
        /// <param name="isPass"></param>

        private void AddMsg(HttpContext context,string msg,int isPass)
        {
            Model.BookComment bookComment = new Model.BookComment();
            bookComment.BookId = Convert.ToInt32(context.Request["bookId"]);
            bookComment.Msg = articelManager.CheckReplace(msg);//替换词
            bookComment.CreateDateTime = DateTime.Now;
            //bookComment.IsPass=isPass
            //bookComment.UserId=userId.

            if (bll.Add(bookComment) > 0)
            {
                if (isPass == 1)
                {
                    context.Response.Write("ok:评论成功");
                }
                else
                {
                    context.Response.Write("ok:评论成功含有审查词"); 
                }
            }
            else
            {
                context.Response.Write("no:评论失败");
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