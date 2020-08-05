using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09抽象类特点
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    abstract class Person
    {
        public abstract int SayHello(string name);
        // public abstract void Test();
    }

    class Student : Person
    {
        public override int SayHello(string name)
        {
            return 0;
        }
    }
}
