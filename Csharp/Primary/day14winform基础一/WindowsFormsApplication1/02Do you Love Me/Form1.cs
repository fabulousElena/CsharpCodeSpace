using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02Do_you_Love_Me
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        /// <summary>
        /// 当鼠标进入按钮的可见部分的时候，给按钮一个新的坐标
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUnLove_MouseEnter(object sender, EventArgs e)
        {
            //给按钮一个新的坐标
            //这个按钮活动的最大宽度就是 窗体的宽度减去按钮的宽度
            int x = this.ClientSize.Width - btnUnLove.Width;
            int y = this.ClientSize.Height - btnUnLove.Height;

            Random r = new Random();
            //要给按钮一个随机的坐标
            btnUnLove.Location = new Point(r.Next(0, x + 1), r.Next(0, y + 1));
        }

        private void btnLove_Click(object sender, EventArgs e)
        {
            MessageBox.Show("我也爱你哟思密达");
            this.Close();//关闭主窗体
        }

        private void btnUnLove_Click(object sender, EventArgs e)
        {
            MessageBox.Show("还是被你这个屌丝点到了");
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
