using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01复习
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //操作数据库的类：
            //连接Connection->SqliteConnection
            //命令Command
            //适配器DataAdapter
            //DataReader
            //DataSet,DataTable

            #region 手动写查询代码
            ////从数据库表ManagerInfo中查询数据
            ////0、构造接收数据的集合
            //List<ManagerInfo> list = new List<ManagerInfo>();
            ////1、连接字符串
            //string connStr = @"data source=C:\Users\q1\Desktop\ItcastCater.db;version=3;";
            ////2、创建连接对象
            //using (SQLiteConnection conn = new SQLiteConnection(connStr))
            //{
            //    //3、创建Command对象
            //    SQLiteCommand cmd = new SQLiteCommand("select * from ManagerInfo", conn);
            //    //4、打开链接
            //    conn.Open();
            //    //5、执行命令
            //    SQLiteDataReader reader = cmd.ExecuteReader();
            //    //6、读取
            //    if (reader.HasRows)
            //    {
            //        while (reader.Read())
            //        {
            //            //将一行数据构造成对象加入集合
            //            list.Add(new ManagerInfo()
            //            {
            //                Mid = Convert.ToInt32(reader["mid"]),
            //                Mname = reader["mname"].ToString(),
            //                Mpwd = reader["mpwd"].ToString(),
            //                Mtype = Convert.ToInt32(reader["mtype"])
            //            });
            //        }
            //    }
            //    reader.Close();
            //    //7、将显示到DataGridView上
            //    dataGridView1.DataSource = list;
            //} 
            #endregion

            //使用封装的方法进行查询
            dataGridView1.DataSource = SqliteHelper.GetDataTable("select * from ManagerInfo");
        }
    }
}
