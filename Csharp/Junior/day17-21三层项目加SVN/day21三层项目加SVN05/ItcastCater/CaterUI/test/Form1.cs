using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaterUI.test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //在类中的字符，如果没有明确初始化，会在构造函数中自动初始化
        //自动初始化：根据变量的类型赋初值
        //如果是int则值为0，如果是bool则值为false,
        //如果是引用类型，则初始化值为null
        private int a;
        private string name;

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = a.ToString();


            Form2 form2=new Form2();
            DialogResult result = form2.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = "1";
            }
        }

        private void SetTxt()
        {
            textBox1.Text = "2";
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.myDelegate += SetTxt;
            //f2.myDelegate();//不安全性，允许外界访问，但是不允许调用
            f2.Show();//以这种方式打开，主要是为了演示不用返回值的效果
        }
    }
}
