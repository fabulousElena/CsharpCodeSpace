using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12接口特点
{
    class Program
    {
        static void Main(string[] args)
        {
            IFlyable fly = new Bird();//new Person();// new IFlyable();
            fly.Fly();
            Console.ReadKey();
        }
    }
    public class Person:IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("人类在飞");
        }
    }


    public class Student 
    {
        public void Fly()
        {
            Console.WriteLine("人类在飞");
        }
    }

    public class Bird : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("鸟在飞");
        }
    }

    public interface IFlyable
    {
        //不允许有访问修饰符 默认为public
        //方法、自动属性
        void Fly();
    }



    public interface IM1
    {
        void Test1();
    }

    public interface IM2
    {
        void Test2();
    }

    public interface IM3
    {
        void Test3();
    }


    public interface ISupperInterface : IM1, IM2, IM3
    { 
        
    }

    public class Car : ISupperInterface
    {

        public void Test1()
        {
            throw new NotImplementedException();
        }

        public void Test2()
        {
            throw new NotImplementedException();
        }

        public void Test3()
        {
            throw new NotImplementedException();
        }
    }

}
