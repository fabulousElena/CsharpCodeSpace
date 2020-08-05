using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Caching;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CZBK.ItcastProject.WebApp._2015_6_6
{
    public partial class FileCacheDep : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string filePath = Request.MapPath("File.txt");
            if (Cache["fileContent"] == null)
            {
                //文件缓存依赖.
                CacheDependency cDep = new CacheDependency(filePath);
                string fileContent = File.ReadAllText(filePath);
                Cache.Insert("fileContent", fileContent, cDep);
                Response.Write("数据来自文件");
            }
            else
            {
                Response.Write("数据来自缓存:"+Cache["fileContent"].ToString());
            }
        }
    }
}