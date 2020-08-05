using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10面向对象多态练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //作业:橡皮rubber鸭子、木wood鸭子、真实的鸭子realduck。
            //三个鸭子都会游泳，而橡皮鸭子和真实的鸭子都会叫，
            //只是叫声不一样，橡皮鸭子“唧唧”叫，真实地鸭子“嘎嘎”叫，木鸭子不会叫.
            //IBark bark = new RealDuck();//new XPDuck();
            //bark.Bark();
            XPDuck xp = new XPDuck();
            MuDuck md = new MuDuck();
            RealDuck rd = new RealDuck();
            IBark bark = rd;
            Duck duck = rd;
            duck.Swim();
            bark.Bark();


            Console.ReadKey();

        }
    }

    public class Duck
    {
        public virtual void Swim()
        {
            Console.WriteLine("是鸭子就会游泳");
        }
    }

    public interface IBark
    {
        void Bark();
    }

    public class RealDuck : Duck, IBark
    {
        public void Bark()
        {
            Console.WriteLine("这的鸭子嘎嘎叫");
        }

        public override void Swim()
        {
            Console.WriteLine("真的鸭子会游泳");
        }
    }

    public class MuDuck:Duck
    {
        public override void Swim()
        {
            Console.WriteLine("木头鸭子也会游泳");
        }
    }

    public class XPDuck : Duck, IBark
    {
        public void Bark()
        {
            Console.WriteLine("橡皮鸭子唧唧叫");
        }

        public override void Swim()
        {
            Console.WriteLine("橡皮鸭子也会游泳");
        }
    }
}
