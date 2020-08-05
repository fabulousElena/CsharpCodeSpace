using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09for循环的3个练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //练习1:循环录入5个人的年龄并计算平均年龄,
            //如果录入的数据出现负数或大于100的数,立即停止输入并报错.
            //int sum = 0;
            //bool b = true;
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("请输入第{0}个人的成绩",i+1);
            //    try
            //    {
            //        int age = Convert.ToInt32(Console.ReadLine());
            //        if (age >= 0 && age <= 100)
            //        {
            //            sum += age;
            //        }
            //        else
            //        {
            //            Console.WriteLine("输入的年龄不在正确范围内，程序退出！！！");
            //            b = false;
            //            break;
            //        }
            //    }
            //    catch
            //    {
            //        Console.WriteLine("输入的年龄不正确，程序退出！！！");
            //        b = false;
            //        break;
            //    }
            //}
            //if (b)
            //{
            //    Console.WriteLine("5个人的平均年龄是{0}", sum / 5);
            //}
            //Console.ReadKey();


       //     练习2：在while中用break实现要求用户一直输入用户名和密码，
            //只要不是admin、88888就一直提示要求重新输入,如果正确则提登录成功.
            //string name = "";
            //string pwd = "";
            //while (true)
            //{
            //    Console.WriteLine("请输入用户名");
            //    name = Console.ReadLine();
            //    Console.WriteLine("请输入密码");
            //    pwd = Console.ReadLine();

            //    if (name == "admin" && pwd == "888888")
            //    {
            //        Console.WriteLine("登陆成功");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("用户名或密码错误，请重新输入");
            //    }
            //}
            //Console.ReadKey();


            //1~100之间的整数相加，得到累加值大于20的当前数
            //(比如:1+2+3+4+5+6=21)结果6 sum>=20  i
            int sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                sum += i;
                if (sum >= 20)
                {
                    Console.WriteLine("加到{0}的时候，总和大于了20",i);
                    break;
                }
            }
            Console.ReadKey();


        }
    }
}
