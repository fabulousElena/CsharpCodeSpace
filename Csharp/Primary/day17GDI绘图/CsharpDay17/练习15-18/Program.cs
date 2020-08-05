using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习15_18
{
    class Program
    {
        static void Main(string[] args)
        {
            //用方法来实现：有一个字符串数组：{ "马龙", "迈克尔乔丹", "雷吉米勒", "蒂姆邓肯", "科比布莱恩特" },请输出最长的字符串。
            //string[] names = { "马龙", "迈克尔乔丹", "雷吉米勒", "蒂姆邓肯", "科比布莱恩特" };
            //string max = GetLongest(names);
            //Console.WriteLine(max);
            //Console.ReadKey();


            //用方法来实现：请计算出一个整型数组的平均值。{ 1, 3, 5, 7, 93, 33, 4, 4, 6, 8, 10 }。
            //要求：计算结果如果有小数，则显示小数点后两位（四舍五入）。

            //  int[] numbers = { 1, 3, 5, 7, 93, 33, 4, 4, 6, 8, 10 };
            //  double avg = GetAvg(numbers);
            //  avg = Convert.ToDouble(avg.ToString("0.00"));
            //  Console.WriteLine(avg);
            ////  Console.WriteLine("{0:0.00}", avg);
            //  Console.ReadKey();

            ////请通过冒泡排序法对整数数组{ 1, 3, 5, 7, 90, 2, 4, 6, 8, 10 }实现升序排序。
            //int[] nums = { 1, 3, 5, 7, 90, 2, 4, 6, 8, 10 };
            //Array.Sort(nums);//升序
            //Array.Reverse(nums);//翻转
            //for (int i = 0; i < nums.Length - 1; i++)
            //{
            //    for (int j = 0; j < nums.Length-1-i; j++)
            //    {
            //        if (nums[j] > nums[j + 1])
            //        {
            //            int temp = nums[j];
            //            nums[j] = nums[j + 1];
            //            nums[j + 1] = temp;
            //        }
            //    }
            //}

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine(nums[i]);
            //}
            // Console.ReadKey();

            //为教师编写一个程序，该程序使用一个数组存储30个学生的考试成绩，并给各个数组元素指定一个1-100的随机值，然后计算平均成绩。
            //int[] nums = new int[30];
            //Random r = new Random();
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    nums[i] = r.Next(1, 101);
            //}


            //double sum = 0;
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    sum += nums[i];
            //}
            //double avg = sum / nums.Length;
            //avg = Convert.ToDouble(avg.ToString("0.00"));
            //Console.WriteLine(avg);
            //Console.ReadKey();
            //string[] s=new String;


        }

        public static double GetAvg(int[] nums)
        {
            double sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            return sum / nums.Length;
        }


        public static string GetLongest(string[] names)
        {
            string max = names[0];
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i].Length > max.Length)
                {
                    max = names[i];
                }
            }
            return max;
        }
    }
}
