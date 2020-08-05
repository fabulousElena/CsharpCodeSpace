using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Test01
{
    class Program
    {
        static void Main(string[] args)
        {
            //string s = "usersName*0.0.0.0:3356-usersName*0.0.0.0:3356";
            //int i =s.LastIndexOf(':');
            //string s2 = s.Substring(40);
            //Console.WriteLine(s2);
            //Console.ReadKey();

            IPAddress[] localIP = Dns.GetHostAddresses("");
            IPAddress localIp = localIP[localIP.Length - 1];
            Random random = new Random();
            int port = random.Next(1024, 65501);
            
            Console.ReadKey();
        }
    }
}
