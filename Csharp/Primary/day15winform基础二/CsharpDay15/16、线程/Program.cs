using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _16_线程
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.Sleep(3000);
            Console.WriteLine("Hello World");
            Console.ReadKey();
        }
    }
}
