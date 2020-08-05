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

namespace 播放器项目
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            musicPlayer.Ctlcontrols.play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            musicPlayer.Ctlcontrols.pause();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            musicPlayer.Ctlcontrols.stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //在程序加载的时候 取消播放器的自动播放功能
            musicPlayer.settings.autoStart = false;
            // musicPlayer.URL = @"C:\Users\SpringRain\Desktop\NewMusic\倔强.mp3";
            label1.Image = Image.FromFile(@"C:\Users\SpringRain\Desktop\放音.jpg");
        }
        /// <summary>
        /// 播放或者暂停
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        bool b = true;
        private void btnPlayorPause_Click(object sender, EventArgs e)
        {
            if (btnPlayorPause.Text == "播放")
            {
                if (b)
                {
                    //获得选中的歌曲  让音乐从头播放
                    musicPlayer.URL = listPath[listBox1.SelectedIndex];
                }
                musicPlayer.Ctlcontrols.play();
                btnPlayorPause.Text = "暂停";
            }
            else if (btnPlayorPause.Text == "暂停")
            {
                musicPlayer.Ctlcontrols.pause();
                btnPlayorPause.Text = "播放";
                b = false;
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            musicPlayer.Ctlcontrols.stop();
        }


        //存储音乐文件的全路径
        List<string> listPath = new List<string>();

        /// <summary>
        /// 打开对话框 选择音乐
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"F:\老赵生活\music";
            ofd.Filter = "音乐文件|*.wav|MP3文件|*.mp3|所有文件|*.*";
            ofd.Title = "请选择音乐文件哟亲o(^▽^)o";
            ofd.Multiselect = true;
            ofd.ShowDialog();

            //获得在文本框中选择文件的全路径
            string[] path = ofd.FileNames;
            for (int i = 0; i < path.Length; i++)
            {
                //将音乐文件的全路径存储到泛型集合中
                listPath.Add(path[i]);
                //将音乐文件的文件名存储到ListBox中
                listBox1.Items.Add(Path.GetFileName(path[i]));
            }
        }


        /// <summary>
        /// 双击播放对应的音乐
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("请首先选择音乐文件");
                return;
            }
            try
            {
                musicPlayer.URL = listPath[listBox1.SelectedIndex];
                musicPlayer.Ctlcontrols.play();
                btnPlayorPause.Text = "暂停";
                // lblInformation.Text = musicPlayer.currentMedia.duration.ToString();
                IsExistLrc(listPath[listBox1.SelectedIndex]);

            }
            catch { }
        }


        /// <summary>
        /// 点击下一曲
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, EventArgs e)
        {
            //获得当前选中项的索引
            int index = listBox1.SelectedIndex;

            //清空所有选中项的索引
            listBox1.SelectedIndices.Clear();
            index++;
            if (index == listBox1.Items.Count)
            {
                index = 0;
            }
            //将改变后的索引重新的赋值给当前选中项的索引
            listBox1.SelectedIndex = index;
            musicPlayer.URL = listPath[index];
            musicPlayer.Ctlcontrols.play();
        }


        /// <summary>
        /// 点击上一曲
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            listBox1.SelectedIndices.Clear();

            index--;
            if (index < 0)
            {
                index = listBox1.Items.Count - 1;
            }
            listBox1.SelectedIndex = index;

            musicPlayer.URL = listPath[index];
            musicPlayer.Ctlcontrols.play();

        }


        /// <summary>
        /// 点击删除 选中项
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //先删列表还是先删集合？


            //首先获得要删除的歌曲的数量
            int count = listBox1.SelectedItems.Count;
            for (int i = 0; i < count; i++)
            {
                //先删集合
                listPath.RemoveAt(listBox1.SelectedIndex);
                //再删列表
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);

            }

        }


        /// <summary>
        /// 点击放音或者静音
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label1_Click(object sender, EventArgs e)
        {
            if (label1.Tag.ToString() == "1")
            {
                //目的：让你静音
                musicPlayer.settings.mute = true;
                //显示静音的图片
                label1.Image = Image.FromFile(@"C:\Users\SpringRain\Desktop\静音.jpg");
                label1.Tag = "2";

            }
            else if (label1.Tag.ToString() == "2")
            {
                //放音
                musicPlayer.settings.mute = false;
                //显示放音的图片
                label1.Image = Image.FromFile(@"C:\Users\SpringRain\Desktop\放音.jpg");
                label1.Tag = "1";
            }
        }


        /// <summary>
        /// 放大音量
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button7_Click(object sender, EventArgs e)
        {
            musicPlayer.settings.volume += 5;
            // MessageBox.Show(musicPlayer.settings.volume.ToString());
        }


        /// <summary>
        /// 减小声音
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button8_Click(object sender, EventArgs e)
        {
            musicPlayer.settings.volume -= 5;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //如果播放器的状态等于正在播放中

            if (musicPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                lblInformation.Text = musicPlayer.currentMedia.duration.ToString() + "\r\n" + musicPlayer.currentMedia.durationString + "\r\n" + musicPlayer.Ctlcontrols.currentPosition.ToString() + "\r\n" + musicPlayer.Ctlcontrols.currentPositionString;
            }

            #region 方法1
            //if (musicPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            //{
            //    lblInformation.Text = musicPlayer.currentMedia.duration.ToString() + "\r\n" + musicPlayer.currentMedia.durationString + "\r\n" + musicPlayer.Ctlcontrols.currentPosition.ToString() + "\r\n" + musicPlayer.Ctlcontrols.currentPositionString;

            //    double d1 = double.Parse(musicPlayer.currentMedia.duration.ToString());

            //    double d2 = double.Parse(musicPlayer.Ctlcontrols.currentPosition.ToString()) + 1;

            //    if (d1 <= d2)
            //    {
            //        //获得当前选中项的索引
            //        int index = listBox1.SelectedIndex;

            //        //清空所有选中项的索引
            //        listBox1.SelectedIndices.Clear();
            //        index++;
            //        if (index == listBox1.Items.Count)
            //        {
            //            index = 0;
            //        }
            //        //将改变后的索引重新的赋值给当前选中项的索引
            //        listBox1.SelectedIndex = index;
            //        musicPlayer.URL = listPath[index];
            //        musicPlayer.Ctlcontrols.play();
            //    } 


            //  }
            #endregion
            //如果歌曲当前的播放时间等于歌曲的总时间 则下一曲
            //if (musicPlayer.playState == WMPLib.WMPPlayState.wmppsMediaEnded)
            //{
            //    //获得当前选中项的索引
            //    int index = listBox1.SelectedIndex;

            //    //清空所有选中项的索引
            //    listBox1.SelectedIndices.Clear();
            //    index++;
            //    if (index == listBox1.Items.Count)
            //    {
            //        index = 0;
            //    }
            //    //将改变后的索引重新的赋值给当前选中项的索引
            //    listBox1.SelectedIndex = index;
            //    musicPlayer.URL = listPath[index];

            //}
            //if (musicPlayer.playState == WMPLib.WMPPlayState.wmppsReady)
            //{
            //    musicPlayer.Ctlcontrols.play();
            //}




        }


        /// <summary>
        /// 当播放器状态发生改变的时候 我输出当前播放器的播放状态
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void musicPlayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            //  MessageBox.Show(musicPlayer.playState.ToString());
            if (musicPlayer.playState == WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                //获得当前选中项的索引
                int index = listBox1.SelectedIndex;

                //清空所有选中项的索引
                listBox1.SelectedIndices.Clear();
                index++;
                if (index == listBox1.Items.Count)
                {
                    index = 0;
                }
                //将改变后的索引重新的赋值给当前选中项的索引
                listBox1.SelectedIndex = index;
                musicPlayer.URL = listPath[index];

            }
            if (musicPlayer.playState == WMPLib.WMPPlayState.wmppsReady)
            {
                try
                {
                    musicPlayer.Ctlcontrols.play();
                }
                catch { }
            }


        }



        //开始做歌词
        void IsExistLrc(string songPath)
        {
            //清空两个集合的内容

            songPath += ".lrc";
            if (File.Exists(songPath))
            {
                //读取歌词文件
                string[] lrcText = File.ReadAllLines(songPath,Encoding.Default);
                //格式化歌词
                FormatLrc(lrcText);
            }
            else//不存在歌词
            {
                label2.Text = "---------歌词未找到---------";
            }

        }
        //存储时间
        List<double> listTime = new List<double>();
        //存储歌词
        List<string> listLrcText = new List<string>();


        /// <summary>
        /// 格式化歌词
        /// </summary>
        /// <param name="lrcText"></param>
        void FormatLrc(string[] lrcText)
        {
            for (int i = 0; i < lrcText.Length; i++)
            {
                //[00:15.57]当我和世界不一样
                string[] lrcTemp = lrcText[i].Split(new char[] { '[', ']' }, StringSplitOptions.RemoveEmptyEntries);
                //00:15.57   lrcTemp[0]
                //当我和世界不一样 lrcTemp[1]
                string[] lrcNewTemp = lrcTemp[0].Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
                //00 lrcNewTemp[0]
                //15.57 lrcNewTemp[1]
                double time = double.Parse(lrcNewTemp[0]) * 60 + double.Parse(lrcNewTemp[1]);
                //把截取出来的时间加到泛型集合中
                listTime.Add(time);
                //把这个时间所对应的歌词存储到泛型集合中
                listLrcText.Add(lrcTemp[1]);
            }
        }


        /// <summary>
        /// 播放歌词
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer2_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < listTime.Count; i++)
			{
                if (musicPlayer.Ctlcontrols.currentPosition >= listTime[i] && musicPlayer.Ctlcontrols.currentPosition < listTime[i + 1])
                {
                    label2.Text = listLrcText[i];
                }
			}
           
        }


    }
}
