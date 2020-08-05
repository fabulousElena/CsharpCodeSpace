using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02面向对象复习02
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person
            {
                Name = "张三",
                Age = 999,
                Gender = '男'

            };

            Console.WriteLine(p.Name + p.Age + "岁" + p.Gender);
            Console.ReadKey();


        } 
    }
}
