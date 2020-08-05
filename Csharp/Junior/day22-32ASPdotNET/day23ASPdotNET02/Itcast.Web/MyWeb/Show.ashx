<%@ WebHandler Language="C#" Class="Show" %>

using System;
using System.Web;
using System.IO;
public class Show : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/html";
        //获取要操作的模板的路径.
        string filePath = context.Request.MapPath("ShowInfo.html");//获取文件的物理路径。在Asp.net中，对文件或文件夹进行操作一定要获取物理路径。
        //读取模板文件中的内容。
       string fileContent=File.ReadAllText(filePath);
        //用户具体的数据替换模板文件中的展位符。
       fileContent = fileContent.Replace("$name","itcast").Replace("$pwd","123");
        //将替换后的内容输出给浏览器。
       context.Response.Write(fileContent);
       context.Response.Write("<b>adfsdf</b>");
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}