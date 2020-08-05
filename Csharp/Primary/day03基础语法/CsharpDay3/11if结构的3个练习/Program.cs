using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11if结构的3个练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //让用户输入年龄,如果输入的年龄大于23(含)岁,则给用户显示你到了结婚的年龄了.

            //Console.WriteLine("请输入你的年龄");
            //int age = Convert.ToInt32(Console.ReadLine());
            //bool b = age >= 23;
            //if (b)
            //{
            //    Console.WriteLine("你可以结婚啦");
            //}
            //Console.ReadKey();

            //如果老苏的(chinese  music)
            //语文成绩大于90并且音乐成绩大于80
            //语文成绩等于100并且音乐成绩大于70,则奖励100元.
            //Console.WriteLine("请输入老苏的语文成绩");
            //int chinese = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入老苏的音乐成绩");
            //int music = Convert.ToInt32(Console.ReadLine());

            //bool b = (chinese > 90 && music > 80) || (chinese == 100 && music > 70);

            //if (b)
            //{
            //    Console.WriteLine("奖励100元");
            //}
            //Console.ReadKey();

            //让用户输入用户名和密码,如果用户名为admin,密码为888888,则提示登录成功.
            Console.WriteLine("请输入用户名");
            string name = Console.ReadLine();
            Console.WriteLine("请输入密码");
            string pwd = Console.ReadLine();

            if (name == "admin" && pwd == "mypass")
            {
                Console.WriteLine("登陆成功");
            }
            Console.ReadKey();


        }
    }
}
