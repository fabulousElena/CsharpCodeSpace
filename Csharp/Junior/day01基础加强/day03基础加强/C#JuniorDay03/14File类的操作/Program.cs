using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace _14File类的操作
{
    class Program
    {
        static void Main(string[] args)
        {
            //File
            //Exist()：判断指定的文件是否存在
            //Create():创建
            //Move():剪切
            //Copy():复制
            //Delete()：删除


            //if (!File.Exists("1.txt"))
            //{
            //    File.Create("1.txt");
            //}

            //if (File.Exists("1.txt"))
            //{
            //    File.Delete("1.txt");
            //}
            //

            //File.Copy(@"C:\Users\SpringRain\Desktop\english.txt", @"D:\aaaaaa.txt");
            //Console.WriteLine("操作成功");
            //File.Move(@"D:\aaaaaa.txt", @"C:\Users\SpringRain\Desktop\bbbbbb.txt");

            //ReadAllLines()默认采用的编码格式是utf-8
            //string[] str = File.ReadAllLines(@"C:\Users\SpringRain\Desktop\english.txt");
            //ReadAllText()默认采用的编码格式也是utf-8
            //string str = File.ReadAllText(@"C:\Users\SpringRain\Desktop\english.txt");
            //Console.WriteLine(str);

            //byte[] buffer = File.ReadAllBytes(@"C:\Users\SpringRain\Desktop\english.txt");
            ////字节数组---->字符串
            //string str = Encoding.UTF8.GetString(buffer);
            //Console.WriteLine(str);
            //string str="张三李四王五百家姓";
            ////字符串--->字节数组
            //byte[] buffer= Encoding.Default.GetBytes(str);
            //File.WriteAllBytes(@"C:\Users\SpringRain\Desktop\121212.txt", buffer);
            //Console.WriteLine("写入成功");
            //Console.ReadKey();
            //File.WriteAllLines(@"C:\Users\SpringRain\Desktop\121212.txt", new string[] { "a", "b" });

          //  File.WriteAllText(@"C:\Users\SpringRain\Desktop\121212.txt", "c");

            //byte[] buffer = new byte[3];
            //Console.WriteLine(buffer.ToString());
            //18 99 221 我爱你
           // Encoding.Default.GetString()
              
        }
    }
}
