using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProOperation;
using ProFactory;


namespace ProCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string tempItem;
        private void Form1_Load(object sender, EventArgs e)
        {
            //读取配置文件
            string[] config = File.ReadAllLines("Config.txt", Encoding.UTF8);

            foreach (string item in config)
            {
                //有几条数据，就创建几个按钮
                Button btn = new Button();
                btn.Size = new Size(335, 27);
                btn.Text = item;
                //flowLayoutPanel1.AutoScroll = true;
                flowLayoutPanel1.Controls.Add(btn);

                btn.Click += btn_Click;
                tempItem = item;
            }
        }

        void btn_Click(object sender, EventArgs e)
        {
            if ( textBox1.Text.Length == 0 || textBox2.Text.Length == 0)
            {
                return;
            }
            Button btn = sender as Button;
            int n1 = Convert.ToInt32(textBox1.Text);
            int n2 = Convert.ToInt32(textBox2.Text);

            //获得简单工厂提供的父类对象
            Operation oper = Factory.GetOperation(btn.Text, n1, n2);
            //判断对象是否为空
            if (oper == null)
            {
                return;
            }
            textBox3.Text = oper.GetResult().ToString();


            label1.Text = btn.Text;
        }
    }
}
