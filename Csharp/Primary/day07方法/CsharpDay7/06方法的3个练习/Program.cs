using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06方法的3个练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //2 还记得学循环时做的那道题吗?只允许用户输入y或n,请改成方法

            //这个方法做了什么事儿？
            //只能让用户输入yes或者no，只要不是，就重新输入

            //输入yes 看 输入no 不能看   

            //Console.WriteLine("请输入yes或者no");
            //string str = Console.ReadLine();
            //string result = IsYerOrNo(str);
            //Console.WriteLine(result);
            //Console.ReadKey();

            //4计算输入数组的和：int Sum(int[] values)
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int sum = GetSum(nums);
            Console.WriteLine(sum);
            Console.ReadKey();
        }

        /// <summary>
        /// 计算一个整数类型数组的总和
        /// </summary>
        /// <param name="nums">要求总和的数组</param>
        /// <returns>返回这个数组的总和</returns>
        public static int GetSum(int[] nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            return sum;
        }



        /// <summary>
        /// 限定用户只能输入yes或者no 并且返回
        /// </summary>
        /// <param name="input">用户的输入</param>
        /// <returns>返回yes或者no</returns>
        public static string IsYerOrNo(string input)
        {
            while (true)
            {
                if (input == "yes" || input == "no")
                {
                    return input;
                }
                else
                {
                    Console.WriteLine("只能输入yes或者no，请重新输入");
                    input = Console.ReadLine();
                }
            }
        }
    }
}
