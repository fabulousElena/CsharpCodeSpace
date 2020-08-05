using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelProgram;
using MySql.Data.MySqlClient;
using restaurantManager;

namespace DalProgram
{
    public partial class MemberInfoDal
    {
        /// <summary>
        /// 查询操作
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public List<MemberInfo> SerchFromMysql(string s) {
            string sqlUrl6 = "select mi.*,mti.`memtitle` from MemberInfo as mi inner join MemberTypeInfo as mti on mi.`mitypeid`=mti.`memid` where miphone like '%"+s+"%'";

            List<MemberInfo> mlist = new List<MemberInfo>();
            DataTable dt = MySQLHelper.ReturnTable(MySQLHelper.ExcuteQuery(sqlUrl6));
            foreach (DataRow item in dt.Rows) {
                mlist.Add(new MemberInfo() {
                    Miid = Convert.ToInt32(item["miid"]),
                    Miname = item["miname"].ToString(),
                    Miphone = item["miphone"].ToString(),
                    Miisdelete = Convert.ToInt32(item["miisdelete"]),
                    Mimoney = Convert.ToDouble(item["mimoney"]),
                    Mimembertype = item["memtitle"].ToString()
                });
            }
            return mlist;
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="mi"></param>
        /// <returns></returns>
        public int ChangeMysql(MemberInfo mi) {
            memberType = mi.Mimembertype;
            int memberIndex =Convert.ToInt32(GetMemberType());
            string sqlUrl5 = "UPDATE MemberInfo SET mitypeid = "+ memberIndex + ",miname = '" + mi.Miname + "',miphone = '" + mi.Miphone + "',mimoney = " + mi.Mimoney + ",miisdelete = " + mi.Miisdelete + " WHERE miid = " + mi.Miid + "";
            return  MySQLHelper.ExcuteQuery(sqlUrl5).ExecuteNonQuery();
        }

        /// <summary>
        /// 获得会员类型的名字
        /// </summary>
        /// <returns></returns>
        public List<string> GetMemberString() {
            string sqlUrl4 = "select memtitle,memisdelete from MemberTypeInfo";
            List<string> memList = new List<string>();
            DataTable dt = MySQLHelper.ReturnTable(MySQLHelper.ExcuteQuery(sqlUrl4));
            foreach (DataRow item in dt.Rows)
            {
                
                if (Convert.ToInt32(item["memisdelete"]) == 1)
                {
                    Console.WriteLine(item["memisdelete"].ToString());
                }
                else
                {
                    memList.Add(item["memtitle"].ToString());
                }
               
            }
            return memList;
        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="mi"></param>
        /// <returns></returns>
        public int AddMysql(MemberInfo mi)
        {
            memberType = mi.Mimembertype;
            string memberIndex = GetMemberType();
            string sqlUrl3 = "insert into MemberInfo (mitypeid,miname,miphone,mimoney,miisdelete) values("+ Convert.ToInt32(memberIndex)+",'" + mi.Miname + "','" + mi.Miphone + "'," + mi.Mimoney + "," + mi.Miisdelete + ")";
            return MySQLHelper.ExcuteQuery(sqlUrl3).ExecuteNonQuery();
        }
        //会员类型的下标
        
        //会员类型
        string memberType;
        string GetMemberType()
        {
            
            string sqlUrl4 = "select memid from MemberTypeInfo where memtitle = '" + memberType + "';";
            return MySQLHelper.ExcuteQuery(sqlUrl4).ExecuteScalar().ToString();
        }

        /// <summary>
        /// 删除操作
        /// </summary>
        /// <param name="mi"></param>
        /// <returns></returns>
        public int DeleteMysql(MemberInfo mi)
        {
            string sqlUrl2 = "update MemberInfo set miisdelete = '1' where miid = '" + mi.Miid + "';";
            return MySQLHelper.ExcuteQuery(sqlUrl2).ExecuteNonQuery();
        }


        /// <summary>
        /// 获得数据库数据
        /// </summary>
        /// <returns></returns>
        public List<MemberInfo> GetList()
        {
            string sqlUrl = "select mi.*,mti.`memtitle` from MemberInfo as mi inner join MemberTypeInfo as mti on mi.`mitypeid`=mti.`memid`";
            List<MemberInfo> mlist = new List<MemberInfo>();
            DataTable dt = MySQLHelper.ReturnTable(MySQLHelper.ExcuteQuery(sqlUrl));
            foreach (DataRow item in dt.Rows)
            {
                mlist.Add(new MemberInfo()
                {
                    Miid = Convert.ToInt32(item["miid"]),
                    Miname = item["miname"].ToString(),
                    Miphone = item["miphone"].ToString(),
                    Miisdelete = Convert.ToInt32(item["miisdelete"]),
                    Mimoney = Convert.ToDouble(item["mimoney"]),
                    Mimembertype = item["memtitle"].ToString()
                });
            }

            return mlist;
        }
    }
}
