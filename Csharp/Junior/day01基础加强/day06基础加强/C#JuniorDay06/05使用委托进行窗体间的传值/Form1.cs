using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _05使用委托进行窗体间的传值
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2(ShowText);
            frm2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //label1.Text = DataClass._text;
        }


        //将Form2传送过来的数据 赋值给Label
        void ShowText(string str)
        {
            label1.Text = str;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            //你骂我 我抽你
        }
    }
}
