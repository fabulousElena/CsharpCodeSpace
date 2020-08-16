using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text;
using LTP.Common;
namespace BookShop.Web.RoomType
{
    public partial class Add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Master.TabTitle="信息添加，请详细填写下列信息";            
        }

        		protected void btnAdd_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtTypeName.Text =="")
			{
				strErr+="TypeName不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtPrice.Text))
			{
				strErr+="Price不是数字！\\n";	
			}
			if(!PageValidate.IsNumber(txtAddBed.Text))
			{
				strErr+="AddBed不是数字！\\n";	
			}
			if(!PageValidate.IsDecimal(txtBedPrice.Text))
			{
				strErr+="BedPrice不是数字！\\n";	
			}
			if(this.txtRemark.Text =="")
			{
				strErr+="Remark不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string TypeName=this.txtTypeName.Text;
			decimal Price=decimal.Parse(this.txtPrice.Text);
			int AddBed=int.Parse(this.txtAddBed.Text);
			decimal BedPrice=decimal.Parse(this.txtBedPrice.Text);
			string Remark=this.txtRemark.Text;

			BookShop.Model.RoomType model=new BookShop.Model.RoomType();
			model.TypeName=TypeName;
			model.Price=Price;
			model.AddBed=AddBed;
			model.BedPrice=BedPrice;
			model.Remark=Remark;

			BookShop.BLL.RoomTypeService bll=new BookShop.BLL.RoomTypeService();
			bll.Add(model);

		}

    }
}
