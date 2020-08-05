using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace _05接口复习
{
    class Program
    {
        static void Main(string[] args)
        {
            //alt+shift+F10
          //  File
            //接口是什么？什么时候使用接口？使用接口的目的是什么？多态
            //鸟会飞 飞机也会飞
              
            IFlyable fly = new Plane();//new Bird();
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
        //public void Fly()
        //{
        //    Console.WriteLine("大多数鸟都会飞"); 
        //}
    }
    //public class QQ : Bird
    //{

    //}

    public class Maque : Bird, IFlyable
    {
        /// <summary>
        /// 这个函数是父类的？还是子类自己的？还实现接口的？
        /// </summary>
        public void Fly()
        {
            Console.WriteLine("鸟会飞");
        }
        void IFlyable.Fly()
        {
            Console.WriteLine("实现的接口的飞方法");
        }
    }

    public class Plane : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("飞机会飞");
        }
    }
}
