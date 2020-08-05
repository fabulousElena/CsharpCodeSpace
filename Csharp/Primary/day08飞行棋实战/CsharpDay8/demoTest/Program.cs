using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //正在加载游戏资源...
            string[] s = { "正", "在", "加", "载", "游", "戏", "资", "源", ".", ".", "." };
            WriteLetter(s);

        }
        /// <summary>
        /// 把数组内的内容一个一个的输出到控制台
        /// </summary>
        /// <param name="s">一个字符串数组</param>
        public static void WriteLetter(string[] s)
        {
            int m = 0;
            while (m < 3)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    //下面的延时方法
                    DelayTime(300);
                    //输出数组的每一个字符
                    Console.Write(s[i]);

                }
                //Console.Clear();
                DelayTime(300);
                //因为是半格，所以是传进来的数组的长度 * 2 
                for (int k = 0; k < s.Length * 2; k++)
                {
                    //Console.Write('\u0008'); 是向后退半格  我用中文输入测试是这样的
                    Console.Write('\u0008');
                    Console.Write(" ");//退回去但是不刷新已经输出的字符，所以用空格覆盖
                    Console.Write('\u0008');//然后重新返回顶部
                }
                m++;
            }
            
            Console.ReadKey();

        }

        /// <summary>
        /// 延时t毫秒
        /// </summary>
        /// <param name="t">要延迟的毫秒数</param>
        public static void DelayTime(int t)
        {

            DateTime now = DateTime.Now;
            //Console.WriteLine(now);
            while (true)
            {
                TimeSpan spand = DateTime.Now - now;
                //Console.WriteLine(spand.Milliseconds);
                if (spand.Milliseconds == t)
                {
                    break;
                }
            }

        }

    }
}
