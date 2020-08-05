using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Maticsoft.DBUtility;
namespace BookShop.DAL
{
   public class Articel_WordsService
    {
       public int Insert(Model.Articel_Words model)
       {
           string sql = "insert into Articel_Words(WordPattern, IsForbid, IsMod, ReplaceWord) values(@WordPattern, @IsForbid, @IsMod, @ReplaceWord)";
           SqlParameter[] pars = { 
                                 new SqlParameter("@WordPattern",SqlDbType.NVarChar,50),
                                            new SqlParameter("@IsForbid",SqlDbType.Bit),
                                                       new SqlParameter("@IsMod",SqlDbType.Bit),
                                                                  new SqlParameter("@ReplaceWord",SqlDbType.NVarChar,50)

                                 
                                 };

           pars[0].Value = model.WordPattern;
           pars[1].Value = model.IsForbid;
           pars[2].Value = model.IsMod;
           pars[3].Value = model.ReplaceWord;
           return DbHelperSQL.ExecuteSql(sql, pars);
       }
       /// <summary>
       /// 获取所有的禁用词
       /// </summary>
       /// <returns></returns>
       public List<string> GetForbidWord()
       {
           string sql = "select WordPattern from Articel_Words where IsForbid=1";
           List<string> list = null;
           using (SqlDataReader dr = DbHelperSQL.ExecuteReader(sql))
           {
               if (dr.HasRows)
               {
                   list = new List<string>();
                   while (dr.Read())
                   {
                       list.Add(dr["WordPattern"].ToString());
                      
                   }
               }
           }
           return list;
       }
       /// <summary>
       /// 查询所有的审查词
       /// </summary>
       /// <returns></returns>
       public List<string> GetModWord()
       {
           string sql = "select WordPattern from Articel_Words where IsMod=1";
           List<string> list = null;
           using (SqlDataReader dr = DbHelperSQL.ExecuteReader(sql))
           {
               if (dr.HasRows)
               {
                   list = new List<string>();
                   while (dr.Read())
                   {
                       list.Add(dr["WordPattern"].ToString());

                   }
               }
           }
           return list;
       }
       /// <summary>
       /// 获取所有的审查词
       /// </summary>
       /// <returns></returns>
       public List<Model.Articel_Words> GetReplaceWord()
       {
           string sql = "select WordPattern,ReplaceWord from Articel_Words where IsMod=0 and IsForbid=0";
           List<Model.Articel_Words> list = null;
           using (SqlDataReader dr = DbHelperSQL.ExecuteReader(sql))
           {
               if (dr.HasRows)
               {
                   list = new List<Model.Articel_Words>();
                   while (dr.Read())
                   {
                       Model.Articel_Words articel = new Model.Articel_Words();
                       articel.WordPattern = dr["WordPattern"].ToString();
                       articel.ReplaceWord = dr["ReplaceWord"].ToString();
                       list.Add(articel);

                   }
               }
           }
           return list;

       }

    }
}
