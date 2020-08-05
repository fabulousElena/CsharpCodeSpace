<%@ WebHandler Language="C#" Class="EidtUser" %>

using System;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
public class EidtUser : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";
        string userName=context.Request.Form["txtName"];
        string userPwd = context.Request.Form["txtPwd"];
        string userMail=context.Request.Form["txtMail"];
        int id = Convert.ToInt32(context.Request.Form["txtId"]);//接收隐藏域的值。
          string connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
          using (SqlConnection conn = new SqlConnection(connStr))
          {
              using (SqlCommand cmd = new SqlCommand())
              {
                  cmd.Connection = conn;
                  cmd.CommandText = "update UserInfo set UserName=@UserName,UserPass=@UserPass,Email=@Email where ID=@ID";
                  SqlParameter[] pars = { 
                                      new SqlParameter("@UserName",SqlDbType.NVarChar,32),
                                       new SqlParameter("@UserPass",SqlDbType.NVarChar,32),
                                        new SqlParameter("@Email",SqlDbType.NVarChar,32),
                                         new SqlParameter("@ID",SqlDbType.Int)
                                      };
                  pars[0].Value = userName;
                  pars[1].Value = userPwd;
                  pars[2].Value = userMail;
                  pars[3].Value = id;
                  cmd.Parameters.AddRange(pars);
                  conn.Open();
                  if (cmd.ExecuteNonQuery() > 0)
                  {
                      context.Response.Redirect("UserInfoList.ashx");
                  }
                  else
                  {
                      context.Response.Redirect("Error.html");
                  }
                  
              }
          }
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}