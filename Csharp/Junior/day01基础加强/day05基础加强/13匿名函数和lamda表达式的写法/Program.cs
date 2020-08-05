using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _13匿名函数和lamda表达式的写法
{
    public delegate void Del1();

    public delegate void Del2(string s);

    public delegate int Del3(string s);
    class Program
    {
        static void Main(string[] args)
        {
            // Del1 del1 = Test1;
            // Del1 del1 = delegate() { };
            //=>goes to:去执行
            //Del1 del1 = () => { };

            //Del2 del2 = Test1;

            //Del2 del2 = delegate(string name) { };


            //  Del2 del2 = (name) => { };

            //Del3 del3 = Test1;

            //Del3 del3 = delegate(string name) { return 100; };

            Del3 del3 = (name) => { return 100; };

        }

        static int Test1(string s)
        {
            return 100;
        }
    }
}
