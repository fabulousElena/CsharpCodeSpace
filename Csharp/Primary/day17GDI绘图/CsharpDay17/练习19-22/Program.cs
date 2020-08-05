using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习19_22
{
    class Program
    {
        static void Main(string[] args)
        {
            //string str = "患者：“大夫，我咳嗽得很重。”     大夫：“你多大年记？”     患者：“七十五岁。”     大夫：“二十岁咳嗽吗”患者：“不咳嗽。”     大夫：“四十岁时咳嗽吗？”     患者：“也不咳嗽。”     大夫：“那现在不咳嗽，还要等到什么时咳嗽？”";
            //int index = str.IndexOf("咳嗽");
            //int i = 1;
            //Console.WriteLine("第1次出现咳嗽的位置是{0}", index);
            //while (index != -1)
            //{
            //    i++;
            //    index = str.IndexOf("咳嗽", index + 1);
            //    if (index == -1)
            //    {
            //        break;
            //    }
            //    Console.WriteLine("第{0}次找到咳嗽的位置是{1}",i,index);
            //}
            //Console.ReadKey();



            //将字符串"  hello      world,你  好 世界   !    "
            //两端空格去掉，并且将其中的所有其他空格都替换成一个空格，
            //输出结果为："hello world,你 好 世界 !"。
            //string s = "  hello      world,你  好 世界   !    ";
            //s = s.Trim();
            //string[] sNew = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            //string strNew = string.Join(" ", sNew);
            //Console.Write(strNew);
            //Console.ReadKey();



            //存储用户输入的姓名
            //List<string> list = new List<string>();
            //while (true)
            //{
            //    Console.WriteLine("请输入学员姓名，输入quit退出");
            //    string name = Console.ReadLine();
            //    if (name != "quit")
            //    {
            //        list.Add(name);
            //    }
            //    else
            //    {
            //        break;
            //    }
            //}
            //int i = 0;
            //Console.WriteLine("您刚才一共录入了{0}个人的成绩，分别是:",list.Count);
            //foreach (string item in list)
            //{
            //    if (item[0] == '王')
            //    {
            //        i++;
            //    }
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("姓王的同学的个数一共有{0}个",i);
            //Console.ReadKey();



            //请将字符串数组{ "中国", "美国", "巴西", "澳大利亚", "加拿大" }中的内容反转。然后输出反转后的数组。不能用数组的Reverse()方法。

            //string[] names = { "中国", "美国", "巴西", "澳大利亚", "加拿大" };
            //for (int i = 0; i < names.Length / 2; i++)
            //{
            //    string temp = names[i];
            //    names[i] = names[names.Length - 1 - i];
            //    names[names.Length - 1 - i] = temp;
            //}


            //foreach (var item in names)
            //    Console.WriteLine(item);
            //if(...)
            //{.....}

            //创建一个Person类，属性：姓名、性别、年龄；方法：SayHi() 。
            //再创建一个Employee类继承Person类，扩展属性Salary,重写SayHi方法。
            Console.ReadKey();
        }
    }

    public class Person
    {
        public string Name
        {
            get;
            set;
        }

        public char Gender
        {
            get;
            set;
        }

        public int Age
        {
            get;
            set;
        }


        public virtual void SayHi()
        {
            Console.WriteLine("父类打招呼");
        }
    }


    public class Employee : Person
    {
        public double Salary
        {
            get;
            set;
        }

        public override void SayHi()
        {
            Console.WriteLine("子类重写父类");
        }
    }

}
