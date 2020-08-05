using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05方法练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 读取输入的整数
            //多次调用(如果用户输入的是数字,则返回,否则提示用户重新输入)

            //Console.WriteLine("请输入一个数字");
            //string input = Console.ReadLine();
            //int number = GetNumber(input);
            //Console.WriteLine(number);
            //Console.ReadKey();
            Console.WriteLine("请输入一个数字");
            
            GetNum();
            Console.ReadKey();

        }

        /// <summary>
        /// 这个方法需要判断用户的输入是否是数字
        /// 如果是数字，则返回
        /// 如果不是数字，提示用户重新输入
        /// </summary>
        /// 

        public static void GetNum()
        {
            while (true) {
                if (int.TryParse(Console.ReadLine(), out int a))
                {
                    Console.WriteLine("输入成功");
                    break;
                }
                else {
                    Console.WriteLine("请输入一个数字");
                }
            }
            //public static int GetNumber(string s)
            //{
            //    while (true)
            //    {
            //        try
            //        {
            //            int number = Convert.ToInt32(s);
            //            return number;
            //        }
            //        catch
            //        {
            //            Console.WriteLine("请重新输入");
            //            s = Console.ReadLine();
            //        }
            //    }
            //}


        }
    }
}
