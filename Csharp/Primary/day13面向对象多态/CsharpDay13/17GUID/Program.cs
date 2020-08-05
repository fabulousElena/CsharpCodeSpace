using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17GUID
{
    class Program
    {
        static void Main(string[] args)
        {
            //产生一个不会重复的编号
            Console.WriteLine(Guid.NewGuid().ToString());
            Console.WriteLine(Guid.NewGuid().ToString());
            Console.WriteLine(Guid.NewGuid().ToString());
            Console.WriteLine(Guid.NewGuid().ToString());
            Console.WriteLine(Guid.NewGuid().ToString());
            Console.ReadKey();
        }
    }
}
