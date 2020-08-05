using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }


        /// <summary>
        /// 关闭主窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
          
            ////需要获得当前主窗体的对象
            ////Form1 frm1 = new Form1();
            ////frm1.Close();
            //this.Close();


            Test._fr1Test.Close();

        }
    }
}
