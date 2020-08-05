using CZBK.ItcastProject.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Caching;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CZBK.ItcastProject.WebApp._2015_6_6
{
    public partial class SqlCacheDep : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Cache["customerList"] == null)
            {
                SqlCacheDependency cDep =    new SqlCacheDependency("GSSMS", "Customer");
                string sql = "select * from Customer";
                DataTable da = SqlHelper.GetDataTable(sql, CommandType.Text);
                Cache.Insert("customerList", da, cDep);
                Response.Write("数据来自数据库");
            }
            else
            {
                Response.Write("数据来自缓存");
            }

        }
    }
}