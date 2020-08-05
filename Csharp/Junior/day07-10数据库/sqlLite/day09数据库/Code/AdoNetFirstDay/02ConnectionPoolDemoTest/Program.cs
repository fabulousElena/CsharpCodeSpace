using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02ConnectionPoolDemoTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string connStrPool = "Data Source=127.0.0.1;Initial Catalog=Hotel;User ID=sa;Password=123456;Pooling=true;Min Pool Size=4";

            string connStr = "Data Source=127.0.0.1;Initial Catalog=Hotel;User ID=sa;Password=123456;Pooling=false";
            int i = 0;
            Stopwatch sw =new Stopwatch();
            sw.Start();
            while (i<1000)
            {
                using (SqlConnection conn = new SqlConnection(connStrPool))
                {
                    conn.Open();
                }
                i++;
            }
            sw.Stop();
            Console.WriteLine(sw.Elapsed.Milliseconds);

            sw.Reset();
            sw.Restart();
            i = 0;
            while (i < 1000)
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                }
                i++;
            }
            sw.Stop();
            
            Console.WriteLine(sw.Elapsed.Milliseconds);
            Console.ReadKey();
        }
    }
}
