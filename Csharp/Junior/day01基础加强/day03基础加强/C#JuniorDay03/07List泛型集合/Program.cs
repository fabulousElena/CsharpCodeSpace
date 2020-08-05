using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07List泛型集合
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            //集合--->数组
            //Count:获取集合中实际包含的元素的个数
            //Capcity:集合中可以包含的元素的个数

            //list.Add(1);
            //Console.WriteLine(list.Count);
            //Console.WriteLine(list.Capacity);

            //Add的是添加单个元素
            //AddRange是添加集合
            list.Add(100);
            list.AddRange(new int[] { 1, 2, 3, 4, 5, 6 });

            //list.Remove(100);
            //list.RemoveAll(n => n > 3);

            //list.RemoveAt(3);

            //list.RemoveRange(1, 6);

            // list.Insert(1, 200);

            // list.InsertRange(0, new int[] { 5, 4, 3, 2, 1 });

            //集合跟数组之间的转换

            //集合----->数组
            int[] nums = list.ToArray();

            List<string> list2 = new List<string>();

            //list2.ToArray()

            int[] nums3 = { 1, 2, 3, 4, 5, 6 };

            List<int> list3 = nums3.ToList();

           
            for (int i = 0; i < list3.Count; i++)
            {
                Console.WriteLine(list3[i]);
            }

            Console.ReadKey();
        }
    }
}
