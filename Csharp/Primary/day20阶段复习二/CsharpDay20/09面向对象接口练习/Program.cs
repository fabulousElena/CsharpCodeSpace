using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09面向对象接口练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //作业:鸟-麻雀sparrow['spærəu] ，鸵鸟ostrich['ɔstritʃ] ，
            //企鹅penguin['pengwin] ，鹦鹉parrot['pærət]  
            //鸟能飞,鸵鸟，企鹅不能。。。你怎么办

            IFlyable fly = new YingWu();// new QQ();//new YingWu();//new MaQue();
            fly.Fly();
            Console.ReadKey();
        }
    }

    public interface IFlyable
    {
        void Fly();
    }

    public class Bird
    {
        public double Wings
        {
            get;
            set;
        }

        public void SayHello()
        {
            Console.WriteLine("我是小鸟");
        }
    }

    public class MaQue : Bird, IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("麻雀会飞");
        }
    }

    public class TuoNiao : Bird
    { 
        
    }

    public class QQ : Bird
    { 
        
    }

    public class YingWu : Bird, IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("鹦鹉会飞");
        }
    }
}
