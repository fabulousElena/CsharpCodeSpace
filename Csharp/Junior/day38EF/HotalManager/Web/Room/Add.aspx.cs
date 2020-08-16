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
namespace BookShop.Web.Room
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
			if(!PageValidate.IsNumber(txtRoomNum.Text))
			{
				strErr+="RoomNum不是数字！\\n";	
			}
			if(!PageValidate.IsNumber(txtRoomType.Text))
			{
				strErr+="RoomType不是数字！\\n";	
			}
			if(this.txtRoomState.Text =="")
			{
				strErr+="RoomState不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtBedNum.Text))
			{
				strErr+="BedNum不是数字！\\n";	
			}
			if(!PageValidate.IsNumber(txtGustNum.Text))
			{
				strErr+="GustNum不是数字！\\n";	
			}
			if(this.txtDescription.Text =="")
			{
				strErr+="Description不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int RoomNum=int.Parse(this.txtRoomNum.Text);
			int RoomType=int.Parse(this.txtRoomType.Text);
			string RoomState=this.txtRoomState.Text;
			int BedNum=int.Parse(this.txtBedNum.Text);
			int GustNum=int.Parse(this.txtGustNum.Text);
			string Description=this.txtDescription.Text;

			BookShop.Model.Room model=new BookShop.Model.Room();
			model.RoomNum=RoomNum;
			model.RoomType=RoomType;
			model.RoomState=RoomState;
			model.BedNum=BedNum;
			model.GustNum=GustNum;
			model.Description=Description;

			BookShop.BLL.RoomService bll=new BookShop.BLL.RoomService();
			bll.Add(model);

		}

    }
}
