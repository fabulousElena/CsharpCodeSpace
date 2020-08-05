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

        private void button1_Click(object sender, EventArgs e)
        {
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
    }
}
