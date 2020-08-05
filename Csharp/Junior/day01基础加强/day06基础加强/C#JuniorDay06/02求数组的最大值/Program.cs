using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02求数组的最大值
{
    public delegate int DelCompare(object o1, object o2);
    class Program
    {
        static void Main(string[] args)
        {
            //object[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //object[] names = { "张三", "李四", "王五", "zhafdsfdsfds" };


            object[] pers = { new Person() { Name = "张三", Age = 19 }, new Person() { Name = "李四", Age = 29 } };
            //object max = GetMax(pers, delegate(object o1, object o2) { return ((Person)o1).Age - ((Person)o2).Age; });

            object max= GetMax(pers, (o1, o2) => { return ((Person)o1).Age - ((Person)o2).Age; });


            Console.WriteLine(((Person)max).Name);
            Console.ReadKey();
        }

        static object GetMax(object[] nums, DelCompare del)
        {
            object max = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                if (del(max, nums[i]) < 0)//需要传进来一个比较的方式
                {
                    max = nums[i];
                }
            }
            return max;
        }
        static int C1(object o1, object o2)
        {
            int n1 = (int)o1;
            int n2 = (int)o2;
            return n1 - n2;
        }
        static int C2(object o1, object o2)
        {
            string s1 = (string)o1;
            string s2 = (string)o2;
            return s1.Length - s2.Length;
        }




        //static string GetMax(string[] names)
        //{
        //    string max = names[0];
        //    for (int i = 0; i < names.Length; i++)
        //    {
        //        if (names[i].Length > max.Length)
        //        {
        //            max = names[i];
        //        }
        //    }
        //    return max;
        //}

    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

}
