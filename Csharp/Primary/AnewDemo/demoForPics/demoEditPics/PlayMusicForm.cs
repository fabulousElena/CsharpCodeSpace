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
using Un4seen.Bass;

namespace demoEditPics
{
    public partial class PlayMusicForm : Form
    {
        public PlayMusicForm()
        {
            InitializeComponent();
        }
        static int musicIndex = 0;
        static int picsIndex = 0;
        static int lyricIndex = 0;
        /// <summary>
        /// 判断获得音乐的后缀 用来区分音乐 歌词 和专辑图片
        /// </summary>
        public static void CherkFileType()
        {
            string[] tempFilePath = Directory.GetFiles(folderPath);
            List<string> musicFilePath = new List<string>();
            List<string> picsFilePath = new List<string>();
            List<string> lyricFilePath = new List<string>();
            int musicIndex = 0;
            for (int i = 0; i < tempFilePath.Length; i++)
            {
                if (tempFilePath[i].EndsWith(".mp3") || tempFilePath[i].EndsWith(".flac") || tempFilePath[i].EndsWith(".wav"))
                {
                    musicFilePath.Add(tempFilePath[i]);
                    musicIndex++;
                }
                else if (tempFilePath[i].EndsWith(".lyc"))
                {
                    lyricFilePath.Add(tempFilePath[i]);
                    lyricIndex++;
                }
                else if (tempFilePath[i].EndsWith(".jpg") || tempFilePath[i].EndsWith(".png"))
                {
                    picsFilePath.Add(tempFilePath[i]);
                    picsIndex++;
                }
            }

            musicNames = musicFilePath.ToArray();
            picsNames = picsFilePath.ToArray();
            lyricNames = lyricFilePath.ToArray();
        }
        //= Directory.GetFiles(@"E:\Study\课程\temp\music");
        static string[] musicNames = new string[musicIndex];
        static string[] picsNames = new string[picsIndex];
        static string[] lyricNames = new string[lyricIndex];
        private void PlayMusicForm_Load(object sender, EventArgs e)
        {
            //pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            //pictureBox1.Image = Image.FromFile(@"C:\Users\Administrator\Music\网易云歌单\RUN!!\Hop - Azis.jpg");

            //PlayMusicForm.CherkFileType();

            //for (int i = 0; i < musicNames.Length; i++)
            //{
            //    listBox1.Items.Add((i + 1) + ": " + Path.GetFileName(musicNames[i]));
            //}

           

        }
        static int stream;
        /// <summary>
        /// 双击播放音乐
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            if (listBox1.Items.Count == 0)
            {
                return;
            }

            //加载专辑图片
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            string s23 = folderPath + "\\" + Path.GetFileNameWithoutExtension(musicNames[listBox1.SelectedIndex]) + ".jpg";

            if (File.Exists(s23))
            {
                pictureBox1.Image = Image.FromFile(s23);
            }
            else
            {
                pictureBox1.Image = Image.FromFile("default.png");
            }

            //MessageBox.Show(s23 + Path.GetFileNameWithoutExtension(musicNames[listBox1.SelectedIndex]) + ".jpg");



            BassNet.Registration("2636485450@qq.com", "2X122636170022");
            Bass.BASS_Init(-1, 44100, BASSInit.BASS_DEVICE_CPSPEAKERS, IntPtr.Zero);
            stream = Bass.BASS_StreamCreateFile(musicNames[listBox1.SelectedIndex], 0L, 0L, BASSFlag.BASS_MUSIC_LOOP);

            Bass.BASS_ChannelStop(stream);
            Bass.BASS_StreamFree(stream);
            Bass.BASS_Stop();
            Bass.BASS_Free();
            Bass.BASS_Start();

            BassNet.Registration("2636485450@qq.com", "2X122636170022");
            Bass.BASS_Init(-1, 44100, BASSInit.BASS_DEVICE_CPSPEAKERS, IntPtr.Zero);
            stream = Bass.BASS_StreamCreateFile(musicNames[listBox1.SelectedIndex], 0L, 0L, BASSFlag.BASS_MUSIC_LOOP);
            if (stream != 0)
            {
                Bass.BASS_ChannelPlay(stream, true);

            }
            else if (stream == 0)
            {
                Bass.BASS_ChannelPlay(stream, true);
            }



        }
        /// <summary>
        /// 播放或者暂停按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_MouseClick(object sender, MouseEventArgs e)
        {

            if (button1.Text.Equals("暂停"))
            {
                Bass.BASS_ChannelPause(stream);
                button1.Text = "播放";
            }
            else if (button1.Text.Equals("播放"))
            {
                Bass.BASS_ChannelPlay(stream, false);
                button1.Text = "暂停";
            }
        }


        static string folderPath = @"C:\";

        /// <summary>
        /// 打开文件夹
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dilog = new FolderBrowserDialog();
            DialogResult dr = dilog.ShowDialog();
            dilog.Description = "请选择文件夹";
            if (dr == DialogResult.OK || dr == DialogResult.Yes)
            {
                folderPath = dilog.SelectedPath;
            }
            else
            {
                folderPath = @"C:\";
            }





            PlayMusicForm.CherkFileType();
            listBox1.Items.Clear();
            for (int i = 0; i < musicNames.Length; i++)
            {
                listBox1.Items.Add((i + 1) + ": " + Path.GetFileName(musicNames[i]));
            }
        }
    }
}
