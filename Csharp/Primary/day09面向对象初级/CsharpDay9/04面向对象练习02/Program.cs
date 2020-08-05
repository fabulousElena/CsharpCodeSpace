using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04面向对象练习02
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("张三",18,'男');
            s.SayHello();
            Console.ReadKey();
        }
    }
}
