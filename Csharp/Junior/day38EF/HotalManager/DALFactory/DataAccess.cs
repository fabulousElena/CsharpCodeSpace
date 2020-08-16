using System;
using System.Reflection;
using System.Configuration;
namespace BookShop.DALFactory
{
	/// <summary>
    /// Abstract Factory pattern to create the DAL��
    /// ��������ﴴ�����󱨴�����web.config���Ƿ��޸���<add key="DAL" value="Maticsoft.SQLServerDAL" />��
	/// </summary>
	public sealed class DataAccess
	{
        private static readonly string AssemblyPath = ConfigurationManager.AppSettings["DAL"];        
		public DataAccess()
		{ }

        #region CreateObject 

		//��ʹ�û���
        private static object CreateObjectNoCache(string AssemblyPath,string classNamespace)
		{		
			try
			{
				object objType = Assembly.Load(AssemblyPath).CreateInstance(classNamespace);	
				return objType;
			}
			catch//(System.Exception ex)
			{
				//string str=ex.Message;// ��¼������־
				return null;
			}			
			
        }
		//ʹ�û���
		private static object CreateObject(string AssemblyPath,string classNamespace)
		{			
			object objType = DataCache.GetCache(classNamespace);
			if (objType == null)
			{
				try
				{
					objType = Assembly.Load(AssemblyPath).CreateInstance(classNamespace);					
					DataCache.SetCache(classNamespace, objType);// д�뻺��
				}
				catch//(System.Exception ex)
				{
					//string str=ex.Message;// ��¼������־
				}
			}
			return objType;
		}
        #endregion

        #region CreateSysManage
        public static BookShop.IDAL.ISysManage CreateSysManage()
		{
			//��ʽ1			
			//return (BookShop.IDAL.ISysManage)Assembly.Load(AssemblyPath).CreateInstance(AssemblyPath+".SysManage");

			//��ʽ2 			
			string classNamespace = AssemblyPath+".SysManage";	
			object objType=CreateObject(AssemblyPath,classNamespace);
            return (BookShop.IDAL.ISysManage)objType;		
		}
		#endregion
             
        
   
		/// <summary>
		/// ����RoomDAL���ݲ�ӿ�
		/// </summary>
		public static BookShop.IDAL.IRoomDAL CreateRoomDAL()
		{

			string ClassNamespace = AssemblyPath +".RoomDAL";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (BookShop.IDAL.IRoomDAL)objType;
		}

		/// <summary>
		/// ����RoomTypeDAL���ݲ�ӿ�
		/// </summary>
		public static BookShop.IDAL.IRoomTypeDAL CreateRoomTypeDAL()
		{

			string ClassNamespace = AssemblyPath +".RoomTypeDAL";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (BookShop.IDAL.IRoomTypeDAL)objType;
		}

}
}