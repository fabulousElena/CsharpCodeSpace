using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04UserDemo
{
    public partial class UserRegistFrm : Form
    {
        public UserRegistFrm()
        {
            InitializeComponent();
        }

        private void btnRegist_Click(object sender, EventArgs e)
        {
            //校验我们的信息是否完整
            if (!CheckFrmTxt())
            {

                return;
            }

            //插入操作
            string conStr = "server=.;uid=sa;pwd=123456;database=0413DB";
            //string conStr = ConnectionStringHelper.GetCurrentConnectionString();


            using (SqlConnection conn = new SqlConnection(conStr))
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    conn.Open();
                    string strSql =
                        string.Format(@"insert into UserInfo 
                                   (UserName,UserAge,UserPwd,DelFlag,CreateDate) 
                                   values('{0}',{1},'{2}',0,'{3}')",
                        txtUserName.Text,
                        int.Parse(txtAge.Text),
                        txtPwd1.Text,
                        DateTime.Now.ToString());

                    cmd.CommandText = strSql;
                    cmd.ExecuteNonQuery();
                }

            }
            MessageBox.Show("OK");

        }

        private bool CheckFrmTxt()
        {
            //校验窗体数据合法性
            if (string.IsNullOrEmpty(this.txtUserName.Text.Trim()))
            {
                this.lbUserNameCheckResult.Visible = true;
                MessageBox.Show("用户名不为空");
                return false;
            }

            return true;
        }

    }
}
