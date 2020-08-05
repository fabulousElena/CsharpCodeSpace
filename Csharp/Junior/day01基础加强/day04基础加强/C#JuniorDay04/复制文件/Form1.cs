using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 复制文件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Title = "请选择要复制的文件";
            ofd.InitialDirectory = @"C:\Users\SpringRain\Desktop";
            ofd.Filter = "所有文件|*.*";
            ofd.ShowDialog();
            textBox1.Text = ofd.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "请选择要保存文件的路径";
            sfd.InitialDirectory = @"C:\Users\SpringRain\Desktop";
            sfd.Filter = "所有文件|*.*";
            sfd.ShowDialog();
            textBox2.Text = sfd.FileName;
            //先读取 再写入
            using (FileStream fsRead = new FileStream(textBox1.Text.Trim(), FileMode.OpenOrCreate, FileAccess.Read))
            {
                using (FileStream fsWrite = new FileStream(textBox2.Text.Trim(), FileMode.OpenOrCreate, FileAccess.Write))
                {
                    //设置进度条
                    progressBar1.Maximum = (int)fsRead.Length;

                    byte[] buffer = new byte[1024 * 1024 * 3];
                    while (true)
                    {
                        int r = fsRead.Read(buffer, 0, buffer.Length);
                        if (r == 0)
                        {
                            break;
                        }
                      
                        fsWrite.Write(buffer, 0, r);
                        progressBar1.Value = (int)fsWrite.Length;
                    }

                    MessageBox.Show("保存成功");

                }
            }


        }
    }
}
