using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace CaterUI
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void menuQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            //将当前应用程序退出，而不仅是关闭当前窗体
            Application.Exit();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //判断登录进来的员工的级别，以确定是否显示menuManager图标
            int type = Convert.ToInt32(this.Tag);
            if (type == 1)
            {
                //经理
            }
            else
            {
                //店员,管理员菜单不需要显示
                menuManagerInfo.Visible = false;
            }
        }

        private void menuManagerInfo_Click(object sender, EventArgs e)
        {
            FormManagerInfo formManagerInfo = FormManagerInfo.Create();//new FormManagerInfo();
            formManagerInfo.Show();
            formManagerInfo.Focus();//将当前窗体获得焦点
            //如果是最小化的，则恢复到正常状态
            formManagerInfo.WindowState=FormWindowState.Normal;
        }
    }
}
