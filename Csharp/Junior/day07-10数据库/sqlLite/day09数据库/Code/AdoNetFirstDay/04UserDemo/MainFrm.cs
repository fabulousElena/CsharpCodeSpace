using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04UserDemo
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        private void btnOpenUserRegistFrm_Click(object sender, EventArgs e)
        {
            UserRegistFrm frm =new UserRegistFrm();
            frm.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginFrm frm =new LoginFrm();
            frm.Show();
        }

        private void btnOpenLoginFrm2_Click(object sender, EventArgs e)
        {
            UserLoginFrm frm =new UserLoginFrm();
            frm.Show();
        }
    }
}
