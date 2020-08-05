using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demoEditPics
{
    public partial class Form1 : Form
    {

        Sunisoft.IrisSkin.SkinEngine SkinEngine = new Sunisoft.IrisSkin.SkinEngine();
        public Form1()
        {
            InitializeComponent();
        }

        private void 加入图库ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sName = "CheckPixivPics.jar";
            try
            {
                Process proc = Process.Start(sName);
                if (proc != null)
                {
                    proc.WaitForExit();

                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        int whichPic = 0;


        private void pictureBox1_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {

        }
        string[] fileNames = Directory.GetFiles(@"F:\壁纸\总图库");


        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;

            SkinEngine.SkinFile = @"Skins\MacOS.ssk";
            SkinEngine.Active = true;

            if (fileNames.Length == 0)
            {
                MessageBox.Show("文件夹为空，请添加文件以后操作。");
                System.Environment.Exit(0);
            }
            f = new FileInfo(fileNames[whichPic]);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Image = Image.FromFile(fileNames[whichPic]);
            label8.Text = Path.GetFileName(fileNames[whichPic]);
            label9.Text = "图库剩余图片" + (fileNames.Length).ToString() + "张";

            label10.Text = countBytes(f.Length);


        }




        //string[] deleteFileNames = new string[1024*5];
        //int deleteIndex = 0;
        public static string s1 = @"F:\壁纸\风景";
        public static string s2 = @"F:\壁纸\女女";
        public static string s3 = @"F:\壁纸\肉肉";
        public static string s4 = @"F:\壁纸\腿腿";


        public string countBytes(long f)
        {


            return (f / 1024).ToString() + "KB";


        }

        FileInfo f;
        private void tabControl1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad3)
            {

                pictureBox1.Image.Dispose();
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

                if (whichPic == fileNames.Length - 1)
                {

                    whichPic = 0;
                    pictureBox1.Image = Image.FromFile(fileNames[whichPic]);
                    label8.Text = Path.GetFileName(fileNames[whichPic]);

                }
                else if (whichPic == 0)
                {
                    whichPic++;
                    pictureBox1.Image = Image.FromFile(fileNames[whichPic]);
                    label8.Text = Path.GetFileName(fileNames[whichPic]);
                }
                else
                {
                    whichPic++;
                    pictureBox1.Image = Image.FromFile(fileNames[whichPic]);
                    label8.Text = Path.GetFileName(fileNames[whichPic]);
                }

                f = new FileInfo(fileNames[whichPic]);
                label10.Text = countBytes(f.Length);

            }
            else if (e.KeyCode == Keys.NumPad1)
            {
                pictureBox1.Image.Dispose();
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                if (whichPic == 0)
                {
                    pictureBox1.Image = Image.FromFile(fileNames[whichPic]);
                    label8.Text = Path.GetFileName(fileNames[whichPic]);
                    MessageBox.Show("已经是第一张了~");

                }
                else
                {
                    whichPic--;
                    pictureBox1.Image = Image.FromFile(fileNames[whichPic]);
                    label8.Text = Path.GetFileName(fileNames[whichPic]);
                }


                f = new FileInfo(fileNames[whichPic]);
                label10.Text = countBytes(f.Length);



            }
            else if (e.KeyCode == Keys.W)
            {
                pictureBox1.Image.Dispose();
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

                string[] fileNames2 = Directory.GetFiles(@"F:\壁纸\总图库");


                if (whichPic == fileNames.Length - 1)
                {

                    whichPic = 0;
                    pictureBox1.Image = Image.FromFile(fileNames[whichPic]);
                    label8.Text = Path.GetFileName(fileNames[whichPic]);

                }
                else if (whichPic == 0)
                {
                    whichPic++;
                    pictureBox1.Image = Image.FromFile(fileNames[whichPic]);
                    label8.Text = Path.GetFileName(fileNames[whichPic]);
                }
                else
                {
                    whichPic++;
                    pictureBox1.Image = Image.FromFile(fileNames[whichPic]);
                    label8.Text = Path.GetFileName(fileNames[whichPic]);
                }

                if (fileNames2.Length == 1)
                {
                    MessageBox.Show("最后一张删除完成，准备退出程序。");
                    pictureBox1.Image.Dispose();
                    File.Delete(fileNames[0]);
                    System.Environment.Exit(0);
                }

                //File.Delete(fileNames[whichPic - 1]);
                string picName = Path.GetFileName(fileNames[whichPic - 1]);
                File.Move(@fileNames[whichPic - 1], @"F:\壁纸\风景\" + picName);
                label9.Text = "图库剩余图片" + (fileNames2.Length - 1).ToString() + "张";
                //label9.Text  = Setting.getPath;

                f = new FileInfo(fileNames[whichPic]);
                label10.Text = countBytes(f.Length);

            }
            else if (e.KeyCode == Keys.A)
            {
                pictureBox1.Image.Dispose();
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

                string[] fileNames2 = Directory.GetFiles(@"F:\壁纸\总图库");


                if (whichPic == fileNames.Length - 1)
                {

                    whichPic = 0;
                    pictureBox1.Image = Image.FromFile(fileNames[whichPic]);
                    label8.Text = Path.GetFileName(fileNames[whichPic]);

                }
                else if (whichPic == 0)
                {
                    whichPic++;
                    pictureBox1.Image = Image.FromFile(fileNames[whichPic]);
                    label8.Text = Path.GetFileName(fileNames[whichPic]);
                }
                else
                {
                    whichPic++;
                    pictureBox1.Image = Image.FromFile(fileNames[whichPic]);
                    label8.Text = Path.GetFileName(fileNames[whichPic]);
                }

                if (fileNames2.Length == 1)
                {
                    MessageBox.Show("最后一张删除完成，准备退出程序。");
                    pictureBox1.Image.Dispose();
                    File.Delete(fileNames[0]);
                    System.Environment.Exit(0);
                }

                //File.Delete(fileNames[whichPic - 1]);
                string picName = Path.GetFileName(fileNames[whichPic - 1]);
                File.Move(@fileNames[whichPic - 1], @"F:\壁纸\女女\" + picName);
                label9.Text = "图库剩余图片" + (fileNames2.Length - 1).ToString() + "张";

                f = new FileInfo(fileNames[whichPic]);
                label10.Text = countBytes(f.Length);
            }
            else if (e.KeyCode == Keys.S)
            {
                pictureBox1.Image.Dispose();
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

                string[] fileNames2 = Directory.GetFiles(@"F:\壁纸\总图库");


                if (whichPic == fileNames.Length - 1)
                {

                    whichPic = 0;
                    pictureBox1.Image = Image.FromFile(fileNames[whichPic]);
                    label8.Text = Path.GetFileName(fileNames[whichPic]);

                }
                else if (whichPic == 0)
                {
                    whichPic++;
                    pictureBox1.Image = Image.FromFile(fileNames[whichPic]);
                    label8.Text = Path.GetFileName(fileNames[whichPic]);
                }
                else
                {
                    whichPic++;
                    pictureBox1.Image = Image.FromFile(fileNames[whichPic]);
                    label8.Text = Path.GetFileName(fileNames[whichPic]);
                }

                if (fileNames2.Length == 1)
                {
                    MessageBox.Show("最后一张删除完成，准备退出程序。");
                    pictureBox1.Image.Dispose();
                    File.Delete(fileNames[0]);
                    System.Environment.Exit(0);
                }

                //File.Delete(fileNames[whichPic - 1]);
                string picName = Path.GetFileName(fileNames[whichPic - 1]);
                File.Move(@fileNames[whichPic - 1], @"F:\壁纸\肉肉\" + picName);
                label9.Text = "图库剩余图片" + (fileNames2.Length - 1).ToString() + "张";

                f = new FileInfo(fileNames[whichPic]);
                label10.Text = countBytes(f.Length);
            }
            else if (e.KeyCode == Keys.D)
            {
                pictureBox1.Image.Dispose();
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

                string[] fileNames2 = Directory.GetFiles(@"F:\壁纸\总图库");


                if (whichPic == fileNames.Length - 1)
                {

                    whichPic = 0;
                    pictureBox1.Image = Image.FromFile(fileNames[whichPic]);
                    label8.Text = Path.GetFileName(fileNames[whichPic]);

                }
                else if (whichPic == 0)
                {
                    whichPic++;
                    pictureBox1.Image = Image.FromFile(fileNames[whichPic]);
                    label8.Text = Path.GetFileName(fileNames[whichPic]);
                }
                else
                {
                    whichPic++;
                    pictureBox1.Image = Image.FromFile(fileNames[whichPic]);
                    label8.Text = Path.GetFileName(fileNames[whichPic]);
                }

                if (fileNames2.Length == 1)
                {
                    MessageBox.Show("最后一张删除完成，准备退出程序。");
                    pictureBox1.Image.Dispose();
                    File.Delete(fileNames[0]);
                    System.Environment.Exit(0);
                }

                //File.Delete(fileNames[whichPic - 1]);
                string picName = Path.GetFileName(fileNames[whichPic - 1]);
                File.Move(@fileNames[whichPic - 1], @"F:\壁纸\腿腿\" + picName);
                label9.Text = "图库剩余图片" + (fileNames2.Length - 1).ToString() + "张";

                f = new FileInfo(fileNames[whichPic]);
                label10.Text = countBytes(f.Length);
            }
            else if (e.KeyCode == Keys.R)
            {

                pictureBox1.Image.Dispose();
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

                string[] fileNames2 = Directory.GetFiles(@"F:\壁纸\总图库");


                if (whichPic == fileNames.Length - 1)
                {

                    whichPic = 0;
                    pictureBox1.Image = Image.FromFile(fileNames[whichPic]);
                    label8.Text = Path.GetFileName(fileNames[whichPic]);

                }
                else if (whichPic == 0)
                {
                    whichPic++;
                    pictureBox1.Image = Image.FromFile(fileNames[whichPic]);
                    label8.Text = Path.GetFileName(fileNames[whichPic]);
                }
                else
                {
                    whichPic++;
                    pictureBox1.Image = Image.FromFile(fileNames[whichPic]);
                    label8.Text = Path.GetFileName(fileNames[whichPic]);
                }

                if (fileNames2.Length == 1)
                {
                    MessageBox.Show("最后一张删除完成，准备退出程序。");
                    pictureBox1.Image.Dispose();
                    File.Delete(fileNames[0]);
                    System.Environment.Exit(0);
                }

                File.Delete(fileNames[whichPic - 1]);

                label9.Text = "图库剩余图片" + (fileNames2.Length - 1).ToString() + "张";

                f = new FileInfo(fileNames[whichPic]);
                label10.Text = countBytes(f.Length);
            }
        }

        /// <summary>
        /// 启动java
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            string sName = "CheckPixivPics.jar";
            try
            {
                Process proc = Process.Start(sName);
                if (proc != null)
                {
                    proc.WaitForExit();

                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, this.Text,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /// <summary>
        /// 获得歌曲路径
        /// </summary>
        string[] allFilePath;
        List<string> musicPath = new List<string>();
        //List<string> picName = new List<string>();
        //List<string> lyricName = new List<string>();
        List<string> musicName = new List<string>();
        /// <summary>
        /// 获得所有的元素  并分类
        /// </summary>
        void GetAllFiles()
        {

            allFilePath = Directory.GetFiles(fbSelectPath);
            for (int i = 0; i < allFilePath.Length; i++)
            {
                if (allFilePath[i].EndsWith(".mp3") || allFilePath[i].EndsWith(".flac") || allFilePath[i].EndsWith(".wav"))
                {
                    musicPath.Add(allFilePath[i]);
                    musicName.Add(Path.GetFileNameWithoutExtension(allFilePath[i]));
                    continue;
                }

            }

        }

        static string fbSelectPath = @"C:\Users\Administrator\Music\网易云歌单\RUN!!";
        /// <summary>
        /// 获得选择的路径，然后用集合收集里面所有的元素。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fb = new FolderBrowserDialog();
            if (fbSelectPath == "-1")
            {
                fb.Description = "打开文件夹";
                DialogResult dr = fb.ShowDialog();
                if ((DialogResult.Yes == dr) || (DialogResult.OK == dr))
                {
                    fbSelectPath = fb.SelectedPath;

                }
                else
                {
                    fbSelectPath = @"C:\";
                }


            }
            else
            {
                fb.SelectedPath = fbSelectPath;
                fb.ShowDialog();
            }

            GetAllFiles();
            listBox1.Items.AddRange(musicName.ToArray());

        }
        //歌词集合
        List<string> lyricList = new List<string>();
        /// <summary>
        /// 加载歌词
        /// </summary>
        void LoadingLyric()
        {
            //加载歌词
            string lycNameWithoutHou = musicPath[listBox1.SelectedIndex].Substring(0, musicPath[listBox1.SelectedIndex].LastIndexOf('.')) + ".lrc";
            string[] lyricText = File.ReadAllLines(lycNameWithoutHou);
            //双层循环比对歌词
            for (int i = 0; i < lyricText.Length; i++)
            {
                //判断字符串的长度  小于 时间戳直接进行下一次循环
                //判断如果不是以时间戳开头   直接进行下一次循环 /* && i != 0*/
                bool trigger = false;
                if (!lyricText[i].StartsWith("[0") || (lyricText[i].Length < 12))
                {
                    continue;
                }
                for (int j = i + 1; j + 1 < lyricText.Length; j++)
                {
                    if (!lyricText[j].StartsWith("[0") || (lyricText[j].Length < 12))
                    {
                        continue;
                    }

                    //如果两行的前十一个  时间相等  就把剩下的字符串相加  中间换行
                    if (lyricText[j].Substring(0, 11).Equals(lyricText[i].Substring(0, 11)))
                    {
                        lyricList.Add(lyricText[i].Substring(0, 11) + lyricText[i].Substring(11) + "\n" + lyricText[j].Substring(11) + "\n");                        //定义一个 trigger  显示是否已经找到  找到就是true  反之false
                        trigger = false;
                        break;
                    }
                    else if (!lyricText[j].Substring(0, 11).Equals(lyricText[i].Substring(0, 11)))
                    {
                        trigger = true;
                        continue;
                    }

                }
                if (trigger)
                {
                    lyricList.Add(lyricText[i].Substring(0, 11) + lyricText[i].Substring(11) + "\n");

                }
            }
            //添加歌词
            //foreach (var item in lyricList)
            //{
            //    richTextBox1.AppendText(item);
            //}
        }

        /// <summary>
        /// 双击listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        static Thread th;
        bool switchForLyric = false;
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            //如果没选中  双击无效果
            if (listBox1.SelectedIndex == -1)
            {
                return;
            }
            //打开图片
            string fileNameWithoutHou = musicPath[listBox1.SelectedIndex].Substring(0, musicPath[listBox1.SelectedIndex].LastIndexOf('.'));
            pictureBox2.Image = Image.FromFile(fileNameWithoutHou + ".jpg");
            //加载歌词方法
            lyricList.Clear();
            lyricDoubleSecond.Clear();
            LoadingLyric();
            //对xx进行timer监听  然后显示歌词

            //播放音乐
            Mplayer.URL = musicPath[listBox1.SelectedIndex];

            if (switchForLyric)
            {
                th.Abort();
            }

            th = new Thread(setLyric);
            th.IsBackground = true;
            th.Start();
        }

        void setLyric()
        {
            BiDuiLyric(lyricList);
            switchForLyric = true;

            //label13.Text = lyricList[i-4];
            //label14.Text = lyricList[i-3];
            //label15.Text = lyricList[i-2];
            //label16.Text = lyricList[i-1];

            //label17.Text = lyricList[i];
            //label18.Text = lyricList[i+1];
            //label19.Text = lyricList[i+2];
            //label20.Text = lyricList[i+3];
            //label21.Text = lyricList[i+4];



            while (true)
            {
                Thread.Sleep(300);
                for (int i = 0; i < lyricDoubleSecond.Count; i++)
                {
                    if (i+1 >= lyricDoubleSecond.Count)
                    {
                        break;
                    }
                    if (Mplayer.Ctlcontrols.currentPosition >= lyricDoubleSecond[i]  && Mplayer.Ctlcontrols.currentPosition < lyricDoubleSecond[i + 1])
                    {
                        

                        if (i-4>=0  && i+4< lyricDoubleSecond.Count)
                        {
                            label13.Text = lyricList[i - 4];
                            label14.Text = lyricList[i - 3];
                            label15.Text = lyricList[i - 2];
                            label16.Text = lyricList[i - 1];

                            label17.Text = lyricList[i];
                            label18.Text = lyricList[i + 1];
                            label19.Text = lyricList[i + 2];
                            label20.Text = lyricList[i + 3];
                            label21.Text = lyricList[i + 4];
                        }
                        else if (i == 0)
                        {
                            label13.Text = "";
                            label14.Text = "";
                            label15.Text = "";
                            label16.Text = "";

                            label17.Text = lyricList[i];
                            label18.Text = lyricList[i + 1];
                            label19.Text = lyricList[i + 2];
                            label20.Text = lyricList[i + 3];
                            label21.Text = lyricList[i + 4];
                        }
                        else if (i == 1)
                        {
                            label13.Text = "";
                            label14.Text = "";
                            label15.Text = "";
                            label16.Text = lyricList[i-1];

                            label17.Text = lyricList[i];
                            label18.Text = lyricList[i + 1];
                            label19.Text = lyricList[i + 2];
                            label20.Text = lyricList[i + 3];
                            label21.Text = lyricList[i + 4];
                        }
                        else if (i == 2)
                        {
                            label13.Text = "";
                            label14.Text = "";
                            label15.Text = lyricList[i - 2];
                            label16.Text = lyricList[i - 1];

                            label17.Text = lyricList[i];
                            label18.Text = lyricList[i + 1];
                            label19.Text = lyricList[i + 2];
                            label20.Text = lyricList[i + 3];
                            label21.Text = lyricList[i + 4];

                        }
                        else if (i == 3)
                        {
                            label13.Text = "";
                            label14.Text = lyricList[i - 3];
                            label15.Text = lyricList[i - 2];
                            label16.Text = lyricList[i - 1];

                            label17.Text = lyricList[i];
                            label18.Text = lyricList[i + 1];
                            label19.Text = lyricList[i + 2];
                            label20.Text = lyricList[i + 3];
                            label21.Text = lyricList[i + 4];
                        }
                        else if (i == 4)
                        {
                            label13.Text = lyricList[i - 4];
                            label14.Text = lyricList[i - 3];
                            label15.Text = lyricList[i - 2];
                            label16.Text = lyricList[i - 1];

                            label17.Text = lyricList[i];
                            label18.Text = lyricList[i + 1];
                            label19.Text = lyricList[i + 2];
                            label20.Text = lyricList[i + 3];
                            label21.Text = lyricList[i + 4];
                        }
                        else if (i == lyricDoubleSecond.Count -4)
                        {
                            label13.Text = lyricList[i - 4];
                            label14.Text = lyricList[i - 3];
                            label15.Text = lyricList[i - 2];
                            label16.Text = lyricList[i - 1];

                            label17.Text = lyricList[i];
                            label18.Text = lyricList[i + 1];
                            label19.Text = lyricList[i + 2];
                            label20.Text = lyricList[i + 3];
                            label21.Text = "";
                        }


                        //label17.Text = lyricList[i];
                        break;
                    }
                }
            }

        }


        List<double> lyricDoubleSecond = new List<double>();
        public void BiDuiLyric(List<string> list)
        {
            string tempS;
            string[] tempArray;
            string[] tempArray2;
            double minute;
            double second;
            for (int i = 0; i < list.Count; i++)
            {
                tempS = list[i].Substring(0, 10);
                tempArray = tempS.Split(new char[] { '[', ']' });
                tempArray2 = tempArray[1].Split(':');
                minute = Convert.ToDouble(tempArray2[0]);
                second = Convert.ToDouble(tempArray2[1]);
                lyricDoubleSecond.Add(minute * 60 + second); 
            }


            
        }
    }
}
