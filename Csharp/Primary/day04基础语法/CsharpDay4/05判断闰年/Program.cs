using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05判断闰年
{
    class Program
    {
        static void Main(string[] args)
        {
            //请用户输年份,再输入月份,输出该月的天数.(结合之前如何判断闰年来做)
            Console.WriteLine("请输入一个年份");
            try
            {
                int year = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("请输入一个月份");
                try
                {
                    int month = Convert.ToInt32(Console.ReadLine());//1-12
                    if (month >= 1 && month <= 12)
                    {
                        int day = 0;//声明一个变量用来存储天数
                        switch (month)
                        {
                            case 1:
                            case 3:
                            case 5:
                            case 7:
                            case 8:
                            case 10:
                            case 12: day = 31;
                                break;
                            case 2:
                                //由于2月 有平年和闰年的不同  所以首先要判断一下当年是不是闰年
                                if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
                                {
                                    day = 29;
                                }
                                else
                                {
                                    day = 28;
                                }
                                break;
                            //4 6  9 11
                            default: day = 30;
                                break;
                        }

                        Console.WriteLine("{0}年{1}月有{2}天", year, month, day);
                    }//if判断的括号
                    else
                    {
                        Console.WriteLine("输入的月份不符合要求，程序退出");
                    }
                }//try月份括号
                catch//跟月份配对
                {
                    Console.WriteLine("输入的月份有误，程序退出");
                }
            }//try年份的括号
            catch//跟年份的try配对
            {
                Console.WriteLine("输入的年份有误，程序退出");
            }
            Console.ReadKey();
        }
    }
}
