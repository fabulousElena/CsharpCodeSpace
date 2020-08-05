using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05判断闰年2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("请输入年份");
                int year = Convert.ToInt32(Console.ReadLine());
                Boolean whetherRunYear = false;
                string s = null;
                string s2 = "quit";
                if ((year % 400 == 0) || ((year % 4 == 0) && (year % 100 != 0)))
                {
                    whetherRunYear = true;
                }
                else
                {
                    whetherRunYear = false;
                }
                Console.WriteLine("请输入月份");
                int month = Convert.ToInt32(Console.ReadLine());

                switch (month)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        Console.WriteLine(year + "年" + month + "月有31天");
                        break;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        Console.WriteLine(year + "年" + month + "月有30天");
                        break;
                    case 2:
                        if (whetherRunYear == true)
                        {
                            Console.WriteLine(year + "年" + month + "月有29天");
                        }
                        else if (whetherRunYear == false)
                        {
                            Console.WriteLine(year + "年" + month + "月有28天");
                        }
                        break;
                    default:
                        Console.WriteLine("哦？我是猪？一年多少个月我不知道？打字说：我是猪");
                        Console.WriteLine("不然不给你退出");
                        while (true)
                        {

                            s = Console.ReadLine();
                            if (s == "我是猪")
                            {

                                Console.WriteLine("我就知道你是猪，给我重新查询！！");

                                break;
                            }
                            else
                            {
                                Console.WriteLine("你是猪吗？打字都不会？快打字说：我是猪");
                            }
                        }

                        break;
                }


                if (s == "我是猪")
                {

                }
                else
                {
                    //Console.ReadKey();
                    Console.WriteLine("查询成功，继续请回车，结束请quit");
                }

                if (Console.ReadLine() == s2)
                {
                    return;
                }
            }
        }
    }
}
