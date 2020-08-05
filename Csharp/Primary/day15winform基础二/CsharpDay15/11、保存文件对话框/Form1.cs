using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_保存文件对话框
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "请选择要保存的路径";
            sfd.InitialDirectory = @"C:\Users\SpringRain\Desktop";
            sfd.Filter = "文本文件|*.txt|所有文件|*.*";
            sfd.ShowDialog();
            //获得保存文件的路径
            string path = sfd.FileName;
            if (path == "")
            {
                return;
            }
            using (FileStream fsWrite = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
            {
                byte[] buffer = Encoding.Default.GetBytes(textBox1.Text);
                fsWrite.Write(buffer, 0, buffer.Length);
            }
            MessageBox.Show("保存成功");

        }
    }
}
