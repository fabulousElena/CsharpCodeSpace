using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03判断闰年02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入年份查询闰年");

            bool b = int.TryParse(Console.ReadLine(), out int a);

            if (b)
            {
                JudgeYear(a);
            }
            else {
                Console.WriteLine("请输入正确的年份。");
            }

            Console.ReadKey();

        }

        public static void JudgeYear(int year)
        {
            if ((year % 400) == 0 || ((year % 4 == 0) && (year % 100 != 0)))
            {
                Console.WriteLine(year + "是闰年");
            }
            else
            {
                Console.WriteLine(year + "不是闰年");
            }

        }
    }
}
