using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06字符串的各种方法
{
    class Program
    {
        static void Main(string[] args)
        {
            //练习一:随机输入你心中想到的一个名字，然后输出它的字符串长度  Length:可以得字符串的长度
            //Console.WriteLine("请输入你心中想的那个人的名字");
            //string name = Console.ReadLine();
            //Console.WriteLine("你心中想的人的名字的长度是{0}",name.Length);
            //Console.ReadKey();


            //Console.WriteLine("请输入你喜欢的课程");
            //string lessonOne = Console.ReadLine();
            ////将字符串转换成大写
            ////  lessonOne = lessonOne.ToUpper();
            ////将字符串转换成小写形式
            //// lessonOne = lessonOne.ToLower();
            //Console.WriteLine("请输入你喜欢的课程");
            //string lessonTwo = Console.ReadLine();
            ////   lessonTwo = lessonTwo.ToUpper();
            ////   lessonTwo = lessonTwo.ToLower();
            //if (lessonOne.Equals(lessonTwo,StringComparison.OrdinalIgnoreCase))
            //{
            //    Console.WriteLine("你们俩喜欢的课程相同");
            //}
            //else
            //{
            //    Console.WriteLine("你们俩喜欢的课程不同");
            //}
            //Console.ReadKey();


            //string s = "a b   dfd _   +    =  ,,, fdf ";
            ////分割字符串Split
            //char[] chs = { ' ', '_', '+', '=', ',' };
            //string[] str = s.Split(chs,StringSplitOptions.RemoveEmptyEntries);
            //Console.ReadKey();


            //练习：从日期字符串（"2008-08-08"）中分析出年、月、日；2008年08月08日。
            //让用户输入一个日期格式如:2008-01-02,你输出你输入的日期为2008年1月2日

            //string s = "2008-08-08";
            ////  char[] chs = { '-' };
            //string[] date = s.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
            //Console.WriteLine("{0}年{1}月{2}日", date[0], date[1], date[2]);
            //Console.ReadKey();
            //老赵

            //string str = "国家关键人物老赵";
            //if (str.Contains("老赵"))
            //{
            //    str = str.Replace("老赵", "**");
            //}
            //Console.WriteLine(str);
            //Console.ReadKey();


            //Substring 截取字符串

            //string str = "今天天气好晴朗，处处好风光";
            //str = str.Substring(1,2);
            //Console.WriteLine(str);
            //Console.ReadKey();

            //string str = "今天天气好晴朗，处处好风光";
            //if (str.EndsWith("风"))
            //{
            //    Console.WriteLine("是的");
            //}
            //else
            //{
            //    Console.WriteLine("不是的");
            //}
            //Console.ReadKey();


            //string str = "今天天天气好晴朗，天天处天好风光";
            //int index = str.IndexOf('哈',2);
            //Console.WriteLine(index);
            //Console.ReadKey();


            //string str = "今天天气好晴朗，处处好风光";
            //int index = str.LastIndexOf('天');
            //Console.WriteLine(index);
            //Console.ReadKey();


            ////LastIndexOf  Substring
            ////从最后一次出现斜线的位置，截取文件名   然后进行比对。
            //string path = @"c:\a\b\c苍\d\e苍\f\g\\fd\fd\fdf\d\vfd\苍老师苍.wav";
            //int index = path.LastIndexOf("\\");
            //path = path.Substring(index+1);
            //Console.WriteLine(path);
            //Console.ReadKey();


            //trim 去空格
            // string str = "            hahahah          ";
            //// str = str.Trim();
            // //str = str.TrimStart();
            // str = str.TrimEnd();
            // Console.Write(str);
            // Console.ReadKey();

            //string str = "fdsfdsfds";
            //if (string.IsNullOrEmpty(str))
            //{
            //    Console.WriteLine("是的");
            //}
            //else
            //{
            //    Console.WriteLine("不是");
            //}
            //string[] names = { "张三", "李四", "王五", "赵六", "田七" };
            ////张三|李四|王五|赵六|田七
            //string strNew = string.Join("|", "张三","李四","王五","赵六","田七");
            //Console.WriteLine(strNew);
            //Console.ReadKey();




        }
    }
}
