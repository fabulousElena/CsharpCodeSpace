using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07老师或者学生登陆
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (rdoStudent.Checked || rdoTeacher.Checked)
            {

                string name = txtName.Text.Trim();
                string pwd = txtPwd.Text;
                if (rdoStudent.Checked)
                {
                    if (name == "student" && pwd == "student")
                    {
                        MessageBox.Show("学生登陆成功");
                    }
                    else
                    {
                        MessageBox.Show("登陆失败");
                        txtName.Clear();
                        txtPwd.Clear();
                        txtName.Focus();
                    }
                }
                else//选择的是老师
                {
                    if (name == "teacher" && pwd == "teacher")
                    {
                        MessageBox.Show("老师登陆成功");
                    }
                    else
                    {
                        MessageBox.Show("登陆失败");
                        txtName.Clear();
                        txtPwd.Clear();
                        txtName.Focus();
                    }
                }
            }
            else//都没有选中
            {
                MessageBox.Show("请首先选择登陆身份");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
