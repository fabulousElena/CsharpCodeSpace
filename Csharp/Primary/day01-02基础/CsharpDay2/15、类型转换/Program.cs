using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_类型转换
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 10;
            int n2 = 3;
            double d = n1*1.0 / n2;
            Console.WriteLine("{0:0.0000}",d);
            Console.ReadKey();


            ////int n1 = 5;
            //double n1 = 5;
            //int n2 = 2;
            //double d = n1 / n2;
            //Console.WriteLine(d);
            //Console.ReadKey();
        }
    }
}
