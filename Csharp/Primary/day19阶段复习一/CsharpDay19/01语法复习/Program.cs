using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01语法复习
{
    class Program
    {
        static void Main(string[] args)
        {
            //使用进程打开指定的文件
            ProcessStartInfo psi = new ProcessStartInfo(@"C:\Users\SpringRain\Desktop\1.txt");
            Process p = new Process(); 
            p.StartInfo = psi;
            p.Start();
        }
    }
}
