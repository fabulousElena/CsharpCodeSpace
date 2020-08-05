using CZBK.ItcastProject.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace CZBK.ItcastProject.WebApp._2015_6_5
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BLL.UserInfoService UserInfoService = new BLL.UserInfoService();
            List<UserInfo> list = UserInfoService.GetList();
            this.DropDownList1.DataSource = list;
            this.DropDownList1.DataTextField = "UserName";
            this.DropDownList1.DataValueField = "Id";
            this.DropDownList1.DataBind();

            //StringBuilder sb=new StringBuilder();
            //foreach(UserInfo userInfo in list)
            //{
            //    sb.Append("<option >"+userInfo.UserName+"</option>");
            //}

            Button1.Attributes.Add("onclick", "alert('ssss')");
          
        } 
        
        
        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
          
            Response.Write("文本框发生了改变。");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (this.FileUpload1.HasFile)
            {
                string fileName = Path.GetFileName(this.FileUpload1.FileName);
                string fileExt = Path.GetExtension(fileName);
                if (fileExt == ".jpg")
                {
                    this.FileUpload1.SaveAs(Request.MapPath("/ImageUpload/"+fileName));
                }
            }
        }
    }
}