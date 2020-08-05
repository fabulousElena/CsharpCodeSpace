using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05泛型集合的练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //将一个数组中的奇数放到一个集合中，再将偶数放到另一个集合中
            //最终将两个集合合并为一个集合，并且奇数显示在左边 偶数显示在右边。

            //int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //List<int> listOu = new List<int>();
            //List<int> listJi = new List<int>();
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (nums[i] % 2 == 0)
            //    {
            //        listOu.Add(nums[i]);
            //    }
            //    else
            //    {
            //        listJi.Add(nums[i]);
            //    }
            //}


            ////listOu.AddRange(listJi);
            ////foreach (int item in listOu)
            ////{
            ////    Console.Write(item+"  ");
            ////}


            //listJi.AddRange(listOu);
            //foreach (int item in listJi)
            //{
            //    Console.Write(item+"  ");
            //}
            //Console.ReadKey();
            ////List<int> listSum = new List<int>();
            ////listSum.AddRange(listOu);
            ////listSum.AddRange(listJi);

            //提手用户输入一个字符串，通过foreach循环将用户输入的字符串赋值给一个字符数组

            //Console.WriteLine("请输入一个字符串");
            //string input = Console.ReadLine();
            //char[] chs = new char[input.Length];
            //int i = 0;
            //foreach (var item in input)
            //{
            //    chs[i] = item;
            //    i++;
            //}

            //foreach (var item in chs)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadKey();

            //统计 Welcome to china中每个字符出现的次数 不考虑大小写

            string str = "Welcome to China";
            //字符 ------->出现的次数
            //键---------->值
            Dictionary<char, int> dic = new Dictionary<char, int>();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    continue;
                }
                //如果dic已经包含了当前循环到的这个键 
                if (dic.ContainsKey(str[i]))
                {
                    //值再次加1
                    dic[str[i]]++;
                }
                else//这个字符在集合当中是第一次出现
                {
                    dic[str[i]] = 1;
                }
            }

            foreach (KeyValuePair<char,int> kv in dic)
            {
                Console.WriteLine("字母{0}出现了{1}次",kv.Key,kv.Value);
            }
            Console.ReadKey();

            //w  1


        }
    }
}
