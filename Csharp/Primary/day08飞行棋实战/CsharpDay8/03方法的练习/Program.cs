using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03方法的练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //100、计算任意多个数间的最大值（提示：params）。
            //int sum = GetSum(1, 2, 3, 4, 5, 6, 7);
            //Console.WriteLine(sum);
            //Console.ReadKey();

            //101、请通过冒泡排序法对整数数组{ 1, 3, 5, 7, 90, 2, 4, 6, 8, 10 }实现升序排序。
            //int[] nums = { 1, 3, 5, 7, 90, 2, 4, 6, 8, 10 };
            //Change(nums);
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine(nums[i]);
            //}
            //Console.ReadKey();

            //102将一个字符串数组输出为|分割的形式，比如“梅西|卡卡|郑大世”(用方法来实现此功能)
            string[] names = { "梅西", "卡卡", "郑大世" };
            string str = ProcessString(names);
            Console.WriteLine(str);
            Console.ReadKey();
            //"梅西|卡卡|郑大世"

        }
        public static string ProcessString(string[] names)
        {
            string str = null;
            for (int i = 0; i < names.Length-1; i++)
            {
                str += names[i] + "|";
            }
            return str + names[names.Length - 1];
        }

        public static void Change(int[] nums)
        {
            for (int i = 0; i < nums.Length-1; i++)
            {
                for (int j = 0; j < nums.Length-1-i; j++)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        int temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;
                    }
                }
            }
        }


        public static int GetSum(params int[] nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            return sum;
        }
    }
}
