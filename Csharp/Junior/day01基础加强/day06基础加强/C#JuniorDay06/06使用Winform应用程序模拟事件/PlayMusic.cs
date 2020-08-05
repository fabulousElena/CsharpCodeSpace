using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _06使用Winform应用程序模拟事件
{

    public delegate void DelPlayOver();
    class PlayMusic
    {
        public event DelPlayOver Del;//声明事件不需要写()

        //音乐播放的名字
        public string Name { get; set; }

        public PlayMusic(string name)
        {
            this.Name = name;
        }


        public void PlaySongs()
        {
            Console.WriteLine("正在播放" + this.Name);
            //模拟播放了三秒钟
            Thread.Sleep(3000);

            if (Del != null)
            {
                //当播放完成后  执行一个事件
                Del();//直接调用“事件”
            }
        }
    }
}
