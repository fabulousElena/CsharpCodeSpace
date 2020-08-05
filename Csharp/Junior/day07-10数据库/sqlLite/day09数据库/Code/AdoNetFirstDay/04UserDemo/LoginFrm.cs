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
    public partial class LoginFrm : Form
    {
        public LoginFrm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text.Trim())
                || string.IsNullOrEmpty(txtPwd.Text.Trim())
                )
            {
                MessageBox.Show("您会登陆？");
                return;
            }

            //dry   dont repeat yourself
            //校验用户名密码
            string str = ConnectionStringHelper.GetCurrentConnectionString();

            using (SqlConnection conn = new SqlConnection(str))
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = @"select count(*) from UserInfo  where UserName='"+txtUserName.Text+"' and  UserPwd='"+txtPwd.Text+"'";
                    
                    //返回第一行第一列的值
                    object result = cmd.ExecuteScalar();

                    int rows = int.Parse(result.ToString());
                    if (rows >= 1)
                    {
                        MessageBox.Show("ok");
                    }
                    else
                    {
                        MessageBox.Show("game over");
                    }
                }
            }


            // 用户注册    用户列表    用户登录
        }
    }
}
