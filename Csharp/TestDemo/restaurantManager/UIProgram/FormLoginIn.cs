using BllProgram;
using ModelProgram;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIProgram
{
    public partial class FormLoginIn : Form
    {
        public FormLoginIn()
        {
            InitializeComponent();
        }



        /// <summary>
        /// 退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bexit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
        ManagerInfoBll mib = new ManagerInfoBll();

        /// <summary>
        /// 登录按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void blogin_Click(object sender, EventArgs e)
        {
            ManagerInfo mi = new ManagerInfo();
            //判断
            if (tname.Text.Length != 0 && tpass.Text.Length!= 0)
            {
               bool b = mib.CheckLogin(tname.Text, tpass.Text);
                if (b)
                {
                    MessageBox.Show("登录成功");
                    //初始化主窗体的时候 把登录的用户类型传递过去
                    FormMain fMain = new FormMain(mib.ReturnType());
                    this.Hide();
                    fMain.Show();
                    
                }
                else
                {
                    MessageBox.Show("登录失败");
                }
            }
            else
            {
                MessageBox.Show("账号密码不匹配");
            }

        }

        private void FormLoginIn_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
