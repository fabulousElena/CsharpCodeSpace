using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03TextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 当文本框中的内容发生改变的时候  将值赋值给Label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtWords_TextChanged(object sender, EventArgs e)
        {
            lblText.Text = txtWords.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblText_Click(object sender, EventArgs e)
        {

        }
    }
}
