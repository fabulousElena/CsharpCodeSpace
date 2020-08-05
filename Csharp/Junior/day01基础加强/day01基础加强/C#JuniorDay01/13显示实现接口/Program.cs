using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13显示实现接口
{
    class Program
    {
        static void Main(string[] args)
        {
            I1 i = new Person();
            i.Test();
            Console.ReadKey();
        }
    }
    class Person:I1
    {
        public void Test()
        {
            Console.WriteLine("这个Test函数是属于Person的");
        }

        //显示实现接口：告诉编译器 这个函数才是接口的  不是类的
        void I1.Test()
        {
            Console.WriteLine("显示实现接口的Test函数");
        }
    }

    interface I1
    {
        void Test();
    }
}
