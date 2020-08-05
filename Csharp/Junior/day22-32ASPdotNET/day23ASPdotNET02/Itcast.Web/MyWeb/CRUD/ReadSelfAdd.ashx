<%@ WebHandler Language="C#" Class="ReadSelfAdd" %>

using System;
using System.Web;
using System.IO;
public class ReadSelfAdd : IHttpHandler {

    //HTTP协议的无状态性。第二次请求无法获取第一次请求的处理结果。（后续请求无法获取之前请求的计算的结果）
   // int num = 0;
    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/html";
        string filePath = context.Request.MapPath("SelfAdd.html");
        string fileContent = File.ReadAllText(filePath);
        int num = Convert.ToInt32(context.Request.Form["txtNum"]);
        num++;
        fileContent = fileContent.Replace("$num",num.ToString());
        context.Response.Write(fileContent);
        
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}