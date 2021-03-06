using System;
using System.Data;
namespace BookShop.IDAL
{
	/// <summary>
	/// 接口层IRoomDAL 的摘要说明。
	/// </summary>
	public interface IRoomDAL
	{
		#region  成员方法
		/// <summary>
		/// 得到最大ID
		/// </summary>
		int GetMaxId();
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		bool Exists(int RoomNum);
		/// <summary>
		/// 增加一条数据
		/// </summary>
		void Add(BookShop.Model.Room model);
		/// <summary>
		/// 更新一条数据
		/// </summary>
		void Update(BookShop.Model.Room model);
		/// <summary>
		/// 删除一条数据
		/// </summary>
		void Delete(int RoomNum);
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		BookShop.Model.Room GetModel(int RoomNum);
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
