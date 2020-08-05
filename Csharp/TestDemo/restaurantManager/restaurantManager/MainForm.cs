using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace restaurantManager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;




            Thread th = new Thread(ShowTable);
            th.IsBackground = true;
            th.Start();
        }

        void ShowTable()
        {
            MySqlCommand mcmd = MySQLHelper.ExcuteQuery("select * from mytable");
            dg1.DataSource = MySQLHelper.ReturnTable(mcmd).Tables[0];

        }
    }
}
