using ModelProgram;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using CommonProgram;

namespace DalProgram
{
    public partial class ManagerInfoDal
    {
        ManagerInfo mi = null;
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="name">用户名</param>
        /// <returns></returns>
        public ManagerInfo UserLogin(string name)
        {
            string sqlUrl5 = "select * from ManagerInfo where username = '" + name + "'";
            Console.WriteLine(name);
            //执行查询结构
            DataTable dt = MySQLHelper.ReturnTable(MySQLHelper.ExcuteQuery(sqlUrl5));
            if (dt.Rows.Count > 0)
            {
                mi = new ManagerInfo();
               
                mi.userid = Convert.ToInt32(dt.Rows[0][0]);
                mi.username = name.ToString();
                mi.userpass = dt.Rows[0][2].ToString();
                mi.usertype = dt.Rows[0][3].ToString();


                return mi;
            }
            else
            {
                return mi;
            }
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="mi"></param>
        /// <returns></returns>
        public int DeleteManager(ManagerInfo mi)
        {
            string sqlUrl4 = "delete from ManagerInfo where userid = '" + mi.userid + "'";


            return MySQLHelper.ExcuteQuery(sqlUrl4).ExecuteNonQuery();
        }

        /// <summary>
        /// 执行修改语句
        /// </summary>
        /// <param name="mi"></param>
        /// <param name="b">是否改了密码</param>
        /// <returns></returns>
        public int UpdateManager(ManagerInfo mi, bool b)
        {
            string sqlUrl3;
            //改了 那就执行改了的语句  反之不执行
            if (b)
            {
                sqlUrl3 = "update ManagerInfo set username = '" + mi.username + "',userpass = '" + Md5Helper.GetMd(mi.userpass) + "',usertype='" + mi.usertype + "' where userid = '" + mi.userid + "'";
            }
            else
            {
                sqlUrl3 = "update ManagerInfo set username = '" + mi.username + "',usertype='" + mi.usertype + "' where userid = '" + mi.userid + "'";
            }
            return MySQLHelper.ExcuteQuery(sqlUrl3).ExecuteNonQuery();
        }



        /// <summary>
        /// 插入
        /// </summary>
        /// <param name="mi"></param>
        /// <returns></returns>
        public int InsertInto(ManagerInfo mi)
        {
            string sqlUrl2 = "insert into ManagerInfo (username,userpass,usertype) VALUES " +
                "('" + mi.username + "','" + Md5Helper.GetMd(mi.userpass) + "','" + mi.usertype + "')";
            Console.WriteLine(sqlUrl2);
            //返回 执行的行数
            return MySQLHelper.ExcuteQuery(sqlUrl2).ExecuteNonQuery();
            //return 1;
        }



        /// <summary>
        /// 获取结果集
        /// </summary>
        /// <returns></returns>
        public List<ManagerInfo> GetList()
        {
            string sql1 = "select * from ManagerInfo";
            List<ManagerInfo> mList = new List<ManagerInfo>();
            DataTable dt = MySQLHelper.ReturnTable(MySQLHelper.ExcuteQuery(sql1));
            foreach (DataRow item in dt.Rows)
            {
                //将数据存储到list中
                mList.Add(new ManagerInfo()
                {
                    userid = Convert.ToInt32(item["userid"]),
                    username = item["username"].ToString(),
                    userpass = item["userpass"].ToString(),
                    usertype = item["usertype"].ToString()
                });
            }
            return mList;
        }
    }
}
