using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 使用GDI绘制验证码
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); 
        }


        /// <summary>
        /// 点击更换验证码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            string str = null;
            for (int i = 0; i < 5; i++)
            {
                int rNumber = r.Next(0, 10);
                str += rNumber;
            }
            //  MessageBox.Show(str);
            //创建GDI对象
            Bitmap bmp = new Bitmap(150, 40);
            Graphics g = Graphics.FromImage(bmp);

            for (int i = 0; i < 5; i++)
            {
                Point p = new Point(i * 30, 0);
                string[] fonts = { "微软雅黑", "宋体", "黑体", "隶书", "仿宋" };
                Color[] colors = { Color.Yellow, Color.Blue, Color.Black, Color.Red, Color.Green };
                g.DrawString(str[i].ToString(), new Font(fonts[r.Next(0, 5)], 20, FontStyle.Bold), new SolidBrush(colors[r.Next(0, 5)]), p);
            }

            for (int i = 0; i < 20; i++)
            {
                Point p1=new Point(r.Next(0,bmp.Width),r.Next(0,bmp.Height));
                Point p2=new Point(r.Next(0,bmp.Width),r.Next(0,bmp.Height));
                g.DrawLine(new Pen(Brushes.Green), p1, p2);
            }

            for (int i = 0; i < 1500; i++)
            {
                Point p=new Point(r.Next(0,bmp.Width),r.Next(0,bmp.Height));
                bmp.SetPixel(p.X, p.Y, Color.Black);
            }

             
            //将图片镶嵌到PictureBox中
            pictureBox1.Image = bmp;
        }
    }
}
