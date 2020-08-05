using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09do_while循环
{
    class Program
    {
        static void Main(string[] args)
        {
            //明天小兰就要登台演出了,老师说再把明天的演出的歌曲唱一遍,
            //如果满意,小兰就可以回家了.否则就需要再练习一遍,直到老师满意为止.(y/n)

            //循环体:小兰唱了一遍 问老师 满意么？老师回答
            //循环条件:老师不满意
            //Console.WriteLine("老师我唱的你满意么？");
            //string answer = Console.ReadLine();
            //while (answer == "no")
            //{
            //    Console.WriteLine("老师，我再唱一遍，你满意么？");
            //    answer = Console.ReadLine();
            //}
            //遇见这种首先执行一遍循环体，拿着执行后的结果再去判断是否执行循环的循环。
            //我们推荐使用do-while循环。
            //string answer = "";
            //do
            //{
            //    Console.WriteLine("老师，我唱的你满意么？yes/no");
            //    answer=Console.ReadLine();
            //}while(answer=="no");
            //Console.WriteLine("OK,放学回家~~~");
            //Console.ReadKey();


            //要求用户输入用户名和密码，只要不是admin、888888就一直提示用户名或密码错误,请重新输入
            //string name = "";
            //string pwd = "";
            //do
            //{
            //    Console.WriteLine("请输入用户名");
            //    name = Console.ReadLine();
            //    Console.WriteLine("请输入密码");
            //    pwd = Console.ReadLine();
            //} while (name != "admin" || pwd != "888888");
            //Console.WriteLine("登陆成功");
            //Console.ReadKey();


            //练习3:不断要求用户输入学生姓名,输入q结束.

            string name = "";
            while (name != "q")
            {
                Console.WriteLine("请输入学员姓名,输入q结束");
                name = Console.ReadLine();
            }
            Console.ReadKey();

            //do
            //{
            //    Console.WriteLine("请输入学员姓名，输入q结束");
            //    name = Console.ReadLine();
            
            //}while(name!="q");
            //Console.ReadKey();


        }
    }
}
