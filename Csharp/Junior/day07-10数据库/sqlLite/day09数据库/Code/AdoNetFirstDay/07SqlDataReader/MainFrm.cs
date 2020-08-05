using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07SqlDataReader
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
            //
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            List<StudentInfo> stuList =new List<StudentInfo>();

            //加载数据库中数据  
            string conStr = "server=.;uid=sa;pwd=123456;database=itcastdb";
            using (SqlConnection con = new SqlConnection(conStr))
            {
                using (SqlCommand cmd =con.CreateCommand())
                {
                    con.Open();
                    cmd.CommandText = "select  stuName,stuId, stuSex, stuBirthdate, stuPhone from [tblStudent] ";
                    //reader  指向了  sql命令执行后的查询结果。
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        //reader每执行一次read操作，就会让指针往下一条数据走
                        while (reader.Read())
                        {
                            #region 参考
                            // //reader 取数据
                            //int stuId= reader.GetInt32(1);
                            ////string stuName = reader.GetString(0);

                            ////建议用下面
                            //string stuName2 = reader["stuName"].ToString();
                            //Console.WriteLine(
                            //    string.Format("{0}-{1}-{2}-{3}", reader["stuName"].ToString(),reader["stuId"].ToString(),reader["stuBirthdate"].ToString(),reader["stuPhone"].ToString())
                            //    ); 
                            #endregion
                            StudentInfo stu =new StudentInfo();
                            stu.StuId = int.Parse(reader["stuId"].ToString());
                            stu.StuName = reader["stuName"] == DBNull.Value ? string.Empty : reader["stuName"].ToString();

                            stu.StuPhone = reader["stuPhone"].ToString();
                            stu.StuSex = reader["stuSex"].ToString()[0];
                            stu.DateTime = DateTime.Parse(reader["stuBirthdate"]==DBNull.Value?SqlDateTime.MinValue.ToString(): reader["stuBirthdate"].ToString());
                            stuList.Add(stu);
                        }//end  while
                    }// end  using reader
                }//end  usering  cmd
            }//end using connn

            this.dgvStudent.DataSource = stuList;
            //this.dgvStudent.data

            //把数据放到窗体的表格
        }
    }
}
