using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _06使用Winform应用程序模拟事件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PlayMusic p = new PlayMusic("忐忑");//创建对象 开始播放音乐
            p.Del += Test;//注册事件
            p.PlaySongs();//开始播放音乐
        }


        //事件要执行的函数
        void Test()
        {
            Console.WriteLine("播放完成了！！！！");
        }
    }
}
