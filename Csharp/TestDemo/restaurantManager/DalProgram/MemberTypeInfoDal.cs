using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelProgram;
using MySql.Data.MySqlClient;

namespace DalProgram
{
    public class MemberTypeInfoDal
    {

        public int DeleteForMysql(MemberTypeInfo mi) {
            string sqlUrl4 = "update MemberTypeInfo set memisdelete = '1' where memid = '"+mi.Memid+"';";
            return MySQLHelper.ExcuteQuery(sqlUrl4).ExecuteNonQuery();
        }


        /// <summary>
        /// 修改s
        /// </summary>
        /// <param name="mi"></param>
        /// <returns></returns>
        public int ChangeForMysql(MemberTypeInfo mi) {
            string sqlUrl3 = "update MemberTypeInfo set memtitle = '"+mi.Memtitle+ "',memdiscount = '" + mi.Memdiscount + "' where memid = '" + mi.Memid + "';";
            return  MySQLHelper.ExcuteQuery(sqlUrl3).ExecuteNonQuery();
        }


        /// <summary>
        /// 添加到数据库
        /// </summary>
        /// <param name="mi"></param>
        /// <returns></returns>
        public int AddToMysql(MemberTypeInfo mi)
        {
            string sqlUrl2 = "insert into MemberTypeInfo (memtitle,memdiscount,memisdelete) values ('"+mi.Memtitle+ "','" + mi.Memdiscount + "','" + mi.Memisdelete + "')";
            return MySQLHelper.ExcuteQuery(sqlUrl2).ExecuteNonQuery();

        }


        /// <summary>
        /// 获得数据库的数据
        /// </summary>
        /// <returns></returns>
        public List<MemberTypeInfo> GetList()
        {
            string sqlUrl = "select * from MemberTypeInfo";
            List<MemberTypeInfo> mList = new List<MemberTypeInfo>();
            DataTable dt = MySQLHelper.ReturnTable(MySQLHelper.ExcuteQuery(sqlUrl));
            foreach (DataRow item in dt.Rows)
            {
                mList.Add(new MemberTypeInfo()
                {
                    Memid = Convert.ToInt32(item["memid"]),
                    Memtitle = item["memtitle"].ToString(),
                    Memdiscount = Convert.ToDouble(item["memdiscount"]),
                    Memisdelete = Convert.ToInt32(item["memisdelete"])
                });
            }

            return mList;
        }
    }
}
