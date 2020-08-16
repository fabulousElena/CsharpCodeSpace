using System;
using System.Reflection;
using System.Configuration;
namespace BookShop.DALFactory
{
	/// <summary>
    /// Abstract Factory pattern to create the DAL。
    /// 如果在这里创建对象报错，请检查web.config里是否修改了<add key="DAL" value="Maticsoft.SQLServerDAL" />。
	/// </summary>
	public sealed class DataAccess
	{
        private static readonly string AssemblyPath = ConfigurationManager.AppSettings["DAL"];        
		public DataAccess()
		{ }

        #region CreateObject 

		//不使用缓存
        private static object CreateObjectNoCache(string AssemblyPath,string classNamespace)
		{		
			try
			{
				object objType = Assembly.Load(AssemblyPath).CreateInstance(classNamespace);	
				return objType;
			}
			catch//(System.Exception ex)
			{
				//string str=ex.Message;// 记录错误日志
				return null;
			}			
			
        }
		//使用缓存
		private static object CreateObject(string AssemblyPath,string classNamespace)
		{			
			object objType = DataCache.GetCache(classNamespace);
			if (objType == null)
			{
				try
				{
					objType = Assembly.Load(AssemblyPath).CreateInstance(classNamespace);					
					DataCache.SetCache(classNamespace, objType);// 写入缓存
				}
				catch//(System.Exception ex)
				{
					//string str=ex.Message;// 记录错误日志
				}
			}
			return objType;
		}
        #endregion

        #region CreateSysManage
        public static BookShop.IDAL.ISysManage CreateSysManage()
		{
			//方式1			
			//return (BookShop.IDAL.ISysManage)Assembly.Load(AssemblyPath).CreateInstance(AssemblyPath+".SysManage");

			//方式2 			
			string classNamespace = AssemblyPath+".SysManage";	
			object objType=CreateObject(AssemblyPath,classNamespace);
            return (BookShop.IDAL.ISysManage)objType;		
		}
		#endregion
             
        
   
		/// <summary>
		/// 创建RoomDAL数据层接口
		/// </summary>
		public static BookShop.IDAL.IRoomDAL CreateRoomDAL()
		{

			string ClassNamespace = AssemblyPath +".RoomDAL";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (BookShop.IDAL.IRoomDAL)objType;
		}

		/// <summary>
		/// 创建RoomTypeDAL数据层接口
		/// </summary>
		public static BookShop.IDAL.IRoomTypeDAL CreateRoomTypeDAL()
		{

			string ClassNamespace = AssemblyPath +".RoomTypeDAL";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (BookShop.IDAL.IRoomTypeDAL)objType;
		}

}
}