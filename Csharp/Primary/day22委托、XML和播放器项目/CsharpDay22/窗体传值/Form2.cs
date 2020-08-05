using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 窗体传值
{
    public delegate void DelStr(string s);
    public partial class Form2 : Form
    {
        public DelStr _del;
        public Form2(DelStr del)
        {
            this._del = del;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _del(textBox1.Text);
        }
    }
}
