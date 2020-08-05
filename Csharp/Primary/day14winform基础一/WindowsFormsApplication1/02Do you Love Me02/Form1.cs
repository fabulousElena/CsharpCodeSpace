using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02Do_you_Love_Me02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender">触发事件的对象</param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {

            MessageBox.Show("you pressed the button");
            Form2 frm2 = new Form2();
            frm2.Show();
        }
    }
}
