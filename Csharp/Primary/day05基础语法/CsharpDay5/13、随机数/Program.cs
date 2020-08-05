using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_随机数
{
    class Program
    {
        static void Main(string[] args)
        {
            //产生随机数
            //1、创建能够产生随机数的对象
            //Random r = new Random();
            //while (true)
            //{

            //    //2、让产生随机数的这个对象调用方法来产生随机数
            //    int rNumber = r.Next(1, 11);
            //    Console.WriteLine(rNumber);
            //    Console.ReadKey();
            //}

            //输入名字随机显示这个人上辈是什么样的人
            //思路：
            //1、创建能够产生随机数的对象
            //2、产生随机数 (1,7)

            Random r = new Random();
            while (true)
            {
                int rNumber = r.Next(1, 7);
                Console.WriteLine("请输入一个姓名");
                string name = Console.ReadLine();
                switch (rNumber)
                {
                    case 1: Console.WriteLine("{0}上辈子是吃翔的", name);
                        break;
                    case 2: Console.WriteLine("{0}上辈子是拉翔的", name);
                        break;
                    case 3: Console.WriteLine("{0}上辈子就是一坨翔", name);
                        break;
                    case 4: Console.WriteLine("{0}上辈子是大汉奸", name);
                        break;
                    case 5: Console.WriteLine("{0}上辈子是拉皮条的", name);
                        break;
                    case 6: Console.WriteLine("{0}上辈子是救苦救难的活菩萨", name);
                        break;
                }
                Console.ReadKey();
            }
           
        }
    }
}
