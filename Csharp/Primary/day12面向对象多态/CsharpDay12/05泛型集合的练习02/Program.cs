using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05泛型集合的练习02
{
    class Program
    {


        static void Main(string[] args)
        {
            //提示用户输入一个字符串，通过foreach循环将用户输入的字符串赋值给一个字符数组
            //Console.WriteLine("请输入一个字符串");
            //string s = Console.ReadLine();
            //char[] ss = new char[s.Length];
            //int index = 0;

            //foreach (var item in s)
            //{
            //    ss[index] = item;
            //    index++;
            //}

            //Console.WriteLine(ss);
            //Console.ReadKey();


            //统计 Welcome to china中每个字符出现的次数 不考虑大小写  "Welcome to China"
            string s = "qqqwwwweeeeeeee";
            s = s.ToLower();
            string[] ss = s.Split();
            Hashtable hs = new Hashtable();
            for (int i = 0; i < s.Length; i++)
            {

                if (hs.Contains(s[i]))
                {
                    hs[s[i]] = (int)hs[s[i]] + 1;
                }
                else
                {
                    hs.Add(s[i], 1);
                }

            }

            foreach (var item in hs.Keys)
            {
                Console.WriteLine("{0}字符出现了{1}次", item, hs[item]);
            }

            Console.ReadKey();


        }
    }
}
