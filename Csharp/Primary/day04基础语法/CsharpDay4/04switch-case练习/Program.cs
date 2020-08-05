using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04switch_case练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //让用户输入姓名,然后显示出这个人上辈子是什么职业。
            //Console.WriteLine("请输入一个姓名，我们将显示出来这个人上辈子的职业");
            //string name = Console.ReadLine();
            ////老杨、老苏、老马、老蒋、老牛、老虎、老赵
            //switch (name)
            //{
            //    case "老杨": Console.WriteLine("上辈子是抽大烟的");
            //        break;
            //    case "老苏": Console.WriteLine("上辈子是个老鸨子");
            //        break;
            //    case "老马": Console.WriteLine("上辈子是老苏手下的头牌");
            //        break;
            //    case "老蒋": Console.WriteLine("上辈子是拉皮条的");
            //        break;
            //    case "老牛": Console.WriteLine("上辈子是一坨翔");
            //        break;
            //    case "老虎": Console.WriteLine("上辈子是个大病猫");
            //        break;
            //    case "老赵": Console.WriteLine("上辈子是光芒万丈救苦救难的菩萨呀");
            //        break;
            //    default: Console.WriteLine("不认识，估计是一坨翔");
            //        break;
            //}
            //Console.ReadKey();




                     // 成绩>=90 ：A                           //90>成绩>=80 ：B 	                     //80>成绩>=70 ：C                     //70>成绩>=60 ：D                     //         成绩<60  ：E

            Console.WriteLine("请输入一个考试成绩");
            int score = Convert.ToInt32(Console.ReadLine()); //0-100

            switch (score/10)//你要把范围 变成一个定值
            {
                case 10: //case 10要执行的代码跟case 9是一样的
                case 9: Console.WriteLine("A");
                    break;
                case 8: Console.WriteLine("B");
                    break;
                case 7: Console.WriteLine("C");
                    break;
                case 6: Console.WriteLine("D");
                    break;
                default: Console.WriteLine("E");
                    break;            }
            Console.ReadKey();
        }
    }
}
