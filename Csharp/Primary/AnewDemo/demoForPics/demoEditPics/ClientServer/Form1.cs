using System;
using System.Collections;
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
            //我他妈吧这个忘了！！！！！草死
            Control.CheckForIllegalCrossThreadCalls = false;

        }
        Dictionary<string, Socket> ipAndSocket = new Dictionary<string, Socket>();


        /// <summary>
        /// 点击开始监听按钮。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                showMes("还未设置端口号，请填入端口号后在开启监听。");
                return;
            }

            //点击开始监听的时候，创建一个监听ip和端口的socket
            Socket socketListener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //把ip赋值为任意IPV4 ip
            IPAddress serverIp = IPAddress.Any;
            //IPAddress serverIp = IPAddress.Parse("192.168.31.11");
            //创建端口号对象
            if (textBox2.Text.Length != 0)
            {
                try
                {
                    IPEndPoint serverPort = new IPEndPoint(serverIp, Convert.ToInt32(textBox2.Text));
                    //开启监听
                    try
                    {
                        socketListener.Bind(serverPort);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("开启监听失败，可能是ip或者端口错误，请检查后重试");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("端口号为空或者格式错误。");
                }
            }

            //设置监听客户端的数量
            try
            {
                socketListener.Listen(20);
                txtLog.AppendText("服务端：" + serverIp + "端口：" + textBox2.Text + " 成功开启监听" + "\n");
                if (serverIp.ToString() == "0.0.0.0")
                {
                    textBox1.Text = serverIp.ToString() + "(所有ip)";
                }
                else
                {
                    textBox1.Text = serverIp.ToString();
                }
            }
            catch (Exception)
            {
                showMes("IPEndPoint初始化失败或者未赋值。");
            }

            button1.Text = "正在监听";
            button1.Enabled = false;

            Thread th = new Thread(listenClient);
            th.IsBackground = true;
            th.Start(socketListener);

        }



        //负责跟客户端通信的Socket
        List<string> ipList = new List<string>();
        /// <summary>
        /// 循环等待客户端连接
        /// </summary>
        void listenClient(object o)
        {
            Socket socketWaitForClient;
            Socket socketListener = o as Socket;
            string remoteIp = "";
            //等待客户端的连接 并且创建一个负责通信的Socket
            while (true)
            {

                //负责跟客户端通信的Socket
                socketWaitForClient = socketListener.Accept();
                //将远程连接的客户端的IP地址和Socket存入集合中
                ipAndSocket.Add(socketWaitForClient.RemoteEndPoint.ToString(), socketWaitForClient);
                ipList.Add(socketWaitForClient.RemoteEndPoint.ToString()); 
                //将远程连接的客户端的IP地址和端口号存储到listbox里
                remoteIp = socketWaitForClient.RemoteEndPoint.ToString();

                listBox1.Items.Add(socketWaitForClient.RemoteEndPoint.ToString());
                listBox1.ResetText();
                //显示连接成功
                txtLog.AppendText("用户<" + remoteIp + ">连接成功" + "\n");

                //showMes("用户<" + socketWaitForClient.RemoteEndPoint.ToString() + ">连接成功");


                Thread th = new Thread(Recive);
                th.IsBackground = true;
                th.Start(socketWaitForClient);

                Thread th2 = new Thread(SendMessage);
                th2.IsBackground = true;
                th2.Start(socketWaitForClient);
            }


        }

        void SendMessage(object o) {
            
            Socket socketWaitForClient = o as Socket;
            while (true)
            {
                
                try
                {
                    byte[] buffer = System.Text.Encoding.UTF8.GetBytes(s);

                    if (buffer.Length == 0)
                    {
                        continue;
                    }

                    if (ipAndSocket[ipList[0]].Equals(socketWaitForClient))
                    {
                        ipAndSocket[ipList[1]].Send(buffer);
                        s = "";
                    }
                    else
                    {
                        ipAndSocket[ipList[0]].Send(buffer);
                        s = "";
                    }

                }
                catch (Exception)
                {
                   
                }
                
            }
        }

        static string s = "";
        
        /// <summary>
        /// 监听
        /// </summary>
        /// <param name="o"></param>
        void Recive(object o)
        {
            Socket socketWaitForClient = o as Socket;
            
            while (true)
            {
                try
                {
                    //客户端连接成功后，服务器应该接受客户端发来的消息
                    byte[] sendBuffer = new byte[1024 * 1024 * 5];
                    //实际接受到的有效字节数
                    int r = socketWaitForClient.Receive(sendBuffer);
                    if (r == 0)
                    {
                        break;
                    }
                    s = Encoding.UTF8.GetString(sendBuffer, 0, r);
                    txtLog.AppendText(DateTime.Now + s + "\n" );

                    

                }
                catch (Exception)
                {}

                //if (ipAndSocket[ipList[0]].Equals(socketWaitForClient))
                //{
                //    ipAndSocket[ipList[1]].Send(sendBuffer);
                //    continue;
                //}
                //else
                //{
                //    ipAndSocket[ipList[0]].Send(sendBuffer);
                //    continue;
                //}
            }



        }


        void showMes(string s)
        {
            MessageBox.Show(s);
        }


    }
}
