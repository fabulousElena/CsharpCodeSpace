using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03静态和非静态的区别
{
    class Program
    {
        static void Main(string[] args)
        {
            //调用实例成员
            Person p = new Person();
            p.M1();//实例方法
            Person.M2();//静态方法
           // Student s = new Student();


            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
