using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15进程
{
    class Program
    {
        static void Main(string[] args)
        {
            //获得当前程序中所有正在运行的进程
            //Process[] pros = Process.GetProcesses();
            //foreach (var item in pros)
            //{
            //    //不试的不是爷们
            //    //item.Kill();
            //    Console.WriteLine(item);
            //}

            //通过进程打开一些应用程序
            //Process.Start("calc");
            //Process.Start("mspaint");
            //Process.Start("notepad");
            //Process.Start("iexplore", "http://www.baidu.com");

            //通过一个进程打开指定的文件

            ProcessStartInfo psi = new ProcessStartInfo(@"C:\Users\SpringRain\Desktop\1.exe");
           
            //第一：创建进程对象
            Process p = new Process();
            p.StartInfo = psi;
            p.Start();
           // p.star


            Console.ReadKey();
        }
    }
}
