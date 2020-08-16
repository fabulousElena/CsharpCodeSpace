using System;
using System.Data;
using System.Collections.Generic;
using LTP.Common;
using BookShop.Model;
using BookShop.DALFactory;
using BookShop.IDAL;
namespace BookShop.BLL
{
	/// <summary>
	/// 业务逻辑类RoomService 的摘要说明。
	/// </summary>
	public class RoomService
	{
		private readonly IRoomDAL dal=DataAccess.CreateRoomDAL();
		public RoomService()
		{}
		#region  成员方法

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
			return dal.GetMaxId();
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int RoomNum)
		{
			return dal.Exists(RoomNum);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(BookShop.Model.Room model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(BookShop.Model.Room model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int RoomNum)
		{
			
			dal.Delete(RoomNum);
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public BookShop.Model.Room GetModel(int RoomNum)
		{
			
			return dal.GetModel(RoomNum);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中。
		/// </summary>
		public BookShop.Model.Room GetModelByCache(int RoomNum)
		{
			
			string CacheKey = "RoomModel-" + RoomNum;
			object objModel = LTP.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(RoomNum);
					if (objModel != null)
					{
						int ModelCache = LTP.Common.ConfigHelper.GetConfigInt("ModelCache");
						LTP.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (BookShop.Model.Room)objModel;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<BookShop.Model.Room> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<BookShop.Model.Room> DataTableToList(DataTable dt)
		{
			List<BookShop.Model.Room> modelList = new List<BookShop.Model.Room>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				BookShop.Model.Room model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new BookShop.Model.Room();
					if(dt.Rows[n]["RoomNum"].ToString()!="")
					{
						model.RoomNum=int.Parse(dt.Rows[n]["RoomNum"].ToString());
					}
					if(dt.Rows[n]["RoomType"].ToString()!="")
					{
						model.RoomType=int.Parse(dt.Rows[n]["RoomType"].ToString());
					}
					model.RoomState=dt.Rows[n]["RoomState"].ToString();
					if(dt.Rows[n]["BedNum"].ToString()!="")
					{
						model.BedNum=int.Parse(dt.Rows[n]["BedNum"].ToString());
					}
					if(dt.Rows[n]["GustNum"].ToString()!="")
					{
						model.GustNum=int.Parse(dt.Rows[n]["GustNum"].ToString());
					}
					model.Description=dt.Rows[n]["Description"].ToString();
					modelList.Add(model);
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  成员方法
	}
}

