using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Hosting;

namespace Common
{
   public class WebCommon
    {
       /// <summary>
       /// 线程内唯一对象  CallContext
       /// </summary>
       public static void GetFilePath(object obj)
       {
          

           HttpContext context = (HttpContext)obj;
           string filePath = context.Request.MapPath("/Images/body.jpg");

          // string filePath = HostingEnvironment.MapPath("/Images/body.jpg");
           //string filePath=
          // return "";
       }
       /// <summary>
       /// 完成验证码校验
       /// </summary>
       /// <returns></returns>
       public static bool CheckValidateCode(string validateCode)
       {
           bool isSucess = false;
           if (HttpContext.Current.Session["vCode"] != null)
           {
              // string txtCode = HttpContext.Current.Request["txtCode"];
               string sysCode =HttpContext.Current.Session["vCode"].ToString();
               if (sysCode.Equals(validateCode, StringComparison.InvariantCultureIgnoreCase))
               {
                   isSucess = true;
                   HttpContext.Current.Session["vCode"] = null;
               }

           }
           return isSucess;
       }
       /// <summary>
       /// 跳转页面
       /// </summary>
       public static void RedirectPage()
       {
           HttpContext.Current.Response.Redirect("/Member/Login.aspx?returnUrl="+HttpContext.Current.Request.Url.ToString());//获取所请求的当前页面的URL地址。
       }
       /// <summary>
       /// 对字符串进行MD5运算
       /// </summary>
       /// <param name="str"></param>
       /// <returns></returns>
       public static string GetMd5String(string str)
       {
           MD5 md5 = MD5.Create();
           byte[] buffer = System.Text.Encoding.UTF8.GetBytes(str);
           byte[]md5Buffer=md5.ComputeHash(buffer);
           StringBuilder sb = new StringBuilder();
           foreach (byte b in md5Buffer)
           {
               sb.Append(b.ToString("x2"));
           }
           return sb.ToString();
       }


    }
}
