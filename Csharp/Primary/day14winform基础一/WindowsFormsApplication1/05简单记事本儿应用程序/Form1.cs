using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace _05简单记事本儿应用程序
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtWords.WordWrap = false;
            btnWordWrap.Visible = false;
            btnSave.Visible = false;
            txtWords.Visible = false;
        }


        /// <summary>
        /// 判断是否登陆成功
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string pwd = txtPwd.Text;

            if (name == "admin" && pwd == "admin")
            {
                MessageBox.Show("欢迎进入记事儿本应用程序");
                btnWordWrap.Visible = true;
                btnSave.Visible = true;
                txtWords.Visible = true;

                label1.Visible = false;
                label2.Visible = false;
                txtName.Visible = false;
                txtPwd.Visible = false;
                btnLogin.Visible = false;
                btnRest.Visible = false;  
            }
            else//登录失败
            {
                MessageBox.Show("用户名或密码错误，请重新输入");
                txtName.Clear();
                txtPwd.Clear();
                //让文本框获得焦点
                txtName.Focus();
            }
        }

        private void btnRest_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtPwd.Clear();
            txtName.Focus();
        }

        /// <summary>
        /// 自动换行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWordWrap_Click(object sender, EventArgs e)
        {
            //当前是否是自动换行
            //txtWords.WordWrap=true;
            //取消自动换行  
            if (btnWordWrap.Text == "自动换行")
            { 
                //取消自动换行
                txtWords.WordWrap = true;
                btnWordWrap.Text = "取消自动换行";
            }
            else if (btnWordWrap.Text == "取消自动换行")
            {
                txtWords.WordWrap = false;
                btnWordWrap.Text = "自动换行";
            }
        }


        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            using (FileStream fsWrite = new FileStream("newnew.txt", FileMode.OpenOrCreate, FileAccess.Write))
            {
                string str = txtWords.Text.Trim();
                byte[] buffer = System.Text.Encoding.Default.GetBytes(str);
                fsWrite.Write(buffer, 0, buffer.Length);
            }
            MessageBox.Show("保存成功");
        }

        private void txtWords_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
