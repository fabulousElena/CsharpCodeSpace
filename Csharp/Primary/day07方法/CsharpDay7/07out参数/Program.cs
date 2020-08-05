using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07out参数
{
    class Program
    {
        static void Main(string[] args)
        {
            //写一个方法 求一个数组中的最大值、最小值、总和、平均值
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            ////将要返回的4个值，放到一个数组中返回

            //int[] res = GetMaxMinSumAvg(numbers);
            //Console.WriteLine("最大值是{0},最小值是{1},总和是{2},平均值是{3}", res[0], res[1], res[2], res[3]);
            //Console.ReadKey();
            int max1;
            int min1;
            int sum1;
            int avg1;
            bool b;
            string s;
            double d;
            Test(numbers, out max1, out min1, out sum1, out avg1, out b, out s, out d);

            Console.WriteLine(max1);
            Console.WriteLine(min1);
            Console.WriteLine(sum1);
            Console.WriteLine(avg1);
            Console.WriteLine(b);
            Console.WriteLine(s);
            Console.WriteLine(d);
            Console.ReadKey();

        }
        /// <summary>
        /// 计算一个数组的最大值、最小值、总和、平均值
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int[] GetMaxMinSumAvg(int[] nums)
        {
            int[] res = new int[4];
            //假设 res[0] 最大值  res[1]最小值  res[2]总和  res[3]平均值
            res[0] = nums[0];//max
            res[1] = nums[0];//min
            res[2] = 0;//sum
            string name = "孙全";
            bool b = true;
            for (int i = 0; i < nums.Length; i++)
            {
                //如果当前循环到的元素比我假定的最大值还大 
                if (nums[i] > res[0])
                {
                    //将当前循环到的元素赋值给我的最大值
                    res[0] = nums[i];
                }
                if (nums[i] < res[1])
                {
                    res[1] = nums[i];
                }
                res[2] += nums[i];
            }
            //平均值
            res[3] = res[2] / nums.Length;
            return res;


        }


        /// <summary>
        /// 计算一个整数数组的最大值、最小值、平均值、总和
        /// </summary>
        /// <param name="nums">要求值得数组</param>
        /// <param name="max">多余返回的最大值</param>
        /// <param name="min">多余返回的最小值</param>
        /// <param name="sum">多余返回的总和</param>
        /// <param name="avg">多余返回的平均值</param>
        public static void Test(int[] nums, out int max, out int min, out int sum, out int avg, out bool b, out string s, out double d)
        {
            //out参数要求在方法的内部必须为其赋值
            max = nums[0];
            min = nums[0];
            sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                }
                if (nums[i] < min)
                {
                    min = nums[i];
                }
                sum += nums[i];
            }
            avg = sum / nums.Length;


            b = true;
            s = "123";
            d = 3.13;
        }



    }
}
