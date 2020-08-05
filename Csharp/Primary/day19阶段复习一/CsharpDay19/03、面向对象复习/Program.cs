using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_面向对象复习
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person('中');
            //给对象的每个属性赋值的过程称之为对象的初始化
            p.Name = "张三";
            p.Age = -10;
            //p.Gender = '中';
            p.SayHello();
            Console.ReadKey();
        }
    }
}
