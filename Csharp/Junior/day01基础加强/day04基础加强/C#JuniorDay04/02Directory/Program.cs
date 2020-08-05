using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace _02Directory
{
    class Program
    {
        static void Main(string[] args)
        {
            //CreateDirectory:创建一个新的文件夹
            //Delete:删除
            //Move:剪切
            //Exist()判断指定的文件夹是否存在

            //if (!Directory.Exists(@"C:\Users\SpringRain\Desktop\new"))
            //{
            //    Directory.CreateDirectory(@"C:\Users\SpringRain\Desktop\new");
            //}

            //Console.WriteLine("操作成功");

            //for (int i = 0; i < 100; i++)
            //{
            //    Directory.CreateDirectory(@"C:\Users\SpringRain\Desktop\new\" + i);
            //}

            //Console.WriteLine("创建成功");


            //移动

            //Directory.Move(@"C:\Users\SpringRain\Desktop\new", @"C:\Users\SpringRain\Desktop\new2");
            //Console.WriteLine("移动成功");
            //Directory.Delete(@"C:\Users\SpringRain\Desktop\new2",true);
            //Console.WriteLine("删除成功");
            //Console.ReadKey();

              
            //获得指定目录下所有文件的全路径
            //string[] fileNames = Directory.GetFiles(@"F:\老赵生活\Music","*.mp3");

            //获得指定目录下所有的文件夹
            //只能获得当前第一目录下所有的文件夹
            string[] dics = Directory.GetDirectories(@"D:\");
            foreach (string item in dics)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();

        }
    }
}
