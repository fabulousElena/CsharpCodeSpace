using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05for循环的练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //求1-100之间的所有整数和   偶数和  奇数和
            //int sum = 0;
            //int n = 100;
            //for (int i = 1; i <= n; i += 2)
            //{
            //    sum += i;
            //}
            //Console.WriteLine(sum);
            //Console.ReadKey();

            //找出100-999间的水仙花数?
            //水仙花数指的就是 这个百位数字的
            //百位的立方+十位的立方+个位的立方==当前这个百位数字
            //153  1 125  27  153  i
            //百位：153/100
            //十位：153%100/10
            //个位：153%10

            //水仙花数

            for (int i = 100; i < 1000; i++)
            {
                if ((i / 100) * (i / 100) * (i / 100) + ((i % 100) / 10) * ((i % 100) / 10) * ((i % 100) / 10) + (i % 10) * (i % 10) * (i % 10) == i)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();

            //for (int i = 100; i <= 999; i++)
            //{
            //    int bai = i / 100;
            //    int shi = i % 100 / 10;
            //    int ge = i % 10;
            //    if (bai * bai * bai + shi * shi * shi + ge * ge * ge == i)
            //    {
            //        Console.WriteLine("水仙花数有{0}", i);
            //    }
            //}
            //Console.ReadKey();

        }
    }
}
