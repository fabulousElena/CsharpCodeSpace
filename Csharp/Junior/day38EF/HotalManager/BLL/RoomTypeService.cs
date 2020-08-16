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
	/// 业务逻辑类RoomTypeService 的摘要说明。
	/// </summary>
	public class RoomTypeService
	{
		private readonly IRoomTypeDAL dal=DataAccess.CreateRoomTypeDAL();
		public RoomTypeService()
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
		public bool Exists(int TypeId)
		{
			return dal.Exists(TypeId);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(BookShop.Model.RoomType model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(BookShop.Model.RoomType model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int TypeId)
		{
			
			dal.Delete(TypeId);
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public BookShop.Model.RoomType GetModel(int TypeId)
		{
			
			return dal.GetModel(TypeId);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中。
		/// </summary>
		public BookShop.Model.RoomType GetModelByCache(int TypeId)
		{
			
			string CacheKey = "RoomTypeModel-" + TypeId;
			object objModel = LTP.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(TypeId);
					if (objModel != null)
					{
						int ModelCache = LTP.Common.ConfigHelper.GetConfigInt("ModelCache");
						LTP.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (BookShop.Model.RoomType)objModel;
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
		public List<BookShop.Model.RoomType> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<BookShop.Model.RoomType> DataTableToList(DataTable dt)
		{
			List<BookShop.Model.RoomType> modelList = new List<BookShop.Model.RoomType>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				BookShop.Model.RoomType model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new BookShop.Model.RoomType();
					if(dt.Rows[n]["TypeId"].ToString()!="")
					{
						model.TypeId=int.Parse(dt.Rows[n]["TypeId"].ToString());
					}
					model.TypeName=dt.Rows[n]["TypeName"].ToString();
					if(dt.Rows[n]["Price"].ToString()!="")
					{
						model.Price=decimal.Parse(dt.Rows[n]["Price"].ToString());
					}
					if(dt.Rows[n]["AddBed"].ToString()!="")
					{
						model.AddBed=int.Parse(dt.Rows[n]["AddBed"].ToString());
					}
					if(dt.Rows[n]["BedPrice"].ToString()!="")
					{
						model.BedPrice=decimal.Parse(dt.Rows[n]["BedPrice"].ToString());
					}
					model.Remark=dt.Rows[n]["Remark"].ToString();
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

