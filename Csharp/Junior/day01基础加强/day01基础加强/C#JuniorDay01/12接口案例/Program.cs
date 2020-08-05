using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12接口案例
{
    class Program
    {
        static void Main(string[] args)
        {
            //麻雀 会飞 企鹅不会飞 鸵鸟不会飞 鹦鹉会飞 飞机 会飞

            IFly[] flys = { new MaBird(), new YingWu(), new Plane() };

            for (int i = 0; i < flys.Length; i++)
            {
                flys[i].Fly();
            }
            Console.ReadKey();
        }
    }

    class Bird
    {
        public void CHLSS()
        {
            Console.WriteLine("鸟都会吃喝拉撒睡");
        }
    }

    interface IFly
    {
         void Fly();
        // void DownEggs();
    }

    class MaBird : Bird, IFly
    {

        public void Fly()
        {
            Console.WriteLine("麻雀会飞");
        }
    }

    class TuoBird : Bird
    { }

    class YingWu : Bird, IFly
    {
        public void Fly()
        {
            Console.WriteLine("鹦鹉也会飞");
        }
    }
    class QQ : Bird
    {

    }

    class Plane : IFly
    {
        public void Fly()
        {
            Console.WriteLine("飞机也会飞");
        }
    }


    interface IStrong
    {
        void Strong();
    }

    interface NKWC
    {
        void NKWC();
    }


    interface ISupperMan : IFly, IStrong, NKWC
    { }


    class Student : ISupperMan
    {
        public void Fly()
        {
            throw new NotImplementedException();
        }

        public void Strong()
        {
            throw new NotImplementedException();
        }

        public void NKWC()
        {
            throw new NotImplementedException();
        }
    }

}
