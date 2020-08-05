using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06DataImport
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        private void btnSelectDataFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "文本文件|*.txt";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    this.txtFilePath.Text = ofd.FileName;

                    //导入数据工作
                    ImportData(ofd.FileName);
                    MessageBox.Show("OK");
                }
            }
        }

        //做数据导入工作
        private void ImportData(string fileName)
        {
            string temp = string.Empty;
            //第一步：拿到文件
            //File.ReadAllLines();
            using (StreamReader reader = new StreamReader(fileName, Encoding.UTF8))
            {
                reader.ReadLine();//去掉第一行。
                //string connStr = "server=.;uid=sa;pwd=123456;database=itcastdb";
                string connStr = ConfigurationManager.ConnectionStrings["sqlConn"].ConnectionString;

                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    using (SqlCommand cmd = conn.CreateCommand())
                    {
                        conn.Open();//连接只能打开一次。
                        while (!string.IsNullOrEmpty(temp = reader.ReadLine()))
                        {
                            //把字符串进行分割然后生成一条sql插入到数据库中去。
                            var strs = temp.Split(',');
                            string sql = string.Format(@"
                     insert into tblStudent
                     (stuName,stuSex,stuBirthDate,stuPhone)
                     values('{0}','{1}','{2}','{3}')", strs[1], strs[2], strs[3], strs[4]);
                            cmd.CommandText = sql;
                            cmd.ExecuteNonQuery();
                        }// end  while
                    }//end  using  cmd
                }//end using conn
            }//end  reader
        }
    }
}
