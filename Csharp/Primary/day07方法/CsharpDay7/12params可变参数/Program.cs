using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12params可变参数
{
    class Program
    {
        static void Main(string[] args)
        {
            //   int[] s = { 99, 88, 77 };
            //Test("张三",99,100,100,100);
            //Console.ReadKey();

            //求任意长度数组的和 整数类型的
            int[] nums = { 1, 2, 3, 4, 5 };
            int sum = GetSum(8,9);
            Console.WriteLine(sum);
            Console.ReadKey();
        }

        public static int GetSum(params int[] n)
        {
            int sum = 0;
            for (int i = 0; i < n.Length; i++)
            {
                sum += n[i];
            }
            return sum;
        }


        public static void Test(string name, int id, params int[] score)
        {
            int sum = 0;

            for (int i = 0; i < score.Length; i++)
            {
                sum += score[i];
            }
            Console.WriteLine("{0}这次考试的总成绩是{1},学号是{2}", name, sum, id);
        }
    }
}
