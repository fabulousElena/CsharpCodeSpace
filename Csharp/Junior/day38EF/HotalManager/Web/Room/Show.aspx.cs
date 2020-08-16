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
namespace BookShop.Web.Room
{
    public partial class Show : System.Web.UI.Page
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
		this.lblRoomType.Text=model.RoomType.ToString();
		this.lblRoomState.Text=model.RoomState;
		this.lblBedNum.Text=model.BedNum.ToString();
		this.lblGustNum.Text=model.GustNum.ToString();
		this.lblDescription.Text=model.Description;

	}


    }
}
