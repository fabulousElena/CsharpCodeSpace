using System;
namespace BookShop.Model
{
	/// <summary>
	/// 实体类RoomType 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class RoomType
	{
		public RoomType()
		{}
		#region Model
		private int _typeid;
		private string _typename;
		private decimal? _price;
		private int? _addbed;
		private decimal? _bedprice;
		private string _remark;
		/// <summary>
		/// 
		/// </summary>
		public int TypeId
		{
			set{ _typeid=value;}
			get{return _typeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TypeName
		{
			set{ _typename=value;}
			get{return _typename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Price
		{
			set{ _price=value;}
			get{return _price;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? AddBed
		{
			set{ _addbed=value;}
			get{return _addbed;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? BedPrice
		{
			set{ _bedprice=value;}
			get{return _bedprice;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		#endregion Model

	}
}

