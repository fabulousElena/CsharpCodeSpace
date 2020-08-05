using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace _02File类
{
    class Program
    {
        static void Main(string[] args)
        {
            //操作文件的
            //复制、剪切、创建、移除


            //File.Create(@"C:\Users\SpringRain\Desktop\new.txt");
            //Console.WriteLine("创建成功");

            //File.Delete(@"C:\Users\SpringRain\Desktop\new.txt");
            //Console.WriteLine("删除成功");

            //File.Move(@"C:\Users\SpringRain\Desktop\0505.Net基础班第二十一天.txt", @"C:\Users\SpringRain\Desktop\1.txt");
            //Console.ReadKey();


            //使用File类来读取数据


            //byte[] buffer = File.ReadAllBytes(@"C:\Users\SpringRain\Desktop\1.txt");

            //string str = Encoding.UTF8.GetString(buffer, 0, buffer.Length);

            //Console.WriteLine(str);

            ////编码：把字符串以怎样形式存储为二进制  ASCII  GBK  GB2312   UTF-8  
            //Console.ReadKey();

            //string[] str = File.ReadAllLines(@"C:\Users\SpringRain\Desktop\1.txt",Encoding.Default);

            //for (int i = 0; i < str.Length; i++)
            //{
            //    Console.WriteLine(str[i]);
            //}


            //string str = File.ReadAllText(@"C:\Users\SpringRain\Desktop\1.txt",Encoding.Default);
            //Console.WriteLine(str);
            //Console.ReadKey();




            //===============================================File类写入
            //string str="哈哈";

            //byte[] buffer=Encoding.Default.GetBytes(str);

            //File.WriteAllBytes(@"C:\Users\SpringRain\Desktop\new.txt", buffer);
            //Console.WriteLine("OK");


            //File.WriteAllLines(@"C:\Users\SpringRain\Desktop\1.txt", new string[] { "张三", "李四", "王五", "赵六" });
            //Console.WriteLine("OK");


           // File.WriteAllText(@"C:\Users\SpringRain\Desktop\1.txt", "今天还是比较凉快的");


            //File.AppendAllText(@"C:\Users\SpringRain\Desktop\1.txt", "没有覆盖哟");
            //Console.WriteLine("OK");
            //Console.ReadKey();


        }
    }
}
