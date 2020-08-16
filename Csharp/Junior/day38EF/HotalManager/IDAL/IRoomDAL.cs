using System;
using System.Data;
namespace BookShop.IDAL
{
	/// <summary>
	/// �ӿڲ�IRoomDAL ��ժҪ˵����
	/// </summary>
	public interface IRoomDAL
	{
		#region  ��Ա����
		/// <summary>
		/// �õ����ID
		/// </summary>
		int GetMaxId();
		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		bool Exists(int RoomNum);
		/// <summary>
		/// ����һ������
		/// </summary>
		void Add(BookShop.Model.Room model);
		/// <summary>
		/// ����һ������
		/// </summary>
		void Update(BookShop.Model.Room model);
		/// <summary>
		/// ɾ��һ������
		/// </summary>
		void Delete(int RoomNum);
		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		BookShop.Model.Room GetModel(int RoomNum);
		/// <summary>
		/// ��������б�
		/// </summary>
		DataSet GetList(string strWhere);
		/// <summary>
		/// ���ǰ��������
		/// </summary>
		DataSet GetList(int Top,string strWhere,string filedOrder);
		/// <summary>
		/// ���ݷ�ҳ��������б�
		/// </summary>
		//DataSet GetList(int PageSize,int PageIndex,string strWhere);
		#endregion  ��Ա����
	}
}
