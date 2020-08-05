using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04UserDemo
{
    public class ConnectionStringHelper
    {
        public static string GetCurrentConnectionString()
        {
           

           return "server=192.168.22.60;uid=sa;pwd=123456;database=0413DB";

            //添加 System.Configuration;的引用

            //从配置文件中获取连接字符串
            return ConfigurationManager.ConnectionStrings["Sql"].ConnectionString;
        }
    }
}
