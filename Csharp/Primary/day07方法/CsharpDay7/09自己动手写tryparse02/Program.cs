using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09自己动手写tryparse02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个数字");
            string s = Console.ReadLine();
            bool b = MyTryParse(s, out int a);
            Console.WriteLine(b);
            Console.WriteLine(s);
            Console.WriteLine(a);
            Console.ReadKey();

        }

        public static bool MyTryParse(string s, out int a)
        {

            try
            {
                a = Convert.ToInt32(s);
                return true;

            }
            catch
            {
                Console.WriteLine("您输入的不是纯数字");
                a = 0;
                return false;
            }

        }
    }
}
