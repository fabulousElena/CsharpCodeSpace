using System;
using System.Data;
namespace BookShop.IDAL
{
	/// <summary>
	/// �ӿڲ�IRoomTypeDAL ��ժҪ˵����
	/// </summary>
	public interface IRoomTypeDAL
	{
		#region  ��Ա����
		/// <summary>
		/// �õ����ID
		/// </summary>
		int GetMaxId();
		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		bool Exists(int TypeId);
		/// <summary>
		/// ����һ������
		/// </summary>
		int Add(BookShop.Model.RoomType model);
		/// <summary>
		/// ����һ������
		/// </summary>
		void Update(BookShop.Model.RoomType model);
		/// <summary>
		/// ɾ��һ������
		/// </summary>
		void Delete(int TypeId);
		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		BookShop.Model.RoomType GetModel(int TypeId);
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
