using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace _10实现照片的上一张下一张翻页效果
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //设置图片如何在PictureBox中显示
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Image = Image.FromFile(@"E:\Study\myGit\CsharpBasics\day14winform基础\WindowsFormsApplication1\09PictureBox\bin\Debug\Pics\1.jpg");
            //获得指定文件夹的所有文件的全路径
           
        }
        int i = 0;

        string[] path = Directory.GetFiles(@"E:\Study\myGit\CsharpBasics\day14winform基础\WindowsFormsApplication1\09PictureBox\bin\Debug\Pics");
        /// <summary>
        /// 点击更换下一张图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            
             i++;
            if (i == path.Length)
            {
                i = 0;
            }
            pictureBox1.Image = Image.FromFile(path[i]);
        }



        /// <summary>
        /// 点击上一张
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            i--;
            if (i < 0)
            {
                i = path.Length - 1;
            }
            pictureBox1.Image = Image.FromFile(path[i]);
        }
    }
}
