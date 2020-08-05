using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07字符串的练习_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"F:\壁纸\公众号\temp\name.txt";
            string[] allLines = File.ReadAllLines(path,Encoding.Default);
            for (int i = 0; i < allLines.Length; i++)
            {
                Console.WriteLine(allLines[i]);
            }
            Console.WriteLine("共{0}个文件",allLines.Length);
            Console.ReadKey();

        }
    }
}
