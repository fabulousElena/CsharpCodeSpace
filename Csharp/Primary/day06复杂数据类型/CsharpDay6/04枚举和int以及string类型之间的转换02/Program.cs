using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04枚举和int以及string类型之间的转换02
{

    public enum QQState
    {

        OnLine = 1,
        OffLine,
        Leave,
        Busy,
        QMe
    }

    public enum Gender {
        男,
        女
    }

    class Program
    {
        static void Main(string[] args)
        {
            //将枚举类型强转成int类型
            //QQState state = QQState.OnLine;
            //int n = (int)state;
            //Console.WriteLine(n);
            //Console.ReadKey();

            //将int类型强转成枚举类型
            //int n1 = 3;
            //QQState state1 = (QQState)n1;
            //Console.WriteLine(state1);
            //Console.ReadKey();

            //所有的类型都能够转换成string类型

            Console.WriteLine("请选择在线类型。1--OnLine，2--OffLine，3--Leave，4--Busy，5--QMe");
            string stateInput = Console.ReadLine();
            switch (stateInput) {
                case "1":
                    QQState state = (QQState)Enum.Parse(typeof(QQState),stateInput);
                    Console.WriteLine("您选择的在线类型是{0}",state);
                    break;
                case "2":
                    QQState state1 = (QQState)Enum.Parse(typeof(QQState), stateInput);
                    Console.WriteLine("您选择的在线类型是{0}", state1);
                    break;
                case "3":
                    QQState state2 = (QQState)Enum.Parse(typeof(QQState), stateInput);
                    Console.WriteLine("您选择的在线类型是{0}", state2);
                    break;
                case "4":
                    QQState state3 = (QQState)Enum.Parse(typeof(QQState), stateInput);
                    Console.WriteLine("您选择的在线类型是{0}", state3);
                    break;
                case "5":
                    QQState state4 = (QQState)Enum.Parse(typeof(QQState), stateInput);
                    Console.WriteLine("您选择的在线类型是{0}", state4);
                    break;
                default:
                    Console.WriteLine("您输入的代码有错误");
                    break;
            }

            Console.ReadKey();
        }
    }
}
