using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习8_9
{
    class Program
    {
        static void Main(string[] args)
        {
            //请用户输入一个字符串，计算字符串中的字符个数，并输出。
            //string s = "abcdef";
            //Console.WriteLine(s.Length);
            //Console.ReadKey();

            //用方法来实现：计算两个数的最大值。
            //思考：方法的参数？返回值？扩展（*）：计算任意多个数间的最大值（提示：params）。

            //Console.WriteLine("请输入第一个数字");
            //int n1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入第二个数字");
            //int n2 = Convert.ToInt32(Console.ReadLine());
            //int max = GetMax(n1, n2);
            //Console.WriteLine(max);
            int[] nums = { 1, 2, 3, 4, 5 };
            int max = GetMax(1,2,3,4,5,6);
            Console.WriteLine(max);
            Console.ReadKey();
        }

        public static int GetMax(params int[] nums)
        {
            int max = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                }
            }
            return max;
        }


        public static int GetMax(int n1, int n2)
        {
            return n1 > n2 ? n1 : n2;
        }
    }
}
