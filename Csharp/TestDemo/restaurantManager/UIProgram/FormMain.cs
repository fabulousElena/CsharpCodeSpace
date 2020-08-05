using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIProgram
{
    public partial class FormMain : Form
    {
        string userType;
        public FormMain(string s)
        {
            userType = s;

            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            if (userType == "生化人")
            {
                menuManagerInfo.Visible = false;
            }
        }

        private void menuQuit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void menuManagerInfo_Click(object sender, EventArgs e)
        {
            FormManagerInfo fmi = FormManagerInfo.OneCreate();
            fmi.Focus();
            fmi.Show();
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {

            FormLoginIn fl = new FormLoginIn();
            fl.Show();
            //System.Environment.Exit(0);
        }

        private void menuMemberInfo_Click(object sender, EventArgs e)
        {
            FormMember fm = FormMember.CreateForm();
            fm.Show();
            fm.Focus();
        }
    }
}
