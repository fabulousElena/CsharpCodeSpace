using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
   
namespace _08面向对象多态练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //作业:动物Animal   都有吃Eat和叫Bark的方法，狗Dog和猫Cat叫的方法不一样.
            //父类中没有默认的实现所哟考虑用抽象方法。

            Animal a = new Dog();//new Cat();
            a.Bark();
            a.Eat();
            Console.ReadKey();
        }
    }

    public abstract class Animal
    {
        public abstract void Eat();
        public abstract void Bark();
    }

    public class Cat : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("猫咪舔着吃");
        }

        public override void Bark()
        {
            Console.WriteLine("猫咪喵喵的叫");
        }
    }

    public class Dog : Animal
    {
        public override void Bark()
        {
            Console.WriteLine("狗狗旺旺的叫");
        }

        public override void Eat()
        {
            Console.WriteLine("狗狗咬着吃");
        }
    }

}
