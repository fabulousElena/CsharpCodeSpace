using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01进程
{
    class Program
    {
        static void Main(string[] args)
        {
            //存储着我们当前正在运行的进程
            //Process[] pro = Process.GetProcesses();
            //foreach (var item in pro)
            //{
            //    //item.Kill();不试的不是爷们
            //    Console.WriteLine(item.ProcessName);
            //}

            //使用进程来打开应用程序
            //Process.Start("notepad");//打开记事本
            //Process.Start("mspaint");//打开画图工具
            //Process.Start("iexplore", "http://www.baidu.com");
            //Process.Start("calc");//打开计算器


            //使用进程来打开文件


            //封装我们要打开的文件 但是并不去打开这个文件
            ProcessStartInfo psi = new ProcessStartInfo(@"C:\Users\SpringRain\Desktop\打开文件练习.exe");
            //创建进程对象
            Process pro = new Process();
            //告诉进程要打开的文件信息
            pro.StartInfo = psi;
            //调用函数打开
            pro.Start();
            Console.ReadKey();
        }
    }
}
