using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19访问修饰符
{
    class Program
    {
        static void Main(string[] args)
        {
            //public private internal protected protected internal
            //public:在哪都可以访问
            //private:私有的，只能在当前类的内部进行访问
            //internal:只能在当前程序集中访问。
            //protected：受保护的，可以在当前类以及该类的子类中访问

            Person p = new Person();

        }
    }

    class Person
    {
        public int Age { get; set; }
    }
    public class Student : Person
    {

    }
}
