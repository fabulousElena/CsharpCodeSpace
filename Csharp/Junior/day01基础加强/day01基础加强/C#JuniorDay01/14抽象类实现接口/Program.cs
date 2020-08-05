using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14抽象类实现接口
{
    class Program
    {
        static void Main(string[] args)
        {
            I1 i = new PersonDaughter();//new PersonSon(); //new Person();
            i.Test();
            Console.ReadKey();
        }
    }

    abstract class Person:I1
    {
        public void Test()
        {
            Console.WriteLine("抽象类实现接口");
        }
    }

    class PersonSon : Person
    { }

    class PersonDaughter : Person
    { }


    interface I1
    {
        void Test();
    }
}
