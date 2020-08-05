using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08判断闰年
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("请输入要判断的年份");
            //int year = Convert.ToInt32(Console.ReadLine());
            ////年份能够被400整除.(2000)
            ////年份能够被4整除但不能被100整除.(2008)


            ////逻辑与的优先级要高于逻辑或
            //bool b = (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);

            //Console.WriteLine(b);
            //Console.ReadKey();


            // & 当左边不成立的时候，依然计算右边的，效率比较低
            // && 当左边不成立的时候，就自动跳过右边的了。
            //  bool b = 5 < 3 && 5 > 3;

            //bool b = 5 > 3 || 4 < 3;

            //判断闰年
            //闰年：能够被400整除 ； 能够被4整除但是不能够被100整除
            Console.WriteLine("请输入要查询的年份");
            int i = Convert.ToInt32(Console.ReadLine());
            if ((i % 400 == 0) || (i % 4 == 0 && i % 100 != 0)) {
                Console.WriteLine(i + "是闰年");
                Console.ReadKey();
            } else {
                Console.WriteLine(i + "不是闰年");
                Console.ReadKey();
            }

        }
    }
}
