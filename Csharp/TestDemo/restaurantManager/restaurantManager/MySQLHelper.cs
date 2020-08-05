using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Data;

namespace restaurantManager
{
    public static class MySQLHelper
    {
        //从配置文件中读取链接字符串
        private static string conStr = ConfigurationManager.ConnectionStrings["mySqlConnection"].ConnectionString;

        /// <summary>
        /// 执行命令insert update delete并返回cmd
        /// </summary>
        /// <param name="sqlUrl">数据库操作语句</param>
        /// <returns></returns>
        public static MySqlCommand ExcuteQuery(string sqlUrl)
        {
            using (MySqlConnection msc = new MySqlConnection(conStr))
            {
                MySqlCommand mycmd = new MySqlCommand(sqlUrl, msc);
                msc.Open();
                return mycmd;
            }
        }

        /// <summary>
        /// 获取结果集  
        /// </summary>
        /// <param name="sqlUrl"></param>
        /// <param name="mycmd"></param>
        /// <returns></returns>
        public static DataSet ReturnTable(MySqlCommand mycmd)
        {
            using (MySqlConnection msc = new MySqlConnection(conStr))
            {
                MySqlDataAdapter mda = new MySqlDataAdapter(mycmd);
                DataSet
                     dt = new DataSet();
                msc.Open();
                mda.Fill(dt);
                return dt;
            }
        }


    }
}
