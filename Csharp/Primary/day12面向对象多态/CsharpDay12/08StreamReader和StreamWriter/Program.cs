using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace _08StreamReader和StreamWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            //使用StreamReader来读取一个文本文件
            //using (StreamReader sr = new StreamReader(@"C:\Users\SpringRain\Desktop\抽象类特点.txt", Encoding.Default))
            //{
            //    while (!sr.EndOfStream)
            //    {
            //        Console.WriteLine(sr.ReadLine());
            //    }
            //}


            //使用StreamWriter来写入一个文本文件
            using (StreamWriter sw = new StreamWriter(@"C:\Users\SpringRain\Desktop\newnew.txt",true))
            {
                sw.Write("看我有木有把你覆盖掉");
            }
            Console.WriteLine("OK");
            Console.ReadKey();
        }
    }
}
