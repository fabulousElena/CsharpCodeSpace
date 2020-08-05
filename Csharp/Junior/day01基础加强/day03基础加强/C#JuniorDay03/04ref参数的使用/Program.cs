using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04ref参数的使用
{
    class Program
    {
        static void Main(string[] args)
        {
            double salary = 5000;
            JiangJin(ref salary);
            Console.WriteLine(salary);
            Console.ReadKey();
        }

        static void JiangJin(ref double s)
        {
            s += 500;
        }
    }
}
