using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01复习
{
    class Program
    {
        static void Main(string[] args)
        {
            Person zsPerson = new Person("张三",-18,'中');
            zsPerson.SayHello();
            Person.SayHelloTwo();
            Console.ReadKey();
            //new：1、在内存中开辟一块空间  2、在开辟的空间中创建对象 3、调用对象的构造函数
        }
    }
}
