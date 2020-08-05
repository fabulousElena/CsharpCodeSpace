using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01SqlConnectionInnerConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            string connStr = "server=.;uid=sa;pwd=123456;database=demo;";
            using (SqlConnection conn = new SqlConnection(connStr))
            {

            }


        }
    }
}
