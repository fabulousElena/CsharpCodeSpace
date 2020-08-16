using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using BookShop.IDAL;
using Maticsoft.DBUtility;//请先添加引用
namespace BookShop.SQLServerDAL
{
	/// <summary>
	/// 数据访问类RoomDAL。
	/// </summary>
	public class RoomDAL:IRoomDAL
	{
		public RoomDAL()
		{}
		#region  成员方法

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("RoomNum", "Room"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int RoomNum)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Room");
			strSql.Append(" where RoomNum=@RoomNum ");
			SqlParameter[] parameters = {
					new SqlParameter("@RoomNum", SqlDbType.Int,4)};
			parameters[0].Value = RoomNum;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add(BookShop.Model.Room model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Room(");
			strSql.Append("RoomNum,RoomType,RoomState,BedNum,GustNum,Description)");
			strSql.Append(" values (");
			strSql.Append("@RoomNum,@RoomType,@RoomState,@BedNum,@GustNum,@Description)");
			SqlParameter[] parameters = {
					new SqlParameter("@RoomNum", SqlDbType.Int,4),
					new SqlParameter("@RoomType", SqlDbType.Int,4),
					new SqlParameter("@RoomState", SqlDbType.VarChar,50),
					new SqlParameter("@BedNum", SqlDbType.Int,4),
					new SqlParameter("@GustNum", SqlDbType.Int,4),
					new SqlParameter("@Description", SqlDbType.VarChar,100)};
			parameters[0].Value = model.RoomNum;
			parameters[1].Value = model.RoomType;
			parameters[2].Value = model.RoomState;
			parameters[3].Value = model.BedNum;
			parameters[4].Value = model.GustNum;
			parameters[5].Value = model.Description;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(BookShop.Model.Room model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Room set ");
			strSql.Append("RoomType=@RoomType,");
			strSql.Append("RoomState=@RoomState,");
			strSql.Append("BedNum=@BedNum,");
			strSql.Append("GustNum=@GustNum,");
			strSql.Append("Description=@Description");
			strSql.Append(" where RoomNum=@RoomNum ");
			SqlParameter[] parameters = {
					new SqlParameter("@RoomNum", SqlDbType.Int,4),
					new SqlParameter("@RoomType", SqlDbType.Int,4),
					new SqlParameter("@RoomState", SqlDbType.VarChar,50),
					new SqlParameter("@BedNum", SqlDbType.Int,4),
					new SqlParameter("@GustNum", SqlDbType.Int,4),
					new SqlParameter("@Description", SqlDbType.VarChar,100)};
			parameters[0].Value = model.RoomNum;
			parameters[1].Value = model.RoomType;
			parameters[2].Value = model.RoomState;
			parameters[3].Value = model.BedNum;
			parameters[4].Value = model.GustNum;
			parameters[5].Value = model.Description;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int RoomNum)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Room ");
			strSql.Append(" where RoomNum=@RoomNum ");
			SqlParameter[] parameters = {
					new SqlParameter("@RoomNum", SqlDbType.Int,4)};
			parameters[0].Value = RoomNum;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public BookShop.Model.Room GetModel(int RoomNum)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 RoomNum,RoomType,RoomState,BedNum,GustNum,Description from Room ");
			strSql.Append(" where RoomNum=@RoomNum ");
			SqlParameter[] parameters = {
					new SqlParameter("@RoomNum", SqlDbType.Int,4)};
			parameters[0].Value = RoomNum;

			BookShop.Model.Room model=new BookShop.Model.Room();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["RoomNum"].ToString()!="")
				{
					model.RoomNum=int.Parse(ds.Tables[0].Rows[0]["RoomNum"].ToString());
				}
				if(ds.Tables[0].Rows[0]["RoomType"].ToString()!="")
				{
					model.RoomType=int.Parse(ds.Tables[0].Rows[0]["RoomType"].ToString());
				}
				model.RoomState=ds.Tables[0].Rows[0]["RoomState"].ToString();
				if(ds.Tables[0].Rows[0]["BedNum"].ToString()!="")
				{
					model.BedNum=int.Parse(ds.Tables[0].Rows[0]["BedNum"].ToString());
				}
				if(ds.Tables[0].Rows[0]["GustNum"].ToString()!="")
				{
					model.GustNum=int.Parse(ds.Tables[0].Rows[0]["GustNum"].ToString());
				}
				model.Description=ds.Tables[0].Rows[0]["Description"].ToString();
				return model;
			}
			else
			{
				return null;
			}
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select RoomNum,RoomType,RoomState,BedNum,GustNum,Description ");
			strSql.Append(" FROM Room ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" RoomNum,RoomType,RoomState,BedNum,GustNum,Description ");
			strSql.Append(" FROM Room ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "Room";
			parameters[1].Value = "ID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  成员方法
	}
}

