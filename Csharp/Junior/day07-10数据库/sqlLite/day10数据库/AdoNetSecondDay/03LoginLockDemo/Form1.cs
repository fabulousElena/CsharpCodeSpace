using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03LoginLockDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //第一步：先用户的Id，用户名，用户密码，用户错误次数，用户最后的错误时间  where UserName=txtUserName.Text  and UserPwd=txtUserPwd.Text

            string connStr = ConfigurationManager.ConnectionStrings["sqlConn"].ConnectionString;

            using (SqlConnection conn=new SqlConnection(connStr))
            {
                using (SqlCommand cmd =conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = @"SELECT  [UserId]
                                              ,[UserName]
                                              ,[UserPwd]
                                              ,[LastErrorDateTime]
                                              ,[ErrorTimes]
                                          FROM [UserInfo] 
                                          WHERE UserName='"+txtName.Text
                                          +"' and UserPwd='"+txtPwd.Text+"' ";

                    UserInfo userInfo = null;//查询来的数据封装的对象。

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        //把查询出来的数据赋值到userInfo
                        if (reader.Read())
                        {
                            userInfo =new UserInfo();
                            userInfo.UserId = int.Parse(reader["UserId"].ToString());
                            userInfo.UserPwd = reader["UserPwd"].ToString();
                            userInfo.LastErrorDateTime = DateTime.Parse(reader["LastErrorDateTime"].ToString());
                            userInfo.ErrorTimes = int.Parse(reader["ErrorTimes"].ToString());
                        }

                    }//花括号执行结束之前，链接一直没有关闭，这时候Reader一直占用Connection对象。
                    
                    //如果查询结果为空，说明用户名密码错误，修改错误次数和 错误时间。
                    if (userInfo==null)
                    {
                        //修改 错误时间，错误次数  where UserName=txtUserName.Text
                        cmd.CommandText =
                            "update UserInfo set LastErrorDateTime=getdate(), ErrorTimes=ErrorTimes+1 where UserName='" +
                            txtName.Text.Trim() + "'";
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("用户名密码Error");
                        return;
                    }

                    //如果有数据。后面校验时间 错误次数。
                    if (userInfo.ErrorTimes<3 || DateTime.Now.Subtract(userInfo.LastErrorDateTime).Minutes>15 )
                    {
                        MessageBox.Show("登陆成功！");
                        //
                        cmd.CommandText =
                          "update UserInfo set LastErrorDateTime=getdate(), ErrorTimes=0 where UserId=" +userInfo.UserId;
                        cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        MessageBox.Show("登陆失败！账号被锁定！");
                    }
                }
            }
        }
    }
}
