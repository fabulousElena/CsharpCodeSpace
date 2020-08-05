using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWebServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TextBox.CheckForIllegalCrossThreadCalls = false;
        }

        /// <summary>
        /// 开启服务器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        Socket listenSocket = null;
        private void btnStart_Click(object sender, EventArgs e)
        {
             listenSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);//创建了一个负责监听的Socket.
            IPAddress ipAddress = IPAddress.Parse(this.txtIpAddress.Text);//IP地址.
            IPEndPoint ipEndPoint = new IPEndPoint(ipAddress,Convert.ToInt32(this.txtPort.Text));
            listenSocket.Bind(ipEndPoint);//监听的Socket绑定了一个通信的节点
            listenSocket.Listen(10);//look一下数据有没有发过来。
            Thread myThread = new Thread(BeginAccept);
            myThread.IsBackground = true;
            myThread.Start();
        }
        private void BeginAccept()
        {
            while (true)//死循环：负责监听的Socket一致要等待客户端数据。
            {
                Socket newSocket = listenSocket.Accept();
                HttpApplication httpApplication = new HttpApplication(newSocket, ShowMsg);
           }
        }
        private void ShowMsg(string msg)
        {
            this.txtContent.AppendText(msg+"\r\n");
        }
    }
}
