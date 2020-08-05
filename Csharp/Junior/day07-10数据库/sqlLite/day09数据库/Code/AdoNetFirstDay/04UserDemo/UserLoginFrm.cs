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
    public partial class UserLoginFrm : Form
    {
        public UserLoginFrm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //第一步：先把窗体上的数据拿到，然后校验数据的完整性
            if(string.IsNullOrEmpty(txtUserName.Text.Trim())
                || string.IsNullOrEmpty(txtPwd.Text.Trim()))
            {
                MessageBox.Show("请输入正确的用户密码！");
                return;
            }

            //第二步：链接数据库，然后做查询
            //string connStr = "server=.;uid=sa;pwd=123;database=0413DB";
            //约定：
            string connStr = ConnectionStringHelper.GetCurrentConnectionString();

            //如果链接字符串都是从  同一个地方获取的话。
            //单例模式

            //创建一个连接数据库的对象
            using (SqlConnection conn =new SqlConnection(connStr))
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    conn.Open();//打开数据库连接

                    //string sql =" select count(1) from UserInfo where UserName=用户名文本框的值 and UserPwd=密码框的值
                     string sql = string.Format("select count(1) from UserInfo where UserName='{0}' and UserPwd='{1}'",txtUserName.Text,txtPwd.Text);

                    //string sql = string.Format("select * from UserInfo order by UserId Desc ");

                    cmd.CommandText = sql;

                    //cmd职责就是执行sql脚本
                    object result= cmd.ExecuteScalar();//返回查询结果的第一行第一列的值。
                    int rows = int.Parse(result.ToString());
                    if (rows >= 1)
                    {
                        MessageBox.Show("ok");
                    }
                    else
                    {
                        MessageBox.Show("Game over"); 
                    }

                }
            }

        }
    }
}
