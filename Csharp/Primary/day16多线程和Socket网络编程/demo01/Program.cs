using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo01
{
    class Program
    {
        static void Main(string[] args)
        {
            string ipAddress = "111.230.165.176";
            int portNum = 22;
            IPAddress ip = IPAddress.Parse(ipAddress);
            try
            {
                IPEndPoint point = new IPEndPoint(ip, portNum);
                using (Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
                {
                    sock.Connect(point);
                    Console.WriteLine("连接{0}成功!", point);
                    sock.Close();
                }
            }
            catch (SocketException e)
            {
                Console.WriteLine("连接{0}失败", portNum);
            }

            Console.ReadKey();
        }

        
   

    }
}
