using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08类型转换
{
    class Program
    {
        static void Main(string[] args)
        {
            //使用Convert进行转换 成功了就成了， 失败了就抛异常
            // int numberOne = Convert.ToInt32("123abc");

            // int number = int.Parse("123abc");

            //Console.WriteLine(number);
            int number = 100;
            //参数 返回值
            bool b = int.TryParse("123abc", out number);
            Console.WriteLine(b);
            Console.WriteLine(number);
            //方法 或者 函数？
            Console.ReadKey();
        }
    }
}
