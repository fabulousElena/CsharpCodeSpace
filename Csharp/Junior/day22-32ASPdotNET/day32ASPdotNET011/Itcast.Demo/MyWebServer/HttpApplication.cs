using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace MyWebServer
{
    /// <summary>
    /// 完成客户端发送过来的数据的处理。
    /// </summary>
   public class HttpApplication
    {
       Socket newSocket = null;
       DGShowMsg dgShowMsg = null;
       public HttpApplication(Socket newSocket,DGShowMsg dgShowMsg)
       {
           this.newSocket = newSocket;
           this.dgShowMsg = dgShowMsg;
           //接收客户端发送过来的数据.
           byte[]buffer=new byte[1024*1024*2];
           int receiveLength;

           receiveLength=newSocket.Receive(buffer);//接收客户端发送过来的数据，返回的是实际接收的数据的长度。
           if (receiveLength > 0)
           {
               string msg = System.Text.Encoding.UTF8.GetString(buffer, 0, receiveLength);
               HttpRequst request = new HttpRequst(msg);
               ProcessReuest(request);
               dgShowMsg(msg);
           }

           
       }

       public void ProcessReuest(HttpRequst request)
       {
           string filePath = request.FilePath;
           string dataDir = AppDomain.CurrentDomain.BaseDirectory;//获得当前服务器程序的运行目录
           if (dataDir.EndsWith(@"\bin\Debug\") || dataDir.EndsWith(@"\bin\Release\"))
           {
               dataDir = System.IO.Directory.GetParent(dataDir).Parent.Parent.FullName;
           }
           string fullDir = dataDir + filePath;//获取文件完整路径。
           using (FileStream fileStream = new FileStream(fullDir, FileMode.Open, FileAccess.Read))
           {
               byte[] buffer = new byte[fileStream.Length];
               fileStream.Read(buffer, 0, buffer.Length);
               //构建响应报文。
               HttpResponse response = new HttpResponse(buffer, filePath);
               newSocket.Send(response.GetHeaderResponse());//返回响应头.
               newSocket.Send(buffer);
           }
       }
    }
}
