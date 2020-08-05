using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace _01复习
{
    class Program
    {
        static void Main(string[] args)
        {
            //单例模式 保证对象在应用程序的唯一性

            //简单工厂 将所有的子类都当做父类来看

            //字符串 不可变性 GC


            //1.判断用户输入的是否是邮箱.
            //while (true)
            //{
            //    Console.WriteLine("请输入一个字符串");
            //    string input = Console.ReadLine();
            //    //@ .com .cn

            //    if (input.Contains("@") && input.Contains(".com") || input.Contains(".cn"))
            //    {
            //        Console.WriteLine("是邮箱");
            //    }
            //    else
            //    {
            //        Console.WriteLine("不是邮箱");
            //    }
            //    Console.ReadKey();
            //}



            // { "马龙", "迈克尔乔丹", "雷吉米勒", "蒂姆邓肯", "科比布莱恩特" },请输出最长的字符串。

            //string[] names = { "马龙", "迈克尔乔丹", "雷吉米勒", "蒂姆邓肯", "科比布莱恩特" };
            //string max = names[0];

            //for (int i = 0; i < names.Length; i++)
            //{
            //    if (names[i].Length > max.Length)
            //    {
            //        max = names[i];
            //    }
            //}
            //Console.WriteLine(max);

            //请将字符串数组{ "中国", "美国", "巴西", "澳大利亚", "加拿大" }中的内容反转。然后输出反转后的数组
            //string[] contries = { "中国", "美国", "巴西", "澳大利亚", "加拿大" };
            ////写函数改变数组不需要写返回值
            //ProCountries(contries);

            //foreach (string item in contries)
            //{
            //    Console.WriteLine(item);
            //}

            //有如下字符串：【"患者：“大夫，我咳嗽得很重。”     大夫：“你多大年记？”     患者：“七十五岁。”     大夫：“二十岁咳嗽吗”患者：“不咳嗽。”     大夫：“四十岁时咳嗽吗？”     患者：“也不咳嗽。”     大夫：“那现在不咳嗽，还要等到什么时咳嗽？”"】。需求：请统计出该字符中“咳嗽”二字的出现次数，以及每次“咳嗽”出现的索引位置。


            //string str = "患者：“大夫，我咳嗽得很重。”     大夫：“你多大年记？”     患者：咳咳咳，七十咳咳咳咳五岁。”     大夫：“二十岁咳嗽吗”患者：“不咳嗽。”     大夫：“四十嗽岁嗽时嗽咳嗽吗？”     患者：“也不咳嗽。”     大夫：“那现在不咳嗽，还要等到什么时咳嗽？”";

            //int index = str.IndexOf("咳嗽");
            //Console.WriteLine("第1次出现咳嗽的位置是{0}", index);
            ////我们每一次都应该从上一次找到的位置加1开始往后找
            //int count = 1;
            //while (true)
            //{
            //    index = str.IndexOf("咳嗽", index + 1);
            //    count++;
            //    if (index == -1)
            //    {
            //        break;
            //    }
            //    Console.WriteLine("第{0}次出现咳嗽的位置是{1}",count,index);
            //}
            //Console.ReadKey();




            //练习8：求员工工资文件中，员工的最高工资、最低工资、平均工资

            List<int> list = new List<int>();

            string[] lines = File.ReadAllLines(@"C:\Users\SpringRain\Desktop\工资.txt", Encoding.Default);
            for (int i = 0; i < lines.Length; i++)
            {
                string[] temp = lines[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                list.Add(int.Parse(temp[1]));
            }

            Console.WriteLine(list.Max());
            Console.WriteLine(list.Min());
            Console.WriteLine(list.Sum());
            Console.WriteLine(list.Average());

            Console.ReadKey();





        }


        static void ProCountries(string[] c)
        {
            for (int i = 0; i < c.Length / 2; i++)
            {
                string temp = c[i];
                c[i] = c[c.Length - 1 - i];
                c[c.Length - 1 - i] = temp;
            }
        }
    }
}
