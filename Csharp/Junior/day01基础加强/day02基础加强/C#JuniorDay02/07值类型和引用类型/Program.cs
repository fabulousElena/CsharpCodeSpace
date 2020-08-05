using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07值类型和引用类型
{
    class Program
    {
        static void Main(string[] args)
        {
        //    int number = 10;
        //    Test( number);//实参
        //    Console.WriteLine(number);
        //    Console.ReadKey();

            //不管是实参还是形参，在内存中都是开辟了空间的

            //Person zsPerson = new Person();
            //zsPerson.Name = "张三";
            //Person lsPerson = zsPerson;
            //lsPerson.Name = "李四";
            //Console.WriteLine(zsPerson.Name);
            //Console.WriteLine(lsPerson.Name);
            //Console.ReadKey();

            Person zsPerson = new Person();
            zsPerson.Name = "张三";
            Test(zsPerson);
            Console.WriteLine(zsPerson.Name);
            Console.ReadKey();

        }

        static void Test(Person p)
        {
            p.Name = "王五";
            Person p2 = new Person();
            p2.Name = "田七";
            p = p2;
        }

     

    }

    class Person
    {
        public string Name { get; set; }
    }
}
