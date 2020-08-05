using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02面向对象复习
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Age = -110;
            p.Name = "zhangsan";
            p.Gender = '中';
            p.SayHello();

            Person p2 = new Person();
            p2.Name = "李四";
            p2.Age = 88;
            p2.Gender = '女';
            p2.SayHello();
            Console.ReadKey();
        }
    }
}
