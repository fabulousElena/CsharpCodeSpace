using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _01Path类复习
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\SpringRain\Desktop\0505.Net基础班第二十一天.txt";
            Console.WriteLine(Path.GetDirectoryName(path));
            //Console.WriteLine(Path.ChangeExtension(path, "jpg"));
            Console.ReadKey();
        }
    }
}
