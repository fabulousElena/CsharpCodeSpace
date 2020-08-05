using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_字符串练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //课上练习1：接收用户输入的字符串，将其中的字符以与输入相反的顺序输出。"abc"→"cba"

            //string str = "abcdefg";
            //char[] chs = new char[str.Length];

            //foreach (var item in chs)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadKey();

            //Console.WriteLine("请输入一个字符串");
            //string str = Console.ReadLine();
            //char[] chs = new char[str.Length];
            //int i = 0;
            //foreach (var item in str)
            //{
            //    chs[i] = item;
            //    i++;
            //}
            //foreach (var item in chs)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadKey();
            //char[] chs = str.ToCharArray();
            //for (int i = 0; i < chs.Length/2; i++)
            //{
            //    char temp = chs[i];
            //    chs[i] = chs[chs.Length - 1 - i];
            //    chs[chs.Length - 1 - i] = temp;
            //}

            //str = new string(chs);
            //Console.WriteLine(str);

            //Array.Reverse(chs);
            //str = new string(chs);
            //Console.WriteLine(str);

            ////课上练习2：接收用户输入的一句英文，将其中的单词以反序输出。      “I love you"→“i evol uoy"
            //string str = "I Love You";// I evoL uoY
            //string s2 = null;
            //string[] strNew = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //for (int i = 0; i < strNew.Length; i++)
            //{
            //    string s = ProcessStr(strNew[i]);
            //    s2 += s+" ";

            //}
            //Console.WriteLine(s2);

            //Console.ReadKey();

            //课上练习3：”2012年12月21日”从日期字符串中把年月日分别取出来，打印到控制台
            //string date = "2012年12月21日";
            //string[] dateNew = date.Split(new char[] { '年', '月', '日' }, StringSplitOptions.RemoveEmptyEntries);
            //Console.WriteLine("{0}--{1}--{2}",dateNew[0],dateNew[1],dateNew[2]);
            //Console.ReadKey();




            //  练习5：123-456---789-----123-2把类似的字符串中重复符号去掉，
            //既得到123-456-789-123-2. split()、
            //string str = "123-456---789-----123-2";
            //string[] strNew = str.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
            //str = string.Join("-", strNew);
            //Console.WriteLine(str);
            //Console.ReadKey();

            string[] str = File.ReadAllLines("员工工资.txt", Encoding.Default);
            int max = int.MinValue;
            int min = int.MaxValue;
            int sum = 0;
            for (int i = 0; i < str.Length; i++)
            {
                //张三,100
                string[] strNew = str[i].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                if (int.Parse(strNew[1]) > max)
                {
                    max = int.Parse(strNew[1]);
                }
                if (int.Parse(strNew[1]) < min)
                {
                    min = int.Parse(strNew[1]);
                }
                sum += int.Parse(strNew[1]);
            }
            Console.WriteLine("工资最高是{0},最低是{1},平均薪资是{2}",max,min,sum/str.Length);
           

            Console.ReadKey();


        }


        public static string ProcessStr(string str)
        {
            char[] chs = str.ToCharArray();
            for (int i = 0; i < chs.Length / 2; i++)
            {
                char temp = chs[i];
                chs[i] = chs[chs.Length - 1 - i];
                chs[chs.Length - 1 - i] = temp;
            }
            return new string(chs);
        }
    }
}
