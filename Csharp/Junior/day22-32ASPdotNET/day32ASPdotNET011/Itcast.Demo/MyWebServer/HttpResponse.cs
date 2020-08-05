using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebServer
{
   public class HttpResponse
    {
       byte[] buffer = null;
       public HttpResponse(byte[] buffer,string filePath)
       {
           this.buffer = buffer;
           string fileExt = Path.GetExtension(filePath);
           switch (fileExt)
           {
               case ".html":
               case ".htm":
                   Content_Type = "text/html";
                   break;
             
           }
       }
       public byte[] GetHeaderResponse()
       {
           StringBuilder builder = new StringBuilder();
           builder.Append("HTTP/1.1 200 ok\r\n");
           builder.Append("Content-Type:" + Content_Type + ";charset=utf-8\r\n");
           builder.Append("Content-Length:" + buffer.Length + "\r\n\r\n");//在相应报文头的最后一行下面有一个空行，所以在这里加两组"\r\n"
           return System.Text.Encoding.UTF8.GetBytes(builder.ToString());
         
       }
       public string Content_Type { get; set; }
    }
}
