using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _07正则表达式匹配练习
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine(Regex.IsMatch("p1g", "p[a-z0-9]g"));

            //Match mc = Regex.Match("今天是2015年4月18号", @"\d{1,4}");
            //if (mc.Success)
            //{
            //    Console.WriteLine(mc.Value);
            //}
            //MatchCollection mc = Regex.Matches("今天是2015年4月18号", @"\d{1,4}");

            //foreach (Match item in mc)
            //{
            //    if (item.Success)
            //    {
            //        Console.WriteLine(item.Value);
            //    }
            //}
            //string str = Regex.Replace("今天是2015年4月18号", @"\d{4}", "新年好哇");

            //Console.WriteLine(str);

            //提取分组
            string regex = @"(\w+)@(\w+)((\.\w+){1,2})";

            Match mc = Regex.Match("abc123@qq.com.cn", regex);

            if (mc.Success)
            {

                //Console.WriteLine(mc.Groups[0]);当前匹配的字符串
                Console.WriteLine(mc.Groups[1].Value);
                Console.WriteLine(mc.Groups[2].Value);
                Console.WriteLine(mc.Groups[3].Value);
            }


            Console.ReadKey();
        }
    }
}
