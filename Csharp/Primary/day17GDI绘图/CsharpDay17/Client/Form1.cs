using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Socket socket;
        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPAddress ip = IPAddress.Parse(txtServer.Text);
                IPEndPoint point = new IPEndPoint(ip, Convert.ToInt32(txtPort.Text));

                socket.Connect(point);
                ShowMsg("连接成功");

                Thread th = new Thread(Rec);
                th.IsBackground = true;
                th.Start();
            }
            catch
            { }
        }


        void Rec()
        {
            while (true)
            {
                try
                {
                    byte[] buffer = new byte[1024 * 1024 * 3];
                    int r = socket.Receive(buffer);
                    if (buffer[0] == 0)
                    {
                        string s = Encoding.UTF8.GetString(buffer, 1, r-1);
                        ShowMsg(s);
                    }
                    else if (buffer[0] == 1)
                    {
                        SaveFileDialog sfd = new SaveFileDialog();
                        sfd.Filter = "所有文件|*.*";
                        sfd.ShowDialog(this);
                        string path = sfd.FileName;
                        using (FileStream fsWrite = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
                        {
                            fsWrite.Write(buffer, 1, r - 1);
                        }
                        MessageBox.Show("保存成功");
                    }
                    else
                    {
                        ZD();
                    }
                }
                catch
                { 
                    
                }
            }
        }

        void ZD()
        {
            for (int i = 0; i < 500; i++)
            {
                this.Location = new Point(200, 200);
                this.Location = new Point(210, 210);
            }
        }


        void ShowMsg(string str)
        {
            txtLog.AppendText(str + "\r\n");
        }


        /// <summary>
        /// 给服务器发送消息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSend_Click(object sender, EventArgs e)
        {
            byte[] buffer = Encoding.UTF8.GetBytes(txtMsg.Text);
            socket.Send(buffer);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }
    }
}
