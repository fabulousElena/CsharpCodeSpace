using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04for循环的正序输出和倒序输出
{
    class Program
    {
        static void Main(string[] args)
        {
            //请打印 1-10
            int i = 0;
            for (; i < 10; )
            {
                Console.WriteLine("欢迎来到传智播客.Net学习");
                i++;
            }
            Console.ReadKey();

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}
            ////打印10-1
            //for (int i = 10; i >= 1; i--)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 10; i >= 1; i--)
            //{
            //    Console.WriteLine(i);
            //}
            Console.ReadKey();
        }
    }
}
