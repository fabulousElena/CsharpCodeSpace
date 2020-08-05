<%@ WebHandler Language="C#" Class="AddInfo" %>

using System;
using System.Web;

public class AddInfo : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";
        ///string userName=context.Request.QueryString["txtName"];//接收的是表单元素name属性的值
       // string userPwd=context.Request.QueryString["txtPwd"];

        string userName = context.Request.Form["txtName"];
        string userPwd = context.Request.Form["txtPwd"];
        
        context.Response.Write("用户名是:"+userName+",密码是:"+userPwd);
        
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}