using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04DataSetDemos
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            //创建一个内存的数据集
            DataSet ds =new DataSet("DS5");

            //创建一张内存表
            DataTable dt1 =new DataTable("dt1");

            //把表放到数据集里面去。
            ds.Tables.Add(dt1);

            //给表定义列
            DataColumn dcName = new DataColumn("Name",typeof(string));
            DataColumn dcAge = new DataColumn("Age",typeof(int));
            DataColumn dcId=new DataColumn("Id",typeof(int));

            //把列放到表里面去。
            dt1.Columns.AddRange(new DataColumn[]{dcId,dcName,dcAge});

            //给表添加数据
            dt1.Rows.Add(1, "老马", 18);
            dt1.Rows.Add(1, "赵黑", 29);
            dt1.Rows.Add(1, "老王", 18);
            dt1.Rows.Add(1, "老汪", 19);




            //-------

            //创建一张内存表
            DataTable dt2 = new DataTable("dt2");

            //把表放到数据集里面去。
            ds.Tables.Add(dt2);

            //给表定义列
            DataColumn dcName2 = new DataColumn("Name", typeof(string));
            DataColumn dcAge2 = new DataColumn("Age", typeof(int));
            DataColumn dcId2 = new DataColumn("Id", typeof(int));

            //把列放到表里面去。
            dt2.Columns.AddRange(new DataColumn[] { dcId2, dcName2, dcAge2 });

            //给表添加数据
            dt2.Rows.Add(1, "老马", 18);
            dt2.Rows.Add(1, "赵黑", 29);
            dt2.Rows.Add(1, "老王", 18);
            dt2.Rows.Add(1, "老汪", 19);


            foreach(DataTable tb in ds.Tables)
            {
                foreach (DataRow dataRow in tb.Rows)
                {
                    Console.WriteLine(dataRow[0]+"  " +dataRow[1]+"  "+dataRow[2]);
                }
            }



        }
    }
}
