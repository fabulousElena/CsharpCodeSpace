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

namespace ChatServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //点击开始监听的时候，创建一个监听ip和端口的socket
                Socket socketListener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                //把ip赋值为任意IPV4 ip
                IPAddress serverIp = IPAddress.Any;
                IPEndPoint serverPort = new IPEndPoint(serverIp, Convert.ToInt32(textBox2.Text));
                socketListener.Bind(serverPort);
                socketListener.Listen(20);
                richTextBox1.AppendText("服务端：" + serverIp + "端口：" + textBox2.Text + " 成功开启监听" + "\n");
                textBox1.Text = serverIp.ToString();
                button1.Text = "正在监听";
                button1.Enabled = false;
                textBox2.ReadOnly = true;
                Thread th = new Thread(waitForClient);
                th.IsBackground = true;
                th.Start(socketListener);

            }
            catch (Exception) { }
        }
        //usersList.add("usersName",new IPEndPoint(userIpAndPort[0] + [1]));
        List<Users> usersList = new List<Users>();
        List<string> usersNameList = new List<string>();
        Dictionary<string, Socket> userDic = new Dictionary<string, Socket>();
        string[] userIpAndPort;
        /// <summary>
        /// 循环等待客户端连接
        /// </summary>
        Socket forClient;
        void waitForClient(object o)
        {

            Socket socketListener = o as Socket;

            while (true)
            {
                try
                {
                    forClient = socketListener.Accept();
                    userDic.Add(forClient.RemoteEndPoint.ToString(), forClient);
                    userIpAndPort = forClient.RemoteEndPoint.ToString().Split(':');
                    //把ip和端口号返回给客户端
                    List<byte> tempUsersIpPort = new List<byte>();
                    //0代发送ip和端口
                    tempUsersIpPort.Add(0);
                    tempUsersIpPort.AddRange(System.Text.Encoding.UTF8.GetBytes(forClient.RemoteEndPoint.ToString()));
                    forClient.Send(tempUsersIpPort.ToArray());

                    Thread th = new Thread(ReciveClient);
                    th.IsBackground = true;
                    th.Start(forClient);


                }
                catch (Exception) { }
            }
        }
        /// <summary>
        /// 接受客户端 消息
        /// </summary>
        static string remoteIPAdress = "1:1";
        void ReciveClient(object o)
        {
            string userName;

            forClient = o as Socket;
            while (true)
            {
                int nameListLength = 0;
                try
                {
                    byte[] buffer = new byte[1024 * 1024 * 5];
                    int r = forClient.Receive(buffer);
                    if (r == 0)
                    {
                        break;
                    }
                    //接收的是用户名
                    if (buffer[0] == 0)
                    {
                        userName = Encoding.UTF8.GetString(buffer, 1, r - 1);
                        //把用户名 ip 端口 连接成  usersName*0.0.0.0:3356 的格式  然后客户端接受以后再切割
                        string usersNameIpPort = userName + "*" + forClient.RemoteEndPoint.ToString();
                        usersNameList.Add(usersNameIpPort);
                        richTextBox1.AppendText("\n" + "用户：" + userName + "\n" + "Ip地址：" + forClient.RemoteEndPoint.ToString() + "登录成功");
                        remoteIPAdress = forClient.RemoteEndPoint.ToString();
                    }

                    if (true)
                    {

                    }

                    if (nameListLength != usersNameList.Count)
                    {
                        nameListLength = usersNameList.Count;
                        Thread th = new Thread(SendMesToClient);
                        th.IsBackground = true;
                        th.Start(forClient);
                    }


                }
                catch (Exception)
                { }

            }
        }
        /// <summary>
        /// 
        /// </summary>


       
        void ReciveUdp()
        {
            try
            {

                IPEndPoint localIpep = new IPEndPoint(
                        IPAddress.Any, 2300);
                UdpClient reciveUdp = new UdpClient(localIpep);

                Thread th = new Thread(StartToRecive);
                th.IsBackground = true;
                th.Start(reciveUdp);

            }
            catch (Exception)
            {
            }
        }
        /// <summary>
        /// 接收消息
        /// </summary>
        void StartToRecive(object o)
        {
            //获得本地ip
            IPAddress[] ips = Dns.GetHostAddresses(Dns.GetHostName());
            IPAddress ip = ips[ips.Length - 1];
            IPAddress remoteIp = ip;

            IPEndPoint local = new IPEndPoint(ip, 2300);
            IPEndPoint localIpep = new IPEndPoint(
                    IPAddress.Any, 0);
            UdpClient reciveUdp = new UdpClient(local);
            //string[] s22 = remoteIPAdress.Split(':');
            //IPEndPoint remoteIpep = new IPEndPoint(IPAddress.Parse(s22[1]),Convert.ToInt32(s22[1]));
            richTextBox1.AppendText("+++++++++++++++---+++++++++++++");

            while (true)
            {
                string message;
                byte[] buffer = reciveUdp.Receive(ref localIpep);
                 message = Encoding.UTF8.GetString(
                        buffer, 1, buffer.Length - 1);
                
                richTextBox1.AppendText(message + "\n");


                //if (message==null)
                //{
                //    richTextBox1.AppendText("++++++++++++++++++++++++++++++++++");
                //}
                //else
                //{
                //    Thread th = new Thread(SendMesToFriend);
                //    th.IsBackground = true;
                //    th.Start(message);
                //}
                
            }
        }
        /// <summary>
        /// 给好友发送消息
        /// </summary>
        /// <param name="o"></param>
        void SendMesToFriend(object o)
        {

            string messages = o as string;
            
            string[] s = messages.Split(':');
            string[] portAndText = s[1].Split('*');
            string text = portAndText[1];
            IPEndPoint localIpep = new IPEndPoint(
                        IPAddress.Parse(s[0]), Convert.ToInt32(portAndText[0]));

            richTextBox1.AppendText(s[0] + "是Ip" + portAndText[0] + "端口"+"\n");
            byte[] buffer = Encoding.UTF8.GetBytes(text);


            UdpClient sendUdp = new UdpClient();
           int i = sendUdp.Send(buffer, buffer.Length, localIpep);
            richTextBox1.AppendText(text + "发送的是" + i+"\n");
            //sendUdp.Close();

        }

        /// <summary>
        /// 传送用户名 ip port
        /// </summary>
        /// <param name="o"></param>
        void SendMesToClient(object o)
        {
            forClient = o as Socket;
            while (true)
            {
                try
                {
                    foreach (var item in userDic)
                    {
                        List<byte> tempUsersNameList = new List<byte>();
                        string[] tempArray = usersNameList.ToArray();
                        string tempString = string.Join("-", tempArray);
                        //1代表 的是 所有用户名  中间用 - 分割
                        tempUsersNameList.Add(1);
                        tempUsersNameList.AddRange(Encoding.UTF8.GetBytes(tempString));
                        //forClient.Send(tempUsersNameList.ToArray());
                        item.Value.Send(tempUsersNameList.ToArray());
                    }

                    return;
                }
                catch (Exception)
                {
                }
            }

            


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;

            try
            {
                //IPEndPoint localIpep = new IPEndPoint(
                //        IPAddress.Any, 2300);
                
                Thread th2 = new Thread(StartToRecive);
                th2.IsBackground = true;
                th2.Start();
            }
            catch (Exception)
            {
            }
        }
    }
}
