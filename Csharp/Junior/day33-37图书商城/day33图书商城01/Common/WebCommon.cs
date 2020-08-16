using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

    }
}
