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

namespace Server

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                Socket socketWatch = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                //any可以监听所有的ip 可以用来在服务器端  
                //然后客户端连接的时候，就可以直接连接了
                IPAddress ip = IPAddress.Any;//IPAddress.Parse(txtServer.Text);

                IPEndPoint point = new IPEndPoint(ip, Convert.ToInt32(txtPort.Text));

                socketWatch.Bind(point);

                ShowMsg("监听成功" + ip.ToString());

                //去厕所蹲坑 
                socketWatch.Listen(10);

                //不停的接收客户端的连接
                Thread th = new Thread(Listen);
                th.IsBackground = true;
                th.Start(socketWatch);
            }
            catch
            { }


        }


        Dictionary<string, Socket> dicSocket = new Dictionary<string, Socket>();
        void Listen(object o)
        {
            Socket socketWatch = o as Socket;
            while (true)
            {
                //循环的接收客户端的连接
                Socket socketSend = socketWatch.Accept();
                //将客户端的IP地址存储到下拉框中
                cboUsers.Items.Add(socketSend.RemoteEndPoint.ToString());
                //将IP地址和这个客户端的Socket放到键值对集合中
                dicSocket.Add(socketSend.RemoteEndPoint.ToString(), socketSend);
                ShowMsg(socketSend.RemoteEndPoint.ToString() + ":" + "连接成功");

                //客户端连接成功后，就应高接收客户端发来的消息
                Thread th = new Thread(Rec);
                th.IsBackground = true;
                th.Start(socketSend);

            }
        }

        void Rec(object o)
        {
            Socket socketSend = o as Socket;
            while (true)
            {
                try
                {
                    byte[] buffer = new byte[1024 * 1024 * 3];
                    int r = socketSend.Receive(buffer);

                    string str = Encoding.UTF8.GetString(buffer, 0, r);
                    ShowMsg(socketSend.RemoteEndPoint.ToString() + ":" + str);
                }
                catch
                { }
            }
        }



        void ShowMsg(string str)
        {
            txtLog.AppendText(str + "\r\n");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }


        /// <summary>
        /// 服务器给客户端发送消息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSend_Click(object sender, EventArgs e)
        {
            byte[] buffer = Encoding.UTF8.GetBytes(txtMsg.Text);
            //获得客户端的ip
            string ip = cboUsers.SelectedItem.ToString();
            List<byte> list = new List<byte>();
            list.Add(0);
            list.AddRange(buffer);
            byte[] newBuffer = list.ToArray();

            dicSocket[ip].Send(newBuffer);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "所有文件|*.*";
            ofd.ShowDialog();
            txtPath.Text = ofd.FileName;
        }

        private void btnSendFile_Click(object sender, EventArgs e)
        {
            string path = txtPath.Text;
            using (FileStream fsRead = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                byte[] buffer = new byte[1024 * 1024 * 3];
                int r = fsRead.Read(buffer, 0, buffer.Length);
                List<byte> list = new List<byte>();
                list.Add(1);
                list.AddRange(buffer);
                byte[] newBuffer = list.ToArray();
                string ip = cboUsers.SelectedItem.ToString();
                dicSocket[ip].Send(newBuffer, 0, r+1, SocketFlags.None);
            }
        }

        private void btnZD_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[1];
            buffer[0] = 2;
            string ip = cboUsers.SelectedItem.ToString();
            dicSocket[ip].Send(buffer);
        }
    }
}
