using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02方法的调用问题
{
    class Program
    {
        //字段 属于类的字段
        public static int _number = 10;


        static void Main(string[] args)
        {
            //  int b = 10;
            int a = 3;
            int res = Test(a);
            Console.WriteLine(res);
            // Console.WriteLine(_number);
            Console.ReadKey();
        }
        public static int Test(int a)
        {
            a = a + 5;
            return a;
            //  Console.WriteLine(_number);
        }


        public static void TestTwo()
        {
            // Console.WriteLine(_number);
        }
    }
}
