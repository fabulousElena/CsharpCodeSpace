using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace _02StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            //string str = string.Empty;
            //StringBuilder sb = new StringBuilder();
            ////00:00:00.1022297
            //Stopwatch sp = new Stopwatch();
            //sp.Start();
            //for (int i = 0; i < 100000; i++)
            //{
            //    //str += i;
            //    sb.Append(i);
            //}
            //sp.Stop();

            //Console.WriteLine(sp.Elapsed);
            //Console.WriteLine(sb.ToString());
            StringBuilder sb = new StringBuilder();
            sb.Append("张三");
            sb.Append("李四");
            sb.Append("王狗蛋儿");
            sb.Insert(1, "新来哒");
            sb.Replace("王狗蛋儿", "***");
            Console.WriteLine(sb.ToString());

            Console.ReadKey();
        }
    }
}
