using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _02线程和进程的复习
{
    class Program
    {
        static void Main(string[] args)
        {

            //通过进程去打开应用程序
            //  Process.getprocesses
            //Process.Start("notepad");
            //Process.Start("iexplore", "http://www.baidu.com");



            //通过进程去打开指定的文件
            //ProcessStartInfo psi = new ProcessStartInfo(@"C:\Users\SpringRain\Desktop\1、播放音乐下一曲.wmv");
            //Process p = new Process();
            //p.StartInfo = psi;
            //p.Start();
            //Console.ReadKey();


            //进程和线程的关系? 一个进程包含多个线程
            
            //前台  后台
        }
    }
}
