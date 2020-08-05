using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12三元表达式
{
    class Program
    {
        static void Main(string[] args)
        {
            ////计算两个数字的大小 求出最大的
            //Console.WriteLine("请输入第一个数字");
            //int n1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入第二个数字");
            //int n2 = Convert.ToInt32(Console.ReadLine());
            ////            语法:
            ////表达式1?表达式2 :表达式3
            //int max = n1 > n2 ? n1 : n2;
            //Console.WriteLine(max);
            ////if (n1 > n2)
            ////{
            ////    Console.WriteLine(n1);
            ////}
            ////else
            ////{
            ////    Console.WriteLine(n2);
            ////}
            //Console.ReadKey();


            //提示用户输入一个姓名 只要输入的不是老赵  就全是流氓
            Console.WriteLine("请输入姓名");
            string name = Console.ReadLine();

            string result = name == "老赵" ? "淫才呀" : "流氓呀";
            Console.WriteLine(result);
            Console.ReadKey();

            //if (name == "老赵")
            //{
            //    Console.WriteLine("淫才呀");
            //}
            //else
            //{
            //    Console.WriteLine("流氓呀");
            //}
            Console.ReadKey();


        }
    }
}
