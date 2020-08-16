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
	/// ҵ���߼���RoomTypeService ��ժҪ˵����
	/// </summary>
	public class RoomTypeService
	{
		private readonly IRoomTypeDAL dal=DataAccess.CreateRoomTypeDAL();
		public RoomTypeService()
		{}
		#region  ��Ա����

		/// <summary>
		/// �õ����ID
		/// </summary>
		public int GetMaxId()
		{
			return dal.GetMaxId();
		}

		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(int TypeId)
		{
			return dal.Exists(TypeId);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public int  Add(BookShop.Model.RoomType model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(BookShop.Model.RoomType model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(int TypeId)
		{
			
			dal.Delete(TypeId);
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public BookShop.Model.RoomType GetModel(int TypeId)
		{
			
			return dal.GetModel(TypeId);
		}

		/// <summary>
		/// �õ�һ������ʵ�壬�ӻ����С�
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
		/// ��������б�
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// ���ǰ��������
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<BookShop.Model.RoomType> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
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
		/// ��������б�
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// ��������б�
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  ��Ա����
	}
}

