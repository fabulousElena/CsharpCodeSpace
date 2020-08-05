using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_泛型委托
{
    public delegate int DelCompare<T>(T t1, T t2);
    // public delegate int DelCompare(object o1, object o2);
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5 };
            int max = GetMax<int>(nums, Compare1);
            Console.WriteLine(max);

            string[] names = { "abcdefg", "fdsfds", "fdsfdsfdsfdsfdsfdsfdsfsd" };
            string max1 = GetMax<string>(names, (string s1, string s2) =>
            {
                return s1.Length - s2.Length;
            });
            Console.WriteLine(max1);
            Console.ReadKey();
        }
        public static T GetMax<T>(T[] nums, DelCompare<T> del)
        {
            T max = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                //要传一个比较的方法
                if (del(max, nums[i]) < 0)
                {
                    max = nums[i];
                }
            }
            return max;
        }


        public static int Compare1(int n1, int n2)
        {
            return n1 - n2;
        }
    }
}
