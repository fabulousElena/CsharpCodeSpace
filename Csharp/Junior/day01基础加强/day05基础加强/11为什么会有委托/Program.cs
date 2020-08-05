using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _11为什么会有委托
{
    public delegate void DelSayHi(string name);
    class Program
    {
        static void Main(string[] args)
        {
            // Thread th = new Thread(Method);//委托类型
            //把一个函数作为参数传递

            //List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6 };


            //list.RemoveAll(number => number > 2);
            //SayHi("张三",)

            //函数可以直接赋值给一个委托对象 委托的签名必须跟函数的签名一样
            //DelSayHi del = SayHiChinese;//new DelSayHi(SayHiChinese);
            //del("张三");
            //SayHi("张三", delegate(string name)
            //{ 
            //    Console.WriteLine("O ha Yo" + name); 
            //}                                   );                 //匿名函数


            SayHi("张三", (name) => { Console.WriteLine("O ha yo" + name); });


            Console.ReadKey();

        }
        static void SayHi(string name, DelSayHi del)
        {
            del(name);
        }

        //static void SayHiChinese(string name)
        //{
        //    Console.WriteLine("吃了么" + name);
        //}

        //static void SayHiEnglish(string name)
        //{
        //    Console.WriteLine("Ohayo" + name);
        //}



    }
}
