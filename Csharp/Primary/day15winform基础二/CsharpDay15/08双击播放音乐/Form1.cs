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
using System.Media;
namespace _08双击播放音乐
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //存储音乐文件的全路径
        List<string> listSongs = new List<string>();
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] path = Directory.GetFiles(@"C:\Users\SpringRain\Desktop\Music", "*.wav");
            for (int i = 0; i < path.Length; i++)
            {
                string fileName = Path.GetFileName(path[i]);
                listBox1.Items.Add(fileName);
                //将音乐文件的全路径存到泛型集合中
                listSongs.Add(path[i]);
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation=listSongs[listBox1.SelectedIndex];
            sp.Play();
        }
    }
}
