using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01复习02
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] contents = File.ReadAllLines(@"F:\壁纸\公众号\temp\name.txt");
            foreach (string item in contents)
            {
                Console.WriteLine(item);
            }
           
            //相对路径
            File.WriteAllLines("new.txt",contents);
            //追加文本。
            File.AppendAllText("new.txt","asd");

            Console.ReadKey();

        }
    }
}
