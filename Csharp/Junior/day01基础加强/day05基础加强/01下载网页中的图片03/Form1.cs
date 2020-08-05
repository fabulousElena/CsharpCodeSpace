using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01下载网页中的图片03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            
            pb1.ImageLocation = @"https://huazhi-1301084657.cos.ap-guangzhou.myqcloud.com/wp-content/uploads/2020/07/Snipaste_2020-07-12_20-31-39.png";
        }
    }
}
