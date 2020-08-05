using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08while循环的3个练习2
{
    class Program
    {
        static void Main(string[] args)
        {
            //练习要求循环输入一个数字，然后输入end的时候输出输入数字的最大值。
            int max = 0;
            int num = 0;
            string s = null;
            while (true) {
                Console.WriteLine("请输入一个正整数，或者输入end输出最大值并结束");
                s = Console.ReadLine();
                try
                {

                    num = Convert.ToInt32(s);
                    if (num > max)
                    {
                        max = num;
                    }
                }
                catch {
                    if (s== "end") {
                        Console.WriteLine("最大值是" + max);
                        Console.ReadKey();
                        return;
                    }
                }

               

            }

            
        }
    }
}
