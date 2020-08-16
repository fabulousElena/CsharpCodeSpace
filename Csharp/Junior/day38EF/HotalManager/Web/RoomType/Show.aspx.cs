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
namespace BookShop.Web.RoomType
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
					//ShowInfo(TypeId);
				}
			}
		}
		
	private void ShowInfo(int TypeId)
	{
		BookShop.BLL.RoomTypeService bll=new BookShop.BLL.RoomTypeService();
		BookShop.Model.RoomType model=bll.GetModel(TypeId);
		this.lblTypeName.Text=model.TypeName;
		this.lblPrice.Text=model.Price.ToString();
		this.lblAddBed.Text=model.AddBed.ToString();
		this.lblBedPrice.Text=model.BedPrice.ToString();
		this.lblRemark.Text=model.Remark;

	}


    }
}
