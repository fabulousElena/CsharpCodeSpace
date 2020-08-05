using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _04单例设计模式
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = Form2.GetSingle();//new Form2();
            frm2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (SingleObject.GetSingle().FrmThree == null)
            {
                SingleObject.GetSingle().FrmThree = new Form3();
            }
            SingleObject.GetSingle().FrmThree.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (SingleObject.GetSingle().FrmFour == null)
            {
                SingleObject.GetSingle().FrmFour = new Form4();
            }
           
            SingleObject.GetSingle().FrmFour.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (SingleObject.GetSingle().FrmFive == null)
            {
                SingleObject.GetSingle().FrmFive = new Form5();
            }
            SingleObject.GetSingle().FrmFive.Show();
        }
    }
}
