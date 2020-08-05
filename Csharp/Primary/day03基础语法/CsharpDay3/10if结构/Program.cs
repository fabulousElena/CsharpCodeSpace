using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10if结构
{
    class Program
    {
        static void Main(string[] args)
        {
            //编程实现:如果跪键盘的时间大于60分钟,那么媳妇奖励我晚饭不用做了
            Console.WriteLine("请输入你跪键盘的时间");
            int mins = Convert.ToInt32(Console.ReadLine());

            //如果跪键盘的时间>60分钟 则不做晚饭

            bool b = mins > 60;
            //mins.Equals("sad");

            //如果你想表示的含义是当b的值为true的时候去执行if中代码，
            //那么 语法上  ==true可以省略
            //但是，如果你想表示的是当b==false的时候去执行if中代码，
            //语法上 ==false不能省略
            if (mins>60)
            {
                Console.WriteLine("好老公，不用跪键盘了，去吃屎吧");
            }
            Console.ReadKey();


        }
    }
}
