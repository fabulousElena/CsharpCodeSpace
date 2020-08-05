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
    public partial class ChatForm : Form
    {
        public ChatForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// jianting好友的消息
        /// </summary>
        string LocalPort;

        string localIp;

        void reciveFriend(object o)
        {

            try
            {

                string[] ipAndPort = Form1.withPort.Split(':');
                localIp = ipAndPort[0];
                LocalPort = ipAndPort[1];
                Thread th = new Thread(StartToRecive);
                th.Start();


            }
            catch (Exception)
            {
            }
        }

        /// <summary>
        /// 开始接收消息
        /// </summary>
        /// 

        //IPAddress[] ips = Dns.GetHostAddresses(Dns.GetHostName());
        //IPAddress ip = ips[ips.Length - 1];

        static IPAddress localIpForever;
        int port;
        void StartToRecive(object o)
        {

            IPAddress[] localIP = Dns.GetHostAddresses("");
            localIpForever = localIP[localIP.Length - 1];
            Random random = new Random();
            port = random.Next(1024, 65501);

            while (true)
            {
                string[] localIpAndPort = Form1.localHost.Split(':');
            
            IPEndPoint local = new IPEndPoint(localIpForever, port);
            //richTextBox2.AppendText(localIp + "***********" + LocalPort);
            IPEndPoint localIpep = new IPEndPoint(IPAddress.Parse(Form1.sIP), Convert.ToInt32(Form1.sPort));
            //IPEndPoint localIpep = null;
            UdpClient reciveUdp = new UdpClient(local);
            richTextBox2.AppendText(localIpForever.ToString() + "本地的" + port + "\n");
            richTextBox2.AppendText(Form1.sIP + "云端的" + Form1.sPort);


            

                byte[] buffer = reciveUdp.Receive(ref localIpep);
                string message = Encoding.UTF8.GetString(
                        buffer, 0, buffer.Length);

                richTextBox2.AppendText(message + "\n" + "sadadsadadsadsa");

            }



        }
        bool b = true;
        private UdpClient udpcSend;
        private void button1_Click(object sender, EventArgs e)
        {
            IPEndPoint local = new IPEndPoint(localIpForever, port);
            IPEndPoint udpIpPort = new IPEndPoint(IPAddress.Parse("111.230.165.176"), 2300);
            udpcSend = new UdpClient();
            List<byte> tempList = new List<byte>();
            // 6 传递要进行连接的人的ip 和port 0.0.0.0:3360*sdawagfsadwadadwa
            tempList.Add(6);
            string ss3 = friendIp + ":" + friendPort;
            // + ":" + friendPort
            //richTextBox2.AppendText(ss3 + "\n");
            tempList.AddRange(Encoding.UTF8.GetBytes(ss3));
            udpcSend.Send(tempList.ToArray(), tempList.Count, udpIpPort);

            //udpcSend.Close();

            IPEndPoint udpIpPortToFriend = new IPEndPoint(IPAddress.Parse(Form1.sIP), Convert.ToInt32(Form1.sPort));
            UdpClient udpcSend2 = new UdpClient();

            byte[] buffer =  Encoding.UTF8.GetBytes(richTextBox1.Text);

            udpcSend2.Send(buffer,buffer.Length, udpIpPortToFriend);








        }
        public static string friendIp;
        public static string friendPort;
        public static string ipAndPort;
        private void ChatForm_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;

            ipAndPort = Form1.sIP + ":" + Form1.sPort;
            string[] ipPort = ipAndPort.Split(':');
            friendIp = ipPort[0];
            friendPort = ipPort[1];

            Thread th = new Thread(reciveFriend);
            th.IsBackground = true;
            th.Start();




        }
    }
}
