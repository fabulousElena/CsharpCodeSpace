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
        // 0 表示用户名  

        public static Socket socketConnect;
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text.Length == 0)
            {
                MessageBox.Show("用户名为空，无法登陆");
                return;
            }
            try
            {
                socketConnect = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                //创建ip
                IPAddress clientIp = IPAddress.Parse(textBox1.Text);
                IPEndPoint clientPoint = new IPEndPoint(clientIp, Convert.ToInt32(textBox2.Text));
                //获得要连接的远程服务器应用程序的IP地址和端口号
                socketConnect.Connect(clientPoint);
                button1.Text = "登录成功";
                button1.Enabled = false;



                List<byte> bList = new List<byte>();
                bList.Add(0);
                byte[] buffer = System.Text.Encoding.UTF8.GetBytes(textBox3.Text.ToString());
                bList.AddRange(buffer);
                byte[] newBuffer = bList.ToArray();
                socketConnect.Send(newBuffer);

                Thread th = new Thread(ReciveServer);
                th.IsBackground = true;
                th.Start(socketConnect);
            }
            catch (Exception)
            {
            }
        }

        void Mes(string s)
        {
            MessageBox.Show(s);
        }
        //List<string> friendIPPort = new List<string>();
       public static string localHost;
        Dictionary<string, string> friendIPPort = new Dictionary<string, string>();
        /// <summary>
        /// 接受客户端消息
        /// </summary>
        /// <param name="o"></param>
        public static string withPort;
        void ReciveServer(object o)
        {
            //Socket reciveServer;
            socketConnect = o as Socket;
            string s;
            while (true)
            {
                try
                {
                    byte[] buffer = new byte[1024 * 1024 * 5];
                    int r = socketConnect.Receive(buffer);
                    //接收ip和端口
                    if (buffer[0] == 0)
                    {
                        s = Encoding.UTF8.GetString(buffer, 1, r - 1);
                        localHost = s;
                        richTextBox1.AppendText("用户：" + textBox3.Text + "\n" + "IP地址:" + s + "连接成功");
                        withPort = s;
                    }
                    //接收所有的用户名，然后显示在listbox里  usersName*0.0.0.0:3356-usersName*0.0.0.0:3356
                    if (buffer[0] == 1)
                    {
                        s = Encoding.UTF8.GetString(buffer, 1, r - 1);
                        string[] usersName = s.Split('-');
                        listBox1.Items.Clear();
                        List<string> nameListExceptMe = new List<string>();
                        for (int i = 0; i < usersName.Length; i++)
                        {
                            string ss = usersName[i].Substring(0, usersName[i].IndexOf('*'));
                            if (ss != textBox3.Text)
                            {
                                friendIPPort.Add(ss, usersName[i].Substring(usersName[i].IndexOf('*') + 1));
                                nameListExceptMe.Add(ss);
                            }
                        }
                        listBox1.Items.AddRange(nameListExceptMe.ToArray());
                    }


                    //Thread th2 = new Thread(sendMessage);
                    //th2.IsBackground = true;
                    //th2.Start(socketConnect);
                }
                catch (Exception)
                { }
                
            }

        }
        public static Socket chatSocket = socketConnect;
        /// <summary>
        /// 向服务端发送消息
        /// </summary>
        /// <param name="o"></param>
        void sendMessage(object o)
        {
            socketConnect = o as Socket;


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;

        }

        public static string sIP;
        public static string sPort;
        public void listBox1_DoubleClick(object sender, EventArgs e)
        {


            if (listBox1.Items.Count == 0)
            {
                Mes("当前暂无在线用户。");
                return;
            }
            foreach (var item in friendIPPort)
            {
                if (item.Key == (string)listBox1.SelectedItem)
                {
                    string[] ss33 = item.Value.Split(':');
                    sIP = ss33[0];
                    sPort = ss33[1];
                }

            }

            ChatForm cf = new ChatForm();
            cf.Show();

        }
    }
}
