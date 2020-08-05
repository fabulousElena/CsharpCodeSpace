using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01复习
{
    class Program
    {
        static void Main(string[] args)
        {
            //练习4：不断要求用户输入一个数字，然后打印这个数字的二倍，当用户输入q的时候程序退出。
            //循环体：提示用户输入一个数字 接收 转换  打印2倍
            //循环条件：输入的不能是q

            //string input = "";
            //while (input != "q")
            //{
            //    Console.WriteLine("请输入一个数字，我们将打印这个数字的2倍");
            //    //不能直接转换成int类型 因为用户有可能输入q
            //    input = Console.ReadLine();//数字 q 乱七八糟
            //    if (input != "q")
            //    {
            //        try
            //        {
            //            int number = Convert.ToInt32(input);
            //            Console.WriteLine("您输入的数字的2倍是{0}", number * 2);
            //        }
            //        catch
            //        {
            //            Console.WriteLine("输入的字符串不能够转换成数字，请重新输入");
            //        }
            //    }
            //    else//==q
            //    {
            //        Console.WriteLine("输入的是q，程序退出");
            //    }
            //}

            //练习5：不断要求用户输入一个数字（假定用户输入的都是正整数），当用户输入end的时候显示刚才输入的数字中的最大值            //循环体：提示用户输入一个数字  接收  转换成int类型  不停的比较大小
            //循环条件：输入的不能是end
            //F11
            string input = "";
            int max = 0;
            while (input != "end")
            {
                Console.WriteLine("请输入一个数字，输入end我们将显示你输入的最大值");
                input = Console.ReadLine();//数字 end  乱七八糟
                if (input != "end")
                {
                    try
                    {
                        int number = Convert.ToInt32(input);
                        //让用户输入的每个数字都跟我假定的最大值比较，只要比我假定的最大值要大,
                        //就把当前输入的这个数字赋值给我的最大值
                        if (number > max)
                        {
                            max = number;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("输入的字符串不能够转换成数字，请重新输入");
                    }
                   
                }
                else//==end
                {
                    Console.WriteLine("您刚才输的数字中的最大值是{0}",max);
                }
            }
            Console.ReadKey();


            Console.ReadKey();
        }
    }
}
