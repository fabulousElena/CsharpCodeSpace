using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15接口登记案例
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person需要登记
            //House房子也需要登记
            //汽车也需要登记
            //财产登记

            //最后写一个函数 来实现以上物品的登记

            DengJi(new Person());
            DengJi(new House());
            DengJi(new Car());
            DengJi(new Money());
            Console.ReadKey();
        }

        static void DengJi(IDengJi dj)
        {
            dj.DengJi();
        }

    }

    interface IDengJi
    {
        void DengJi();
    }
    class Person : IDengJi
    {
        public void DengJi()
        {
            Console.WriteLine("人出生就要登记");
        }
    }

    class House : IDengJi
    {
        public void DengJi()
        {
            Console.WriteLine("买房子也要登记");
        }
    }


    class Car : IDengJi
    {
        public void DengJi()
        {
            Console.WriteLine("买汽车也要登记");
        }
    }

    class Money : IDengJi
    {
        public void DengJi()
        {
            Console.WriteLine("财产也要登记");
        }
    }
}
