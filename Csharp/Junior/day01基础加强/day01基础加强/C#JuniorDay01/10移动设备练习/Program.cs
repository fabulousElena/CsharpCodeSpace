using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10移动设备练习
{
    class Program
    {
        static void Main(string[] args)
        {
            MobileDisk md = new MobileDisk();
            MP3 mp3 = new MP3();
            UDisk u = new UDisk();


            Computer cpu = new Computer();
            Telphone tel = new Telphone();
            cpu.MS = tel;//u;//mp3;//将MP3插到了电脑上
            cpu.CpuWrite();
            cpu.CpuRead();
          //  mp3.PlayMusic();
            Console.ReadKey();
        }
    }

    abstract class MobileStorage
    {
        public abstract void Read();
        public abstract void Write();
    }

    class Telphone : MobileStorage
    {
        public override void Read()
        {
            Console.WriteLine("手机在读取数据");
        }

        public override void Write()
        {
            Console.WriteLine("手机在写入数据");
        }
    }


    class MobileDisk : MobileStorage
    {
        public override void Read()
        {
            Console.WriteLine("移动硬盘在读取数据");
        }

        public override void Write()
        {
            Console.WriteLine("移动硬盘在写入数据");
        }
    }


    class UDisk : MobileStorage
    {
        public override void Read()
        {
            Console.WriteLine("U盘在读取数据");
        }

        public override void Write()
        {
            Console.WriteLine("U盘在写入数据");
        }
    }

    class MP3 : MobileStorage
    {
        public override void Read()
        {
            Console.WriteLine("Mp3在读取数据");
        }

        public override void Write()
        {
            Console.WriteLine("Mp3在写入数据");
        }

        public void PlayMusic()
        {
            Console.WriteLine("Mp3可以自己播放音乐");
        }


    }


    class Computer
    {
        public MobileStorage MS
        {
            get;
            set;
        }

        public void CpuRead()
        {
            this.MS.Read();
        }

        public void CpuWrite()
        {
            this.MS.Write();
        }
    }
}
