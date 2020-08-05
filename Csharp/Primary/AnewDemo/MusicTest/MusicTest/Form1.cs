using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicTest
{
    public partial class Form1 : Form
    {

        Sunisoft.IrisSkin.SkinEngine SkinEngine = new Sunisoft.IrisSkin.SkinEngine();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MusicForm mf = new MusicForm();
            mf.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SkinEngine.SkinFile = "MacOS.ssk";
            SkinEngine.Active = true;
        }
    }
}
