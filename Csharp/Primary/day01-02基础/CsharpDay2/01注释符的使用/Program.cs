using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01注释符的使用
{
    class Program
    {
        static void Main(string[] args)
        {

            //这行代码的作用是将Hello World打印到控制台当中
          //  Console.WriteLine("Hello World");

            //这行代码的作用是暂停当前这个程序
           // Console.ReadKey();



            /*
            Console.WriteLine("Hello World");
            Console.WriteLine("Hello World");
            Console.WriteLine("Hello World");
            Console.WriteLine("Hello World");
            Console.WriteLine("Hello World");
            Console.WriteLine("Hello World");
            Console.WriteLine("Hello World");
            Console.WriteLine("Hello World");*/

        }



        /// <summary>
        /// 这个方法的作用就是求两个整数之间的最大值
        /// </summary>
        /// <param name="n1">第一个整数</param>
        /// <param name="n2">第二个整数</param>
        /// <returns>返回比较大的那个数字</returns>
        public static int GetMax(int n1, int n2)
        {
            return n1 > n2 ? n1 : n2;
        }
    }



    /// <summary>
    /// 这个类用来描述一个人的信息 从 姓名 性别 年龄描述
    /// </summary>
    public class Person
    {
        public string Name
        { 
            get;
            set;
        }

        public int Age
        {
            get;
            set;
        }

        public char Gender
        {
            get;
            set;
        }
    }

}
