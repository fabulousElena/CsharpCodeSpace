using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15方法练习02
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("请输入第一个数字");
                string s = Console.ReadLine();
                int sInt1 = 0;
                bool b2 = ConvertStringToInt(s, out sInt1);

                Console.WriteLine("请输入第二个数字");
                string s2 = Console.ReadLine();
                int sInt2 = 0;
                bool b1 = ConvertStringToInt(s2, out sInt2);

                //Console.WriteLine(sInt1 + " > " + sInt2);

                if (sInt2 <= sInt1)
                {
                    Console.WriteLine("第二个值并不大于第一个值，请按回车重新输入");
                    Console.ReadKey();
                    continue;
                }
                else if (!(b1 && b2))
                {
                    Console.WriteLine("输入的不是纯数字，请按回车重新输入");
                    Console.ReadKey();
                    continue;
                }
                else
                {

                    int sum = GetSum(sInt1, sInt2);
                    Console.WriteLine(sInt1 + "到" + sInt2 + "之间的整数和是" + sum);
                    break;
                }

            }






            Console.WriteLine();
            Console.ReadKey();
        }
        /// <summary>
        /// 获取 a -- b之间的所有整数的和
        /// </summary>
        /// <param name="a">起始位</param>
        /// <param name="b">结束位</param>
        /// <returns></returns>
        public static int GetSum(int a, int b)
        {
            int sum = 0;
            for (int i = a; i < b; i++)
            {
                sum = sum + i;
            }

            return sum - a;
        }

        /// <summary>
        /// 将控制台输入的字符串转化为正确的数字
        /// </summary>
        /// <param name="s">接收的字符串</param>
        /// <returns></returns>
        public static bool ConvertStringToInt(string s, out int i)
        {
            i = 0;
            try
            {
                i = Convert.ToInt32(s);
                return true;
            }
            catch
            {

                return false;
            }

        }
    }
}
