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
	/// ҵ���߼���RoomService ��ժҪ˵����
	/// </summary>
	public class RoomService
	{
		private readonly IRoomDAL dal=DataAccess.CreateRoomDAL();
		public RoomService()
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
		public bool Exists(int RoomNum)
		{
			return dal.Exists(RoomNum);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Add(BookShop.Model.Room model)
		{
			dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(BookShop.Model.Room model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(int RoomNum)
		{
			
			dal.Delete(RoomNum);
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public BookShop.Model.Room GetModel(int RoomNum)
		{
			
			return dal.GetModel(RoomNum);
		}

		/// <summary>
		/// �õ�һ������ʵ�壬�ӻ����С�
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
		public List<BookShop.Model.Room> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
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

