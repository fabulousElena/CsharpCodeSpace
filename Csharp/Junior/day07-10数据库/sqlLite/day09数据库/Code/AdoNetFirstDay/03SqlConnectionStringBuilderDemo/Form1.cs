using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03SqlConnectionStringBuilderDemo
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();

            SqlConnectionStringBuilder  scsb =new SqlConnectionStringBuilder();
            scsb.UserID = "sa";
            scsb.DataSource = ".";

            this.propGrid4ConString.SelectedObject = scsb;
        }

        private void btnGetString_Click(object sender, EventArgs e)
        {
            string str = this.propGrid4ConString.SelectedObject.ToString();
            Clipboard.Clear();
            Clipboard.SetText(str);
            MessageBox.Show(str);
        }
    }
}
