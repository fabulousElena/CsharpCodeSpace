using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09字符串的常用方法
{
    class Program
    {
        static void Main(string[] args)
        {
            //string s = null;
            //if (string.IsNullOrEmpty(s))
            //{
            //    Console.WriteLine("是的");
            //}
            //else
            //{
            //    Console.WriteLine("不是");
            //}

            //string str = "abcdefg";

            //Console.WriteLine(str[5]);
            //Console.ReadKey();
            //char[] chs = str.ToCharArray();
            //chs[2] = 'z';
            //foreach (char item in chs)
            //{
            //    Console.WriteLine(item);
            //}
            ////char数组---->字符串
            //str = new string(chs);

            //string str = "abCDEfg";
            //Console.WriteLine(str.ToUpper());
            //Console.WriteLine(str.ToLower());

            //string s1 = "aBc";
            //string s2 = "Abc";
            //if (s1 == s2)
            //{
            //    Console.WriteLine("相等");
            //}
            //else
            //{
            //    Console.WriteLine("不相等");
            //}
            //Console.ReadKey();


            //if (s1.Equals(s2))
            //{
            //    Console.WriteLine("相等");
            //}
            //else
            //{
            //    Console.WriteLine("不相等");
            //}
            //Console.ReadKey();
            //Console.ReadKey();


            //string str = "老毕吃了一顿饭，结果老毕火了";
            ////int index = str.IndexOf("老",11);
            ////Console.WriteLine(index);
            //int index = str.LastIndexOf("123");
            //Console.WriteLine(index);
            //Console.ReadKey();


            //string str = "老毕吃了一顿饭,结果老毕火了";
            //int index = str.IndexOf(",");
            //string strNew = str.Substring(index + 1);
            //Console.WriteLine(strNew);

            //string str = "张  ,,--三   ,李,,--四  a  ";
            //string[] strNew = str.Split(new char[] { ',', ' ', '-' },StringSplitOptions.RemoveEmptyEntries);
            ////字符串--->char类型的数组 ToCharArray()
            ////字符串--->string类型的数组
            //Console.ReadKey();

            //Trim() TrimEnd() TrimStart()

            //string s = "   张   ,,,--    三 ,,,--   ";

            //Console.Write(s.Trim(' ',',','-'));


            //string[] names = { "金秀贤", "金贤秀", "金正日", "金正恩" };
            ////金秀贤|金贤秀|金正日|金正恩

            //string res = string.Join("|", 'c', "张三", 100, 3.14, true, 5000m);
            //Console.WriteLine(res);
            //Console.ReadKey();
            //string res = string.Empty;
            //for (int i = 0; i < names.Length - 1; i++)
            //{
            //    res += names[i] + "|";
            //}
            //Console.WriteLine(res + names[names.Length - 1]);

            Console.WriteLine("请输入你要回复的内容");
            string contents = Console.ReadLine();
            //判断contents中是否包含敏感词
            if (contents.Contains("老赵"))
            {
                contents = contents.Replace("老赵", "****");
            }
            Console.WriteLine(contents);
            Console.ReadKey();
        }
    }
}
