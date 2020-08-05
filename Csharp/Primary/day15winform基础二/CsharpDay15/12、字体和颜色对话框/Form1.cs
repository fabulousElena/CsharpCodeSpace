using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12_字体和颜色对话框
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        /// <summary>
        /// 字体对话框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            //字体
            FontDialog fd = new FontDialog();
            fd.ShowDialog();
            textBox1.Font = fd.Font;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //颜色
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            textBox1.ForeColor = cd.Color;
        }
    }
}
