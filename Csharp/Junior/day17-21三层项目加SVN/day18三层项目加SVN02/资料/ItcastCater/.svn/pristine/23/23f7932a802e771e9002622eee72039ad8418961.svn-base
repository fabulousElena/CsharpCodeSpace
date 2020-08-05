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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private DialogResult result = DialogResult.Cancel;

        private void button1_Click(object sender, EventArgs e)
        {
            result = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            result = DialogResult.Cancel;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = result;
        }
    }
}
