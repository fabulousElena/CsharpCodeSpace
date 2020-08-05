using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _8_委托概念
{
    //声明一个委托指向一个函数
    public delegate void DelSayHi(string name);
    class Program
    {
        static void Main(string[] args)
        {
            DelSayHi del = SayHiEnglish;//new DelSayHi(SayHiEnglish);
            del("张三");
            Console.ReadKey();

            //Test("张三", SayHiChinese);
            //Test("李四", SayHiEnglish);
            //Console.ReadKey();
        }

        public static void Test(string name,DelSayHi del)
        { 
            //调用
            del(name);
        }

        public static void SayHiChinese(string name)
        {
            Console.WriteLine("吃了么？" + name);
        }
        public static void SayHiEnglish(string name)
        {
            Console.WriteLine("Nice to meet you" + name);
        }
    }
}
