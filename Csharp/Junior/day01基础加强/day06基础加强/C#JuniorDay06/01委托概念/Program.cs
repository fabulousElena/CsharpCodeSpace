using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace _01委托概念
{
    public delegate string DelString(string str);
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "abcDEdf", "ghIGKDfds", "fdsfsDSFDSfds" };
            //转大写  转小写 双引号

            //我们可以把一个函数直接赋值给一个委托


            //DelString del = ProToUpper;//new DelString(ProToUpper);

            ProString(names, delegate(string str) { return str.ToLower(); });//匿名函数

            ProString(names, (str) => { return str.ToUpper(); });

            foreach (string item in names)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }

        static void ProString(string[] names, DelString del)
        {
            for (int i = 0; i < names.Length; i++)
            {
                names[i] = del(names[i]);
            }
        }


        static string ProToUpper(string str)
        {
            return str.ToUpper();
        }
        static string ProToLower(string str)
        {
            return str.ToLower();
        }
    }
}
