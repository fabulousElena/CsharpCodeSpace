using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _01SqlConnectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 01第一个链接对象
            //连接字符串：就是对我们的连接进行设的字符串。
            //server:表示连接的服务，可以用 .   机器名  ip地址等表示
            //uid：sqlserver用户名   pwd：密码
            //database表示要连接的数据库。
            //string connStr = "server=127.0.0.1;uid=sa;pwd=123456;database=demo";
            //SqlConnection conn =new SqlConnection(connStr); 

            ////这才是真正的打开数据库
            //conn.Open();//如果链接成功了，那么不会抛出异常。
            //Console.WriteLine("打开数据库");

            ////Thread.Sleep(1000);

            //conn.Close();
            //conn.Dispose();
            //Console.WriteLine("数据库关闭了"); 
            #endregion

            #region 02 SqlCommand对象
            //连接上数据库，然后往 数据库中添加一条数据库。

            //string strConn = "server=(local);database=demo;uid=sa;pwd=123456";
            //string strConn = "Data Source=127.0.0.1;Initial Catalog=demo;User ID=sa;Password=123456";

            string strConn = "Data Source=127.0.0.1;Initial Catalog=Hotel;Integrated Security=True;";
            //根据链接字符串创建了一个链接对象
            #region trycatch写法
            //SqlConnection conn = new SqlConnection(strConn);
            //try
            //{
            //    //创建一个Sql命令对象
            //    SqlCommand cmd = new SqlCommand();
            //    //给命令对象指定 连接对象。
            //    cmd.Connection = conn;

            //    conn.Open();//一定要在执行命令之前打开就可以了。

            //    //此属性放我们的sql脚本
            //    cmd.CommandText = "insert into DboUserInfo(Name,DelFlag,Demo,cons)values('ss5559999',0,'sss',0)";

            //    cmd.ExecuteNonQuery();//执行一个非查询sql语句，返回受影响的行数。
            //}
            //finally
            //{
            //    conn.Close();//*****不要忘记关闭数据库连接。
            //} 
            #endregion

            using ( SqlConnection conn = new SqlConnection(strConn))
            {
                //创建一个Sql命令对象
                using (SqlCommand cmd = new SqlCommand())
                {
                    //给命令对象指定 连接对象。
                    cmd.Connection = conn;

                    conn.Open(); //一定要在执行命令之前打开就可以了。

                    //此属性放我们的sql脚本
                    cmd.CommandText = "insert into DboUserInfo(Name,DelFlag,Demo,cons)values('4444448888',0,'sss',0)";

                    cmd.ExecuteNonQuery(); //执行一个非查询sql语句，返回受影响的行数。 

                    //cmd.CommandText = "sel";
                    //cmd.ExecuteNonQuery()。。。。
                }
            }

            
            #endregion

            Console.ReadKey();

        }

        //public int Id { get; set; }
    }
}
