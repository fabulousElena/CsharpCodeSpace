using System;
using System.Data;
namespace BookShop.IDAL
{
	/// <summary>
	/// 接口层IRoomTypeDAL 的摘要说明。
	/// </summary>
	public interface IRoomTypeDAL
	{
		#region  成员方法
		/// <summary>
		/// 得到最大ID
		/// </summary>
		int GetMaxId();
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		bool Exists(int TypeId);
		/// <summary>
		/// 增加一条数据
		/// </summary>
		int Add(BookShop.Model.RoomType model);
		/// <summary>
		/// 更新一条数据
		/// </summary>
		void Update(BookShop.Model.RoomType model);
		/// <summary>
		/// 删除一条数据
		/// </summary>
		void Delete(int TypeId);
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		BookShop.Model.RoomType GetModel(int TypeId);
		/// <summary>
		/// 获得数据列表
		/// </summary>
		DataSet GetList(string strWhere);
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		DataSet GetList(int Top,string strWhere,string filedOrder);
		/// <summary>
		/// 根据分页获得数据列表
		/// </summary>
		//DataSet GetList(int PageSize,int PageIndex,string strWhere);
		#endregion  成员方法
	}
}
