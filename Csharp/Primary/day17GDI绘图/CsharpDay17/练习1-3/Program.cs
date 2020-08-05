using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("请输入你的考试成绩");
            //int score = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1; i <= 9; i++)
            //{
            //    for (int j = 1; j <=9 ; j++)
            //    {
            //        Console.Write("{0}*{1}={2}\t", i, j, i * j);
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadKey();

            //定义长度50的数组,随机给数组赋值,并可以让用户输入一个数字n,按一行n个数输出数组 
            //int[]  array = new int[50];     Random r = new Random();  r.Next();
            //int[] nums = new int[50];
            //Random r = new Random();
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    int rNumber = r.Next(0, 10);
            //    nums[i] = rNumber;
            //}
            //Console.WriteLine("请输入一个数字");
            //int n = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.Write(nums[i]+"\t");
            //    if ((i + 1) % n == 0)
            //    {
            //        Console.WriteLine();
            //    }
            //}
            //Console.ReadKey();

            //编写一个函数,接收一个字符串,把用户输入的字符串中的第一个字母转换成小写然后返回(命名规范  骆驼命名) 
            //name       s.SubString(0,1)      s.SubString(1);
            //string s = "AAbcd";
            //string sNew = ProcessStr(s);
            //Console.WriteLine(sNew);
            //Console.ReadKey();

            int n1 = 10;
            int n2 = 20;

            //n1 = n1 - n2;//n1=-10 n2=20
            //n2 = n1 + n2;//n1=-10 n2=10
            //n1 = n2 - n1;//
            //int temp = n1;
            //n1 = n2;
            //n2 = temp;
            Change(ref n1, ref n2);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.ReadKey();
        }
        public static void Change(ref int n1,ref  int n2)
        {
            int temp = n1;
            n1 = n2;
            n2 = temp;
        }


        public static string ProcessStr(string str)
        {
            string s = str.Substring(0, 1).ToLower();
            return s + str.Substring(1);
        }

        public static string GetLevel(int score)
        {
            string level = null;
            switch (score / 10)
            {
                case 10:
                case 9: level = "优";
                    break;
                case 8: level = "良";
                    break;
                case 7: level = "中";
                    break;
                case 6: level = "差";
                    break;
                default: level = "不及格";
                    break;
            }
            #region if else-if的写法
            //if (score >= 90)
            //{
            //    level = "优";
            //}
            //else if (score >= 80)
            //{
            //    level = "良";
            //}
            //else if (score >= 70)
            //{
            //    level = "中";
            //}
            //else if (score >= 60)
            //{
            //    level = "差";
            //}
            //else
            //{
            //    level = "不及格";
            //} 
            #endregion
            return level;
        }
    }
}
