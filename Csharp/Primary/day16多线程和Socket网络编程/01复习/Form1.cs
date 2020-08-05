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
namespace _01复习
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //用来存储音乐文件的全路径
        List<string> listSongs = new List<string>();
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "请选择音乐文件";
            ofd.InitialDirectory = @"C:\Users\SpringRain\Desktop\Music";
            ofd.Multiselect = true;
            ofd.Filter = "音乐文件|*.wav|所有文件|*.*";
            ofd.ShowDialog();
            //获得我们在文件夹中选择所有文件的全路径
            string[] path = ofd.FileNames;
            for (int i = 0; i < path.Length; i++)
            {
                //将音乐文件的文件名加载到ListBox中
                listBox1.Items.Add(Path.GetFileName(path[i]));
                //将音乐文件的全路径存储到泛型集合中
                listSongs.Add(path[i]);
            }
        }

         
        /// <summary>
        /// 实现双击播放
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        SoundPlayer sp = new SoundPlayer();
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
           
            sp.SoundLocation=listSongs[listBox1.SelectedIndex];
            sp.Play();
        }
        /// <summary>
        /// 点击下一曲
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            //获得当前选中歌曲的索引
            int index = listBox1.SelectedIndex;
            index++;
            if (index == listBox1.Items.Count)
            {
                index = 0;
            }
            //将改变后的索引重新的赋值给我当前选中项的索引
            listBox1.SelectedIndex = index;
            sp.SoundLocation = listSongs[index];
            sp.Play();
        }


        /// <summary>
        /// 点击上一曲
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            index--;
            if (index < 0)
            {
                index = listBox1.Items.Count-1;
            }
            //将重新改变后的索引重新的赋值给当前选中项
            listBox1.SelectedIndex = index;
            sp.SoundLocation = listSongs[index];
            sp.Play();
        }
    }
}
