using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _08正则表达式练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //.+\\([a-zA-Z0-9]+\.[a-zA-Z]+)
            //string path = @"c:\windows\testb.txt";
            //Match mc = Regex.Match(path, @".+\\([a-zA-Z0-9]+\.[a-zA-Z]+)");
            //if (mc.Success)
            //{
            //    Console.WriteLine(mc.Groups[1].Value);
            //}

            //string str = "June       26,       1951";
            //Match mc = Regex.Match(str, @"([a-zA-Z]+)\s+([0-9]+),\s+([0-9]+)");
            //if (mc.Success)
            //{
            //    Console.WriteLine(mc.Groups[1].Value);
            //    Console.WriteLine(mc.Groups[2].Value);
            //    Console.WriteLine(mc.Groups[3].Value);
            //}


            //192.168.10.5[port=21,type=ftp]
            //192.168.10.5[port=21]

            //string ipAddress = "192.168.10.5[port=21,type=ftp]";

            //Match mc = Regex.Match(ipAddress, @"(?<ip>\d{3}(\.\d{1,3}){3})\[(?<port>\w+=[0-9]{1,5})(,(?<type>\w+=\w+))?\]");

            //if (ipAddress.Contains("type"))
            //{
            //    if (mc.Success)
            //    {
            //        Console.WriteLine("ip地址是{0}", mc.Groups["ip"].Value);
            //        Console.WriteLine("port是{0}", mc.Groups["port"].Value);
            //        Console.WriteLine("type是{0}", mc.Groups["type"].Value);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("ip地址是{0}", mc.Groups["ip"].Value);
            //    Console.WriteLine("port是{0}", mc.Groups["port"].Value);
            //}
           


            Match match = Regex.Match("大家好。我是S.H.E。我22岁了。我病了，呜呜。fffff", "我是(.+?)。");

            if (match.Success)
            {
                //Console.WriteLine(match.Value);
                Console.WriteLine(match.Groups[1]);
            }

            Console.ReadKey();
        }
    }
}
