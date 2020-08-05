using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15进程02
{
    class Program
    {
        static void Main(string[] args)
        {
            Process[] pro = Process.GetProcesses();
            foreach (var item in pro)
            {
                Console.WriteLine(item);
            }

            //打开程序
            Process.Start("chrome", "www.xiaodaizhi.com");

            Console.ReadKey();
        }
    }
}
