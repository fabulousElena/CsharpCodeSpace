using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03for循环
{
    class Program
    {
        static void Main(string[] args)
        {
            //向控制台打印10遍  欢迎来到传智播客.Net学习

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("欢迎来到传智播客.Net学习{0}", i);
            }
            //for (int i = 0; i < length; i++)
            //{
                
            //}
            Console.ReadKey();

            //int i = 0;//定义循环的次数
            //while (i < 10)
            //{
            //    Console.WriteLine("欢迎来到传智播客.Net学习");
            //    i++;
            //}
            //Console.ReadKey();
        }
    }
}
