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
    public partial class Modify : System.Web.UI.Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					string id = Request.Params["id"];
					//ShowInfo(RoomNum);
				}
			}
		}
			
	private void ShowInfo(int RoomNum)
	{
		BookShop.BLL.RoomService bll=new BookShop.BLL.RoomService();
		BookShop.Model.Room model=bll.GetModel(RoomNum);
		this.lblRoomNum.Text=model.RoomNum.ToString();
		this.txtRoomType.Text=model.RoomType.ToString();
		this.txtRoomState.Text=model.RoomState;
		this.txtBedNum.Text=model.BedNum.ToString();
		this.txtGustNum.Text=model.GustNum.ToString();
		this.txtDescription.Text=model.Description;

	}

		public void btnUpdate_Click(object sender, EventArgs e)
		{
			
			string strErr="";
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
			int RoomType=int.Parse(this.txtRoomType.Text);
			string RoomState=this.txtRoomState.Text;
			int BedNum=int.Parse(this.txtBedNum.Text);
			int GustNum=int.Parse(this.txtGustNum.Text);
			string Description=this.txtDescription.Text;


			BookShop.Model.Room model=new BookShop.Model.Room();
			model.RoomType=RoomType;
			model.RoomState=RoomState;
			model.BedNum=BedNum;
			model.GustNum=GustNum;
			model.Description=Description;

			BookShop.BLL.RoomService bll=new BookShop.BLL.RoomService();
			bll.Update(model);

		}

    }
}
