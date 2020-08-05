<%@ WebHandler Language="C#" Class="UserInfoList" %>

using System;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.IO;
public class UserInfoList : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/html";
        string connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
        using (SqlConnection conn = new SqlConnection(connStr))
        {
            using (SqlDataAdapter atper = new SqlDataAdapter("select * from UserInfo", conn))
            {
                DataTable da = new DataTable();
                atper.Fill(da);
                if (da.Rows.Count > 0)
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (DataRow row in da.Rows)
                    {
                        sb.AppendFormat("<tr><td>{0}</td><td>{1}</td><td>{2}</td><td>{3}</td><td>{4}</td><td><a href='ShowDetail.ashx?id={0}'>详细</a></td><td><a href='DeleteUser.ashx?id={0}' class='deletes'>删除</a></td><td ><a href='ShowEdit.ashx?id={0}'>编辑</a></td></tr>", row["ID"].ToString(), row["UserName"].ToString(), row["UserPass"].ToString(), row["Email"].ToString(), row["RegTime"].ToString());
                    }
                    //读取模板文件，替换展位符。
                    string filePath = context.Request.MapPath("UserInfoList.html");
                    string fileContent = File.ReadAllText(filePath);
                    fileContent = fileContent.Replace("@tbody", sb.ToString());
                    context.Response.Write(fileContent);
                }
                else
                {
                    context.Response.Write("暂无数据!!");
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