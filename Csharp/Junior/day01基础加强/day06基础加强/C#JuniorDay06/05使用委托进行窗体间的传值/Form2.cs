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

    public delegate  void DelTest(string str);
    public partial class Form2 : Form
    {
        private DelTest _del;//存储Form1传送过来的函数
        public Form2(DelTest del)
        {
            this._del = del;
            InitializeComponent();
        }  

        private void button1_Click(object sender, EventArgs e)
        {
            this._del(textBox1.Text.Trim());
        }
    }
}
