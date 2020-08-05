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

namespace ChatClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        void showMes(string s)
        {
            MessageBox.Show(s);
        }

        Socket socketConnect;
        /// <summary>
        /// 连接服务器按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //创建负责通信的Socket
                socketConnect = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp);
                //创建ip
                IPAddress clientIp = IPAddress.Parse(textBox1.Text);
                IPEndPoint clientPoint = new IPEndPoint(clientIp, Convert.ToInt32(textBox2.Text));
                //获得要连接的远程服务器应用程序的IP地址和端口号
                socketConnect.Connect(clientPoint);
                txtLog.AppendText(DateTime.Now + " " + "连接成功~");

                button1.Text = "连接成功";
                button1.Enabled = false;

                Thread th = new Thread(ReciveMes);
                th.IsBackground = true;
                th.Start(socketConnect);
            }
            catch (Exception)
            {}
        }
        /// <summary>
        /// 不停的从服务器端接收消息
        /// </summary>
        void ReciveMes(object o) {

            Socket socketConnec = o as Socket;
            string s;
            while (true)
            {
                byte[] buffer = new byte[1024 * 1024 * 5];
                int r = socketConnec.Receive(buffer);
                s = Encoding.UTF8.GetString(buffer);
                txtLog.AppendText(DateTime.Now + "：对方说：" + s + "\n");
            }
        }

        /// <summary>
        /// 客户端给服务器发消息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            string str = richTextBox1.Text.Trim();
            richTextBox1.Clear();
            byte[] buffer = System.Text.Encoding.UTF8.GetBytes(str);
            socketConnect.Send(buffer);
            
        }
    }
}
