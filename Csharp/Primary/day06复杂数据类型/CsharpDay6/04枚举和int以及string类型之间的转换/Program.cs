using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04枚举和int以及string类型之间的转换
{
    public enum QQState
    {
        OnLine=1,
        OffLine,
        Leave,
        Busy,
        QMe
    }

    public enum Gender
    {
        男,
        女
    }
    class Program
    {
        static void Main(string[] args)
        {
            #region 将枚举类型强转成int类型
            //QQState state = QQState.OnLine;
            ////枚举类型默认可以跟int类型互相转换  枚举类型跟int类型是兼容的
            //int n = (int)state;
            //Console.WriteLine(n);
            //Console.WriteLine((int)QQState.OffLine);
            //Console.WriteLine((int)QQState.Leave);
            //Console.WriteLine((int)QQState.Busy);
            //Console.WriteLine((int)QQState.QMe);
            //Console.ReadKey();
            #endregion
            #region 将int类型强转为枚举类型

            //int n1 = 3;

            //QQState state = (QQState)n1;
            //Console.WriteLine(state);
            //Console.ReadKey();
            #endregion
            #region 将枚举类型转换成字符串类型
            //所有的类型都能够转换成string类型
            // int n1 = 10;
            //// double n1 = 3.14;
            // decimal n1 = 5000m;
            // string s = n1.ToString();
            // Console.WriteLine(s);
            // Console.ReadKey();

            //QQState state = QQState.OnLine;
            //string s = state.ToString();
            //Console.WriteLine(s);
            //Console.ReadKey();
            #endregion
            #region 将字符串类型转换为枚举类型
            //string s = "ABCDEFG";
            ////将s转换成枚举类型
            ////Convert.ToInt32()  int.parse()  int.TryParse()
            ////调用Parse()方法的目的就是为了让它帮助我们将一个字符串转换成对应的枚举类型
            ////
            //QQState state = (QQState)Enum.Parse(typeof(QQState), s);
            //Console.WriteLine(state);
            //Console.ReadKey();
            #endregion



            //枚举练习
            //提示用户选择一个在线状态，我们接受，并将用户的输入转换成枚举类型。
            //再次打印到控制台中

            Console.WriteLine("请选择您的qq在线状态 1--OnLine 2--OffLine 3--Leave 4--Busy 5--QMe");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1": QQState s1 = (QQState)Enum.Parse(typeof(QQState), input);
                    Console.WriteLine("您选择的在线状态是{0}",s1);
                    break;
                case "2": QQState s2 = (QQState)Enum.Parse(typeof(QQState), input);
                     Console.WriteLine("您选择的在线状态是{0}",s2);
                    break;
                case "3": QQState s3 = (QQState)Enum.Parse(typeof(QQState), input);
                     Console.WriteLine("您选择的在线状态是{0}",s3);
                    break;
                case "4": QQState s4 = (QQState)Enum.Parse(typeof(QQState), input);
                    Console.WriteLine("您选择的在线状态是{0}", s4);
                    break;
                case "5": QQState s5 = (QQState)Enum.Parse(typeof(QQState), input);
                    Console.WriteLine("您选择的在线状态是{0}", s5);
                    break;
            }
            Console.ReadKey();
        }
    }
}
