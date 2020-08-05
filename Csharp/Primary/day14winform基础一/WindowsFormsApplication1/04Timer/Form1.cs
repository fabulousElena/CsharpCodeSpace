using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //MessageBox.Show("你中病毒啦~~~！！！关不掉了吧");

            //abcde
            label1.Text = label1.Text.Substring(1) + label1.Text.Substring(0, 1);
        }



        /// <summary>
        /// 每隔一秒钟就把当前的时间赋值给label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer2_Tick(object sender, EventArgs e)
        {
            lblTme.Text = DateTime.Now.ToString();
            //15:32分播放音乐叫我起床
            if (DateTime.Now.Hour == 15 && DateTime.Now.Minute == 34 && DateTime.Now.Second == 50)
            { 
                //播放音乐
                SoundPlayer sp = new SoundPlayer();
                sp.SoundLocation = @"C:\Users\SpringRain\Desktop\1.wav";
                sp.Play();
            }
        }


        /// <summary>
        /// 当窗体加载的时候 将当前系统的时间赋值给我的Label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            lblTme.Text = DateTime.Now.ToString();
        }
    }
}
