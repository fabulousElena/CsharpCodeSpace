using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04飞行棋游戏02
{
    class Program
    {

        public static int[] maps = new int[100];

        public static string[] twoPlayers = new string[2];
        //记录玩家在地图中的下标  0 是A  1 是 B
        public static int[] playersState = new int[2];

        public static int[] mapsTemp = new int[2];

        //初始化两个玩家在maps中的初始下标值
        public static int tempAIndex = 0;
        public static int tempBIndex = 0;

        public static bool aOrB = false;

        static void Main(string[] args)
        {
            //游戏开场
            GameShow();
            //添加加载标题
            AddTitle();
            //添加加载动画
            WriteLetter();

            AddPalyers(twoPlayers);
            //控制台清屏
            Console.Clear();
            Console.WriteLine(twoPlayers[0] + "是玩家A");
            Console.WriteLine(twoPlayers[1] + "是玩家B");
            //解释地图
            ExplainMaps();
            //初始化地图
            InitialMaps();

            //选择先行者
             
            aOrB = ChooseFirstPlayer();
            //开始游戏

            while (true)
            {
                PlayGame(aOrB);


                if (maps[99] == 5 || maps[99] == 6)
                {
                    break;
                }
            }

            string winnerName = null;
            if (maps[99] == 5)
            {
                winnerName = "玩家A ";
            }
            else if (maps[99] == 6)
            {
                winnerName = "玩家B ";
            }
            Console.WriteLine(winnerName + "赢得了比赛");






            Console.ReadKey();
        }
        /// <summary>
        ///  5 表示玩家A  6 表示玩家B
        /// </summary>
        /// <param name="randomNum"></param>
        /// <param name="name"></param>
        public static void MoveStep(int randomNum, string name)
        {

            

            if (name == "玩家A：")
            {
                
                tempAIndex = tempAIndex + randomNum;
                playersState[0] = maps[tempAIndex];

                //下面接五个if else
                //踩到了幸运轮盘 1交换位置  2 轰炸对方 使对方退6格
                if (maps[tempAIndex] == 1)
                {
                    Console.WriteLine("您踩到了幸运轮盘---- 按下1 和对方交换位置。按下2使对方退后6格子");
                    while (true)
                    {
                        
                        string luckNum = Console.ReadLine();
                        if (luckNum == "1")
                        {
                            int tempChangeIndex = 0;
                            tempChangeIndex = tempAIndex;
                            tempAIndex = tempBIndex;
                            tempBIndex =  tempChangeIndex;
                            Console.WriteLine("与对方交换位置成功。");
                            Console.ReadLine();
                            break;
                        }
                        else if (luckNum == "2")
                        {
                            if (tempBIndex - 10 >= 0)
                            {
                                Console.WriteLine("使对方退后6格成功！");
                                Console.ReadLine();
                                tempBIndex = tempBIndex - 10;
                            }
                            else
                            {
                                tempBIndex = 0;
                            }
                            
                            //递归玩家B
                            MoveStep(0,"玩家B：");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("请输入正确的数值。");
                        }
                    }
                }
                //踩到了地雷 退6格
                else if (maps[tempAIndex] == 2)
                {
                    if (tempAIndex - 6 > 0)
                    {
                        tempAIndex = tempAIndex - 6;
                        playersState[0] = maps[tempAIndex];
                        MoveStep(0,name);
                        maps[tempAIndex] = 5;
                        Console.WriteLine("猜到了地雷退后了6格");
                        Console.ReadLine();
                    }
                    else
                    {
                        playersState[0] = maps[0];
                        maps[0] = 5;
                        Console.WriteLine("猜到了地雷退后了6格");
                        Console.ReadLine();

                    }
                }
                //踩到了暂停  暂停一回合  
                else if (maps[tempAIndex] == 3)
                {
                    maps[tempAIndex] = 5;
                    aOrB = false;
                }
                //踩到了时空隧道 进10格
                else if (maps[tempAIndex] == 4)
                {
                    tempAIndex = tempAIndex + 10;
                    if (tempAIndex <= 99)
                    {
                        
                        MoveStep(0, name);
                        maps[tempAIndex] = 5;
                        Console.WriteLine("前进了10格");
                        Console.ReadLine();
                    }
                    else
                    {
                        maps[99] = 5;
                    }
                }
                //踩到了方块，就直接替换了
                else
                {
                    
                    maps[tempAIndex] = 5;
                    Console.WriteLine("踩到了方格，什么也没发生");
                    Console.ReadLine();
                }

                aOrB = false ;
            }
            else if (name == "玩家B：")
            {
                
                tempBIndex = tempBIndex + randomNum;
                if (tempBIndex >=100)
                {
                    tempBIndex = 99;
                }
                playersState[1] = maps[tempBIndex];

                //下面接五个if else
                //踩到了幸运轮盘 1交换位置  2 轰炸对方 使对方退6格
                if (maps[tempBIndex] == 1)
                {
                    Console.WriteLine("您踩到了幸运轮盘---- 按下1 和对方交换位置。按下2使对方退后6格子");
                    while (true)
                    {

                        string luckNum = Console.ReadLine();
                        if (luckNum == "1")
                        {
                            int tempChangeIndex = 0;
                            tempChangeIndex = tempAIndex;
                            tempAIndex = tempBIndex;
                            tempBIndex = tempChangeIndex;
                            Console.WriteLine("交换位置成功。");
                            
                            Console.ReadLine();
                            break;
                        }
                        else if (luckNum == "2")
                        {
                            if (tempAIndex - 10 >= 0)
                            {

                                tempAIndex = tempAIndex - 10;
                                Console.WriteLine("使对方退后了6格");
                                Console.ReadLine();
                            }
                            else
                            {
                                tempAIndex = 0;
                                Console.WriteLine("使对方退后了6格");
                                Console.ReadLine();
                            }
                            
                            //递归玩家B
                            MoveStep(0, "玩家A：");
                            Console.ReadLine();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("请输入正确的数值。");
                            Console.ReadLine();
                        }
                    }
                }
                //踩到了地雷 退6格
                else if (maps[tempBIndex] == 2)
                {
                    if (tempBIndex - 6 > 0)
                    {
                        Console.WriteLine("踩到了地雷，后退六格");
                        tempBIndex = tempBIndex - 6;
                        playersState[0] = maps[tempBIndex];
                        MoveStep(0, name);
                        maps[tempBIndex] = 6;
                        Console.ReadKey();
                    }
                    else
                    {
                        playersState[0] = maps[0];
                        maps[0] = 6;
                        Console.WriteLine("踩到了地雷，后退六格");
                        Console.ReadLine();

                    }
                }
                //踩到了暂停  暂停一回合  
                else if (maps[tempBIndex] == 3)
                {
                    maps[tempBIndex] = 6;
                    aOrB = true;
                    Console.WriteLine("暂停一回合");
                    Console.ReadLine();
                }
                //踩到了时空隧道 进10格
                else if (maps[tempBIndex] == 4)
                {

                    
                    tempBIndex = tempBIndex + 10;
                    if (tempBIndex <= 99)
                    {
                        Console.WriteLine("踩到了时空隧道，前进十格子");
                        MoveStep(0, name);
                        maps[tempBIndex] = 6;
                        Console.ReadKey();
                    }
                    else
                    {
                        maps[99] = 6;
                        Console.WriteLine("踩到了时空隧道，前进十格子");
                        Console.ReadKey();
                    }
                }
                //踩到了方块，就直接替换了
                else
                {

                    maps[tempBIndex] = 6;
                    Console.WriteLine("踩到了方块，什么也没发生。");
                    Console.ReadKey();
                }

                aOrB = true;
            }

        }

        /// <summary>
        /// 正式开始游戏
        /// </summary>
        /// <param name="s">玩家姓名</param>
        /// <param name="name">玩家A 或者玩家B</param>
        public static void StartPlay(string s, string name)
        {
            Random r = new Random();
            int randomNum = r.Next(6) + 1;
            Console.WriteLine(name + s + " 掷出了 " + randomNum + " 点。");
            Console.WriteLine(name + s + " 按任意键开始行动。");
            Console.ReadKey();
            Console.WriteLine(name + s + " 行动完毕。按任意键切换玩家。");

            //调用方法
            MoveStep(randomNum, name);


        }

        

        /// <summary>
        /// 开始游戏
        /// </summary>
        public static void PlayGame(bool b)
        {

            if (aOrB)
            {

                //控制台清屏
                Console.Clear();
                Console.WriteLine(twoPlayers[0] + "是玩家A");
                Console.WriteLine(twoPlayers[1] + "是玩家B");
                //解释地图
                ExplainMaps();
                //初始化地图
                InitialMaps();
                Console.WriteLine("请玩家A：" + twoPlayers[0] + " 按任意键开始掷骰子");
                Console.ReadKey();
                StartPlay(twoPlayers[0], "玩家A：");
            }
            else
            {

                //控制台清屏
                Console.Clear();
                Console.WriteLine(twoPlayers[0] + "是玩家A");
                Console.WriteLine(twoPlayers[1] + "是玩家B");
                //解释地图
                ExplainMaps();
                //初始化地图
                InitialMaps();
                Console.WriteLine("请玩家B：" + twoPlayers[1] + " 按任意键开始掷骰子");
                Console.ReadKey();
                StartPlay(twoPlayers[1], "玩家B：");

            }



        }


        /// <summary>
        /// 抛硬币选择第一个游戏的人
        /// </summary>
        /// <returns></returns>
        public static bool ChooseFirstPlayer()
        {
            while (true)
            {
                Console.WriteLine("下面进行抛硬币选择先行者。正面在上先行。");
                Console.WriteLine("玩家A：" + twoPlayers[0] + "按回车进行抛硬币。");
                Console.ReadKey();
                Random r1 = new Random();
                int RandomNum = r1.Next(2);
                if (RandomNum == 0)
                {
                    Console.WriteLine("硬币正面在上");
                    Console.WriteLine("玩家A：" + twoPlayers[0] + "先行。按任意键开始游戏");
                    Console.ReadKey();
                    return true;
                }
                else
                {
                    Console.WriteLine("硬币正面在下");
                    Console.WriteLine("玩家B：" + twoPlayers[1] + "先行。按任意键开始游戏");
                    Console.ReadKey();
                    return false;
                }

            }
        }


        /// <summary>
        /// 添加玩家的数据  ：姓名
        /// </summary>
        public static void AddPalyers(string[] s)
        {

            Console.WriteLine("请输入玩家A的姓名。");
            s[0] = Console.ReadLine();

            //s[0] = Console.ReadLine();
            while (s[0] == "")
            {
                Console.WriteLine("输入的姓名不能为空哦，请重新输入");
                s[0] = Console.ReadLine();
            }

            while (s[0].Length > 20)
            {
                Console.WriteLine("您输入的姓名长度超过了20，请重新输入");
                s[0] = Console.ReadLine();
            }

            Console.WriteLine("请输入玩家B的姓名。");
            s[1] = Console.ReadLine();

            while (s[1] == "")
            {
                Console.WriteLine("输入的姓名不能为空哦，请重新输入");
                s[1] = Console.ReadLine();
            }

            while (s[1].Length > 20)
            {
                Console.WriteLine("您输入的姓名长度超过了20，请重新输入");
                s[1] = Console.ReadLine();
            }
            //Console.Clear();
            Console.WriteLine("玩家A的姓名是" + s[0]);
            Console.WriteLine("玩家B的姓名是" + s[1]);




        }


        /// <summary>
        /// 添加两行字
        /// </summary>
        public static void AddTitle()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("               Press Enter To Start Game...                ");
            Console.WriteLine("                    按下回车以启动游戏                     ");
            Console.ReadKey();
        }



        /// <summary>
        /// 解释地图
        /// </summary>
        public static void ExplainMaps()
        {
            Console.WriteLine("     图例:幸运轮盘:◎   地雷:☆   暂停:▲   时空隧道:卐");
        }


        /// <summary>
        /// 初始化地图
        /// </summary>
        public static void InitialMaps()
        {
            //初始化坐标值
            int index = 0;
            for (int i = 0; i < maps.Length; i++)
            {
                maps[i] = 0;
            }
            int[] luckyturn = { 6, 23, 40, 55, 69, 83 };//幸运轮盘◎   在maps用1表示
            for (int i1 = 0; i1 < luckyturn.Length; i1++)
            {
                index = luckyturn[i1];
                maps[index] = 1;
            }

            int[] landMine = { 5, 13, 17, 33, 38, 50, 64, 80, 94 };//地雷☆  在maps用2表示
            for (int i2 = 0; i2 < landMine.Length; i2++)
            {
                index = landMine[i2];
                maps[index] = 2;
            }

            int[] pause = { 9, 27, 60, 93 };//暂停▲   在maps用3表示
            for (int i3 = 0; i3 < pause.Length; i3++)
            {
                index = pause[i3];
                maps[index] = 3;
            }
            int[] timeTunnel = { 20, 25, 45, 63, 72, 88, 90 };//时空隧道卐   在maps用4表示
            for (int i4 = 0; i4 < timeTunnel.Length; i4++)
            {
                index = timeTunnel[i4];
                maps[index] = 4;
            }

            maps[tempAIndex] = 5;
            maps[tempBIndex] = 6;

            //Console.WriteLine();

            //创建一个临时数组存储 maps[32] -- maps[60]之间的数字

            int[] temp = new int[29];
            for (int i = 0; i < maps.Length; i++)
            {


                if (36 <= i && i <= 64)
                {
                    temp[i - 36] = maps[i];
                    //Console.Write(maps[i] + "-");

                }
            }
            //对调数组
            Array.Reverse(temp);
            //Console.WriteLine();
            //for (int i = 0; i < temp.Length; i++)
            //{

            //    Console.Write(temp[i]);

            //}
            //将对调的数组装回maps数组
            for (int i = 0; i < maps.Length; i++)
            {


                if (36 <= i && i <= 64)
                {
                    maps[i] = temp[i - 36];
                    //Console.Write(maps[i] + "-");

                }
            }

            //替换maps里面的内容
            for (int j = 0; j < maps.Length; j++)
            {

                string s = null;
                s = maps[j] + "";


                if (maps[j] == 1)
                {
                    s = "◎";
                }
                else if (maps[j] == 2)
                {
                    s = "☆";
                }
                else if (maps[j] == 3)
                {
                    s = "▲";
                }
                else if (maps[j] == 4)
                {
                    s = "卐";
                }
                else if (maps[j] == 5)
                {
                    s = "A ";
                }
                else if (maps[j] == 6)
                {
                    s = "B ";
                }
                else
                {
                    s = "□";
                }

                if (j <= 27)
                {
                    Console.Write(s);
                }
                else if (j == 28)
                {
                    Console.Write(s);
                    Console.WriteLine();
                }
                else if (28 < j && j < 36)
                {
                    Console.WriteLine("                                                        " + s);
                }
                else if (36 <= j && j < 64)
                {

                    Console.Write(s);
                }
                else if (j == 64)
                {
                    Console.Write(s);
                    Console.WriteLine();
                }
                else if (64 < j && j <= 70)
                {
                    Console.WriteLine(s);
                }
                else if (70 < j)
                {
                    Console.Write(s);
                }
            }

            Console.WriteLine();

        }

        /// <summary>
        /// 游戏开场
        /// </summary>
        public static void GameShow()
        {

            //Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("***********************************************************");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("***********************************************************");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("***********************************************************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("********************-- 飞行棋 ver0.1 --********************");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("***********************************************************");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("***********************************************************");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("***********************************************************");
            Console.ForegroundColor = ConsoleColor.White;
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

        /// <summary>
        /// 把数组内的内容一个一个的输出到控制台
        /// </summary>
        /// <param name="s">一个字符串数组</param>
        public static void WriteLetter()
        {
            string[] s = { "正", "在", "加", "载", "游", "戏", "资", "源", ".", ".", "." };

            int m = 0;
            Console.WriteLine();
            Console.WriteLine();
            while (m < 3)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    //下面的延时方法
                    DelayTime(200);
                    //输出数组的每一个字符
                    Console.Write(s[i]);

                }
                //Console.Clear();
                DelayTime(200);
                //因为是半格，所以是传进来的数组的长度 * 2 
                for (int k = 0; k < s.Length * 2; k++)
                {
                    //Console.Write('\u0008'); 是向后退半格  我用中文输入测试是这样的
                    Console.Write('\u0008');
                    //退回去但是不刷新已经输出的字符，所以用空格覆盖
                    Console.Write(" ");
                    //然后重新退回顶部
                    Console.Write('\u0008');
                }
                //控制显示数组的次数
                m++;
            }


            Console.Write("  读取地图：");

            for (int q = 0; q < s.Length * 2; q++)
            {
                //Console.Write('\u0008'); 是向后退半格  我用中文输入测试是这样的
                //Console.Write('\u0008');
                //退回去但是不刷新已经输出的字符，所以用空格覆盖
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.Write("  ");
                DelayTime(150);
                //然后重新返回顶部
                //Console.Write('\u0008');
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                 加载完成！按回车创建角色。");
            Console.ReadKey();

        }

    }

}
