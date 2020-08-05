using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07乘法口诀表
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0}*{1}={2}\t", i, j, i * j);
                }
                Console.WriteLine();//换行
            }
            Console.ReadKey();

            //Console.Write("Hello Wor\tld");
            //Console.WriteLine();
            //Console.Write("Hello World");
            //Console.ReadKey();

            //Console.WriteLine("请输入一个数字");
            //int number = Convert.ToInt32(Console.ReadLine());


            //for (int i = 0; i <=number; i++)
            //{
            //    Console.WriteLine("{0}+{1}={2}",i,number-i,number);
            //}
            //Console.ReadKey();
        }
    }
}
