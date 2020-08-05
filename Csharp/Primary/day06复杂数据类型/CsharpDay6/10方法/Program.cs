using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10方法
{
    class Program
    {
        static void Main(string[] args)
        {
            //闪烁  播放一段特殊的背景音乐  屏幕停止
            Program.PlayGame();
            Program.WuDi();
            Program.PlayGame();
            Program.PlayGame();
            Program.PlayGame();
            Program.PlayGame();
            Program.WuDi();
            Console.ReadKey();
            
           
        }

        /// <summary>
        /// 正常玩游戏
        /// </summary>
        public static void PlayGame()
        {
            Console.WriteLine("超级玛丽走呀走，跳呀跳，顶呀顶");
            Console.WriteLine("超级玛丽走呀走，跳呀跳，顶呀顶");
            Console.WriteLine("超级玛丽走呀走，跳呀跳，顶呀顶");
            Console.WriteLine("超级玛丽走呀走，跳呀跳，顶呀顶");
            Console.WriteLine("超级玛丽走呀走，跳呀跳，顶呀顶");
            Console.WriteLine("突然，顶到了一个无敌");
        }
        /// <summary>
        /// 无敌
        /// </summary>
        public static void WuDi()
        {
            Console.WriteLine("屏幕开始闪烁");
            Console.WriteLine("播放无敌的背景音乐");
            Console.WriteLine("屏幕停止");
        }

    }
}
