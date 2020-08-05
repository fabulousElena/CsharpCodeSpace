using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _07正则表达式练习02
{
    class Program
    {
        static void Main(string[] args)
        {
           bool b =  Regex.IsMatch("pig","p[a-z]g");
            Console.WriteLine(b);
            Console.ReadKey();
        }
    }
}
