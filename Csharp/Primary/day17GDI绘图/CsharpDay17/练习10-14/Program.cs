using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习10_14
{
    class Program
    {
        static void Main(string[] args)
        {
            //while (true)
            //{
            //    Console.WriteLine("请输入一个数字");
            //    int n = Convert.ToInt32(Console.ReadLine());
            //    bool b = IsPrime(n);
            //    Console.WriteLine(b);
            //    Console.ReadKey();
            //}
            //用方法来实现：计算1-100之间的所有质数（素数）的和。
            int sum = GetPrimeSum();
            Console.WriteLine(sum);
            Console.ReadKey();
        }
         
        public static int GetPrimeSum()
        {
            int sum = 0;
            for (int i = 2; i <= 100; i++)
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
                    sum += i;
                }
            }
            return sum;
        }


        public static bool IsPrime(int n)
        {
            if (n < 2)
            {
                return false;
            }
            else//>=2
            {
                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
        public static int GetSum()
        {
            int sum = 0;
            for (int i =2; i < 101; i+=2)
            {
                sum += i;
            }
            return sum;
        }
    }
}
