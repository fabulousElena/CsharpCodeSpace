<%@ WebHandler Language="C#" Class="ShowDetail" %>

using System;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;
public class ShowDetail : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/html";
        int id;
        //TryParse尝试将第一个参数转成整型，如果能够转换那么该方法返回true,并且将转换成功的整型数字赋值给第二个参数。否则转换不成功那么该方法返回false;
        if (int.TryParse(context.Request.QueryString["id"], out id))
        {
            string connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
            //根据接收到ID查询数据表中相应的记录.
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlDataAdapter apter = new SqlDataAdapter("select * from UserInfo where ID=@ID", conn))
                {
                    SqlParameter par = new SqlParameter("@ID",SqlDbType.Int);
                    par.Value = id;
                    apter.SelectCommand.Parameters.Add(par);
                    DataTable da = new DataTable();
                    apter.Fill(da);
                    if (da.Rows.Count > 0)
                    {
                        string filePath = context.Request.MapPath("ShowDetailUser.html");
                       string fileContent=File.ReadAllText(filePath);
                       fileContent = fileContent.Replace("$name", da.Rows[0]["UserName"].ToString()).Replace("$pwd",da.Rows[0]["UserPass"].ToString());
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
            context.Response.Write("参数异常!!");
        }
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}