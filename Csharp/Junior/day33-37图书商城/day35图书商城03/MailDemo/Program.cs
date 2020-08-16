using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailKit;
using MimeKit;
using MailKit.Net.Smtp;


namespace MailDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //MailMessage mailMsg = new MailMessage();//两个类，别混了，要引入System.Net这个Assembly
            //mailMsg.From = new MailAddress("fabulouselena@163.com", "阿伟");//源邮件地址 
            //mailMsg.To.Add(new MailAddress("2636485450@qq.com", "2636485450"));//目的邮件地址。可以有多个收件人
            //mailMsg.Subject = "花纸de小窝";//发送邮件的标题 
            //mailMsg.Body = "你想更改密码？？没门";//发送邮件的内容 
            //mailMsg.BodyEncoding = Encoding.UTF8;
            //mailMsg.Priority = MailPriority.High;
            //SmtpClient client = new SmtpClient("smtp.163.com");//smtp.163.com，smtp.qq.com
            //client.Credentials = new NetworkCredential("fabulouselena@163.com", "VKGHGACJBXFMURWZ");
            //client.Send(mailMsg);

            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("test", "xxx@qq.com"));
            message.To.Add(new MailboxAddress("test", "xxx@163.com"));
            message.Subject = "邮件测试";
            //html or plain
            var bodyBuilder = new BodyBuilder();
            bodyBuilder.HtmlBody = "<b>邮件测试html正文ken.io</b>";
            bodyBuilder.TextBody = "邮件测试文本正文ken.io";
            message.Body = bodyBuilder.ToMessageBody();

            using (var client = new SmtpClient())
            {
                client.ServerCertificateValidationCallback = (s, c, h, e) => true;
                //smtp服务器，端口，是否开启ssl
                client.Connect("smtp.qq.com", 465, true);
                client.Authenticate("xxx@qq.com", "password");
                client.Send(message);
                client.Disconnect(true);
            }


        }
    }
}
