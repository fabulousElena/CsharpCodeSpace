using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.BLL

{
  public partial  class UserManager
    {

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(BookShop.Model.User model,out string msg)
        {
            int isSuccess = -1;
            if (ValidateUserName(model.LoginId))
            {
                msg = "此用户名已经注册!!";
            }
            else
            {
               isSuccess= dal.Add(model);
               msg = "注册成功!!";
              
            }
            return isSuccess;

        }
      /// <summary>
      /// 完成用户名检查
      /// </summary>
      /// <param name="userName"></param>
      /// <returns></returns>
        public bool ValidateUserName(string userName)
        {
           return dal.GetModel(userName) != null ? true : false;
        }

      /// <summary>
      /// 根据邮箱找信息
      /// </summary>
      /// <param name="mail"></param>
      /// <returns></returns>
        public bool CheckUserMail(string mail)
        {
            return dal.CheckUserMail(mail) > 0 ? true : false;
        }

    }
}
 