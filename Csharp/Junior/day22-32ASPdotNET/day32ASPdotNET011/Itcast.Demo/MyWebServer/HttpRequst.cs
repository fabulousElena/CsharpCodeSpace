using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebServer
{
   public class HttpRequst
    {
       public HttpRequst(string msg)
       {
         string[] msgs=msg.Split(new char[]{'\r','\n'},StringSplitOptions.RemoveEmptyEntries);//按照请求报文中的回车换行符进行分割。
         FilePath = msgs[0].Split(' ')[1];//从请求报文中获取了用户请求的文件的名称
       }
       public string FilePath { get; set; }
    }
}
