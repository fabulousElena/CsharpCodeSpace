using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06赋值运算符
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            n = 50;//重新赋值，一旦给一个变量重新赋值，那么老值就不存在了，取而代之的新值。
            Console.WriteLine(n);
            Console.ReadKey();
        }
    }
}
