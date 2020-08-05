using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05动物类继承
{
    class Program
    {
        static void Main(string[] args)
        {
            //实现多态：声明父类去指向子类对象
            Animal[] a = { new Cat(), new Dog(), new Pig() };

            for (int i = 0; i < a.Length; i++)
            {
                a[i].Bark();
                a[i].Drink();
                a[i].Eat();
            }
            Console.ReadKey();
        }
    }
    abstract class Animal
    {
        //抽象成员只能存在于抽象类中
        public abstract void Bark();//父类没有办法确定子类如何去实现
        public void Eat()
        {
            Console.WriteLine("动物可以舔着吃");
        }

        public void Drink()
        {
            Console.WriteLine("动物可以舔着喝");
        }
    }

    //一个子类继承了一个抽象的父类，那么这个子类必须重写这个抽象父类中的所有抽象成员
    class Cat : Animal
    {
        public override void Bark()
        {
            Console.WriteLine("猫咪喵喵的叫");
        }

      
    }
    class Dog : Animal
    {
        public override void Bark()
        {
            Console.WriteLine("狗狗旺旺的叫");
        }
    }
    class Pig : Animal
    {
        public override void Bark()
        {
            Console.WriteLine("猪猪哼哼的叫");
        }
    }

}
