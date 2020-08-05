using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
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
      /// <summary>
      /// 完成用户登录信息的校验
      /// </summary>
      /// <param name="userName"></param>
      /// <param name="userPwd"></param>
      /// <param name="msg"></param>
      /// <param name="user"></param>
      /// <returns></returns>
        public bool CheckUserInfo(string userName, string userPwd, out string msg, out Model.User user)
        {
            user = dal.GetModel(userName);
            if (user != null)
            {
                if (user.LoginPwd == userPwd)
                {
                    msg = "登录成功";
                    return true;
                }
                else
                {
                    msg = "用户名或密码错误!!";
                    return false;
                }
            }
            else
            {
                msg = "此用户不存在!!";
                return false;
            }
        }
      /// <summary>
      /// 根据用户名找用户信息
      /// </summary>
      /// <param name="userName"></param>
      /// <returns></returns>
        public Model.User GetModel(string userName)
        {
            return dal.GetModel(userName);
        }
      /// <summary>
      /// 找回用户的密码
      /// </summary>
      /// <param name="userInfo"></param>
        public void FindUserPwd(Model.User userInfo)
        {
            BLL.SettingsManager bll = new SettingsManager();
            //系统产生一个新的密码，然后更新数据库，再将新的密码发送到用户的邮箱中。
            string newPwd = Guid.NewGuid().ToString().Substring(0,8);
            userInfo.LoginPwd = newPwd;//一定要将系统产生的新密码加密以后更新到数据库中，但是发送到用户邮箱中的密码必须是明文的。
            dal.Update(userInfo);
            MailMessage mailMsg = new MailMessage();//两个类，别混了，要引入System.Net这个Assembly
            mailMsg.From = new MailAddress(bll.GetValue("系统邮件地址"));//源邮件地址 
            mailMsg.To.Add(new MailAddress(userInfo.Mail));//目的邮件地址。可以有多个收件人
            mailMsg.Subject = "在商城网站中的新的账户";//发送邮件的标题 
            StringBuilder sb = new StringBuilder();
            sb.Append("用户名是:"+userInfo.LoginId);
            sb.Append("新密码是:"+newPwd);
            mailMsg.Body =sb.ToString();//发送邮件的内容 
            //mailMsg.IsBodyHtml = true;
            SmtpClient client = new SmtpClient(bll.GetValue("系统邮件SMTP"));//smtp.163.com，smtp.qq.com
            client.Credentials = new NetworkCredential(bll.GetValue("系统邮件用户名"), bll.GetValue("系统邮件密码"));
            client.Send(mailMsg);//注意：发送大量邮件时阻塞，所以可以将要发送的邮件先发送到队列中。



        }


    }
}
 