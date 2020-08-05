using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06for循环的嵌套
{
    class Program
    {
        static void Main(string[] args)
        {
            

            //当遇到某个事情要做一遍，而另外一个事情要做N遍的时候
            //for循环的嵌套
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.WriteLine("Hello World i循环了{0}次，j循环了{1}次",i,j);
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
