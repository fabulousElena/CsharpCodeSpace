using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03泛型委托
{
    public delegate int DelCompare<T>(T o1, T o2);
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> list = new List<int>();
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //GetMax<Person>()

            //  GetMax<int>()

            //List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            ////IEnumerable<int> item = list.Where<int>(n => { return n > 5; });
            ////foreach (var i in item)
            ////{
            ////    Console.WriteLine(i);
            ////}

            //list.Where(n => { return n > 5; });

            //List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //list.RemoveAll(n => n > 5);

            //foreach (int item in list)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.ReadKey();


        }

        static T GetMax<T>(T[] nums, DelCompare<T> del)
        {
            T max = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                if (del(max, nums[i]) < 0)//需要传进来一个比较的方式
                {
                    max = nums[i];
                }
            }
            return max;
        }
    }

    class Person
    {

    }
}
