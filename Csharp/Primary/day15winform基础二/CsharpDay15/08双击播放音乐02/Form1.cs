using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Un4seen.Bass;

namespace _08双击播放音乐02
{


    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }


        string[] strMusic = Directory.GetFiles(@"E:\Study\课程\temp\music");
        string musicName = null;
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < strMusic.Length; i++)
            {
                musicName = Path.GetFileName(strMusic[i]);
                listBox1.Items.Add(musicName);
            }

        }




        public static int playSecond = 10;
        Stopwatch sw = new Stopwatch();
        int tempSeconds = 0;
        int stream = -1;
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            //SoundPlayer sd = new SoundPlayer();
            //sd.SoundLocation = strMusic[listBox1.SelectedIndex];
            //sd.Play();

            //Bass.BASS_Stop();
            //Bass.BASS_Start();
            
            
            

            Bass.BASS_ChannelStop(stream);
            Bass.BASS_StreamFree(stream);
            Bass.BASS_Stop();
            Bass.BASS_Free();
            Bass.BASS_Start();
            
            BassNet.Registration("2636485450@qq.com", "2X122636170022");
            Bass.BASS_Init(-1, 44100, BASSInit.BASS_DEVICE_CPSPEAKERS, IntPtr.Zero);

            //stream = Bass.BASS_StreamCreateURL("", 0, BASSFlag.BASS_SAMPLE_FLOAT, null, IntPtr.Zero);

            stream = Bass.BASS_StreamCreateFile(strMusic[listBox1.SelectedIndex], 0L, 0L, BASSFlag.BASS_STREAM_AUTOFREE);
            if (stream != 0)
            {
                Bass.BASS_ChannelPlay(stream, false);
                
            }

            double playSecond = Bass.BASS_ChannelBytes2Seconds(stream, Bass.BASS_ChannelGetLength(stream));
            int secondsthis = Convert.ToInt32(playSecond);
            tempSeconds = secondsthis;
            //int miniteThis = secondsthis / 60;
            //int secondsLasted = secondsthis - miniteThis * 60;

            //if (miniteThis >9)
            //{
            //    label1.Text = miniteThis.ToString() + ":" + secondsLasted.ToString();
            //}
            //else
            //{
            //    label1.Text = "0" + miniteThis.ToString() + ":" + secondsLasted.ToString();
            //}

            label1.Text = TimeSpan.FromSeconds(secondsthis).ToString().Substring(3);


            //progressBar1.Value = TimeSpan.FromSeconds(seconds).ToString() ;



            sw.Reset();
            sw.Start();




        }

        public TimeSpan Position
        {
            get
            {
                double seconds = Bass.BASS_ChannelBytes2Seconds(stream, Bass.BASS_ChannelGetPosition(stream));
                return TimeSpan.FromSeconds(seconds);
            }
            set => Bass.BASS_ChannelSetPosition(stream, value.TotalSeconds);
        }


        string[] sr = { "100" ,"0"};

        private void timer1_Tick(object sender, EventArgs e)
        {
            //button1.Text = (dt2.Second - playSecond).ToString();
            label2.Text = sw.Elapsed.ToString().Substring(3);
            double i = Convert.ToDouble(sw.ElapsedMilliseconds) / 1000;
            float indexDot = Convert.ToSingle((i / tempSeconds) * 10000);
            sr = indexDot.ToString().Split('.');

            if (i!=0 && (Convert.ToInt32(sr[0]) / 10)<1001)
            {
                progressBar1.Maximum = 1000;
                progressBar1.Value = Convert.ToInt32(sr[0]) / 10;
                
            }
            
            //{

            //}
            //else
            //{

            //    button1.Text = indexDot.ToString().Substring(indexDot.ToString().IndexOf('.')) +"--" + indexDot.ToString();
            //}



        }
    }
}
