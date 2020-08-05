using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Convert类型转换
{
    class Program
    {
        static void Main(string[] args)
        {
            // //提示用户输入一个数字 接收 并且向控制台打印用户输入的这个数字的2倍
            // Console.WriteLine("请输入一个数字");
            //// string strNumber = Console.ReadLine();
            // //将用户输入的字符串转换成int或者double类型
            // double number = Convert.ToDouble(Console.ReadLine());
            // Console.WriteLine(number*2);
            // Console.ReadKey();

            Console.WriteLine("请输入一个数字，然后你可以得到他的两倍");
            string s = Console.ReadLine();
            double d = Convert.ToDouble(s);
            Console.WriteLine(d*2);
            Console.ReadKey();

        }
    }
}
