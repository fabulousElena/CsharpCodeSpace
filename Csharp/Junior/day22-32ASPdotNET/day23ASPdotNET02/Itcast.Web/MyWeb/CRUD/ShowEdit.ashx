<%@ WebHandler Language="C#" Class="ShowEdit" %>

using System;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
public class ShowEdit : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/html";
        int id;
        if (int.TryParse(context.Request.QueryString["id"], out id))
        {
              string connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
            //根据接收到ID查询数据表中相应的记录.
              using (SqlConnection conn = new SqlConnection(connStr))
              {
                  using (SqlDataAdapter apter = new SqlDataAdapter("select * from UserInfo where ID=@ID", conn))
                  {
                      SqlParameter par = new SqlParameter("@ID", SqlDbType.Int);
                      par.Value = id;
                      apter.SelectCommand.Parameters.Add(par);
                      DataTable da = new DataTable();
                      apter.Fill(da);
                      if (da.Rows.Count > 0)
                      {
                          //读取模板文件，替换占位符.
                          string filePath = context.Request.MapPath("ShowEditUser.html");
                          string fileContent = File.ReadAllText(filePath);
                          fileContent = fileContent.Replace("$name", da.Rows[0]["UserName"].ToString()).Replace("$pwd", da.Rows[0]["UserPass"].ToString()).Replace("$mail", da.Rows[0]["Email"].ToString()).Replace("$Id",da.Rows[0]["ID"].ToString());
                          context.Response.Write(fileContent);
                          
                      }
                      else
                      {
                          context.Response.Write("查无此人!!");
                      }
                  }
              }
        }
        else
        {
            context.Response.Write("参数错误!!");
        }
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}