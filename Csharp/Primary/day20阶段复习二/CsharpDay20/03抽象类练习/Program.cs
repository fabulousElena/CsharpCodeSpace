using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03抽象类练习
{
    class Program
    {
        static void Main(string[] args)
        {
            MobileDisk md = new MobileDisk();
            Mp3 mp3 = new Mp3();
            UDisk u = new UDisk();

            Computer cpu = new Computer();
            cpu.MS = mp3;
            cpu.CPURead();
            cpu.CPUWrite();
            Console.ReadKey();
        }
    }

    /// <summary>
    /// 抽象的移动存储设备父类
    /// </summary>
    public abstract class MobileStorage
    {
        public abstract void Read();
        public abstract void Write();
    }
    public class MobileDisk : MobileStorage
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
    public class UDisk : MobileStorage
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
    public class Mp3 : MobileStorage
    {
        public void PlayMusic()
        { 
            Console.WriteLine("Mp3自己可以播放音乐");
        }

        public override void Read()
        {
            Console.WriteLine("Mp3读取数据");
        }

        public override void Write()
        {
            Console.WriteLine("Mp3写入数据");
        }
    }


    public class Computer
    {

        public MobileStorage MS
        {
            get;
            set;
        }
        public void CPURead()
        {
            this.MS.Read();
        }

        public void CPUWrite()
        {
            this.MS.Write();
        }
    }
}
