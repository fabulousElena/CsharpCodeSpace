using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using BookShop.IDAL;
using Maticsoft.DBUtility;//�����������
namespace BookShop.SQLServerDAL
{
	/// <summary>
	/// ���ݷ�����RoomTypeDAL��
	/// </summary>
	public class RoomTypeDAL:IRoomTypeDAL
	{
		public RoomTypeDAL()
		{}
		#region  ��Ա����

		/// <summary>
		/// �õ����ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("TypeId", "RoomType"); 
		}

		/// <summary>
		/// �Ƿ���ڸü�¼
		/// </summary>
		public bool Exists(int TypeId)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from RoomType");
			strSql.Append(" where TypeId=@TypeId ");
			SqlParameter[] parameters = {
					new SqlParameter("@TypeId", SqlDbType.Int,4)};
			parameters[0].Value = TypeId;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// ����һ������
		/// </summary>
		public int Add(BookShop.Model.RoomType model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into RoomType(");
			strSql.Append("TypeName,Price,AddBed,BedPrice,Remark)");
			strSql.Append(" values (");
			strSql.Append("@TypeName,@Price,@AddBed,@BedPrice,@Remark)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@TypeName", SqlDbType.VarChar,50),
					new SqlParameter("@Price", SqlDbType.Money,8),
					new SqlParameter("@AddBed", SqlDbType.Int,4),
					new SqlParameter("@BedPrice", SqlDbType.Money,8),
					new SqlParameter("@Remark", SqlDbType.VarChar,100)};
			parameters[0].Value = model.TypeName;
			parameters[1].Value = model.Price;
			parameters[2].Value = model.AddBed;
			parameters[3].Value = model.BedPrice;
			parameters[4].Value = model.Remark;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 1;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// ����һ������
		/// </summary>
		public void Update(BookShop.Model.RoomType model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update RoomType set ");
			strSql.Append("TypeName=@TypeName,");
			strSql.Append("Price=@Price,");
			strSql.Append("AddBed=@AddBed,");
			strSql.Append("BedPrice=@BedPrice,");
			strSql.Append("Remark=@Remark");
			strSql.Append(" where TypeId=@TypeId ");
			SqlParameter[] parameters = {
					new SqlParameter("@TypeId", SqlDbType.Int,4),
					new SqlParameter("@TypeName", SqlDbType.VarChar,50),
					new SqlParameter("@Price", SqlDbType.Money,8),
					new SqlParameter("@AddBed", SqlDbType.Int,4),
					new SqlParameter("@BedPrice", SqlDbType.Money,8),
					new SqlParameter("@Remark", SqlDbType.VarChar,100)};
			parameters[0].Value = model.TypeId;
			parameters[1].Value = model.TypeName;
			parameters[2].Value = model.Price;
			parameters[3].Value = model.AddBed;
			parameters[4].Value = model.BedPrice;
			parameters[5].Value = model.Remark;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// ɾ��һ������
		/// </summary>
		public void Delete(int TypeId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from RoomType ");
			strSql.Append(" where TypeId=@TypeId ");
			SqlParameter[] parameters = {
					new SqlParameter("@TypeId", SqlDbType.Int,4)};
			parameters[0].Value = TypeId;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}


		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public BookShop.Model.RoomType GetModel(int TypeId)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 TypeId,TypeName,Price,AddBed,BedPrice,Remark from RoomType ");
			strSql.Append(" where TypeId=@TypeId ");
			SqlParameter[] parameters = {
					new SqlParameter("@TypeId", SqlDbType.Int,4)};
			parameters[0].Value = TypeId;

			BookShop.Model.RoomType model=new BookShop.Model.RoomType();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["TypeId"].ToString()!="")
				{
					model.TypeId=int.Parse(ds.Tables[0].Rows[0]["TypeId"].ToString());
				}
				model.TypeName=ds.Tables[0].Rows[0]["TypeName"].ToString();
				if(ds.Tables[0].Rows[0]["Price"].ToString()!="")
				{
					model.Price=decimal.Parse(ds.Tables[0].Rows[0]["Price"].ToString());
				}
				if(ds.Tables[0].Rows[0]["AddBed"].ToString()!="")
				{
					model.AddBed=int.Parse(ds.Tables[0].Rows[0]["AddBed"].ToString());
				}
				if(ds.Tables[0].Rows[0]["BedPrice"].ToString()!="")
				{
					model.BedPrice=decimal.Parse(ds.Tables[0].Rows[0]["BedPrice"].ToString());
				}
				model.Remark=ds.Tables[0].Rows[0]["Remark"].ToString();
				return model;
			}
			else
			{
				return null;
			}
		}

		/// <summary>
		/// ��������б�
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select TypeId,TypeName,Price,AddBed,BedPrice,Remark ");
			strSql.Append(" FROM RoomType ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// ���ǰ��������
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" TypeId,TypeName,Price,AddBed,BedPrice,Remark ");
			strSql.Append(" FROM RoomType ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// ��ҳ��ȡ�����б�
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
			parameters[0].Value = "RoomType";
			parameters[1].Value = "ID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  ��Ա����
	}
}

