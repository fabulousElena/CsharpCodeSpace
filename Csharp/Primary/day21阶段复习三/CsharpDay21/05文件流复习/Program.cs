using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace _05文件流复习
{
    class Program
    {
        static void Main(string[] args)
        {
            //  FileStream StreamReader StreamWriter
            //using (FileStream fsRead = new FileStream(@"C:\Users\SpringRain\Desktop\1.wmv", FileMode.OpenOrCreate, FileAccess.Read))
            //{
            //    byte[] buffer = new byte[fsRead.Length];
            //    //表示本次读取实际读取到的有效字节数
            //    int r = fsRead.Read(buffer, 0, buffer.Length);

            //    string s = Encoding.Default.GetString(buffer, 0,r);
            //    Console.WriteLine(s);
            //}

            //using (FileStream fsWrite = new FileStream(@"C:\Users\SpringRain\Desktop\1.txt", FileMode.Append, FileAccess.Write))
            //{ 
            //    string s="今天天气好晴朗";
            //    byte[] buffer=Encoding.Default.GetBytes(s);
            //    fsWrite.Write(buffer, 0, buffer.Length);
            //}
            //Console.WriteLine("写入成功");

            //Console.ReadKey();  

            //using (FileStream fsRead = new FileStream(@"C:\Users\SpringRain\Desktop\1.txt", FileMode.OpenOrCreate, FileAccess.Read))
            //{
            //    using (StreamReader sr = new StreamReader(fsRead,Encoding.Default))
            //    {
            //        while (!sr.EndOfStream)
            //        {
            //            Console.WriteLine(sr.ReadLine());
            //        }
            //    }
            //}
            //byte[] buffer = new byte[1024 * 1024];
            //using (StreamWriter sw = new StreamWriter(@"C:\Users\SpringRain\Desktop\1.txt", true, Encoding.Default, buffer.Length))
            //{
            //    sw.WriteLine("哈哈哈");
            //}
            //Console.WriteLine("OK");

            //Console.ReadKey();

        }

    }
}
