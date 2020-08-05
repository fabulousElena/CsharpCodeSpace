using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11continue练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //练习1：用 while continue实现计算1到100(含)之间的除了能被7整除之外所有整数的和。

            //int i = 1;
            //int sum = 0;
            //while (i<100) {
            //    if (( i % 7 )  == 0)
            //    {

            //    }
            //    else {

            //        sum = sum + i;
            //    }
            //    i++;
            //    //Console.WriteLine(i);
            //    continue;

            //}
            //Console.WriteLine(sum);
            //Console.ReadKey();


            // code2
            //int sum = 0;
            //int i=1;
            //while (i <= 100)
            //{
            //    if (i % 7 == 0)
            //    {
            //        i++;
            //        continue;
            //    }
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine(sum);
            //Console.ReadKey();


            //找出100内所有的素数
            //素数/质数：只能被1和这个数字本身整除的数字
            //2 3  4  5  6  7
            //7   7%1   7%2 7%3 7%4 7%5 7%6  7%7  6%2

            for (int i = 2; i < 100; i++)
            {

                bool b = true;

                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        b = false;
                        break;
                    }

                }

                if (b)
                {
                    Console.WriteLine(i);
                }

            }

            

            Console.ReadKey();




            //code2
            //for (int i = 2; i <= 100; i++)
            //{
            //    bool b = true;
            //    for (int j = 2; j <i; j++)
            //    {
            //        //除尽了说明不是质数 也就没有再往下继续取余的必要了
            //        if (i % j == 0)
            //        {
            //            b = false;
            //            break;
            //        }
            //    }

            //    if (b)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //Console.ReadKey();
            //6   6%2 6%3
        }
    }
}
