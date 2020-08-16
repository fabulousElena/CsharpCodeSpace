using System;
namespace BookShop.Model
{
	/// <summary>
	/// 实体类Room 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class Room
	{
		public Room()
		{}
		#region Model
		private int _roomnum;
		private int? _roomtype;
		private string _roomstate;
		private int? _bednum;
		private int? _gustnum;
		private string _description;
		/// <summary>
		/// 
		/// </summary>
		public int RoomNum
		{
			set{ _roomnum=value;}
			get{return _roomnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? RoomType
		{
			set{ _roomtype=value;}
			get{return _roomtype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RoomState
		{
			set{ _roomstate=value;}
			get{return _roomstate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? BedNum
		{
			set{ _bednum=value;}
			get{return _bednum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? GustNum
		{
			set{ _gustnum=value;}
			get{return _gustnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Description
		{
			set{ _description=value;}
			get{return _description;}
		}
		#endregion Model

	}
}

