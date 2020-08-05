using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_抽象类02
{
    class Program
    {
        static void Main(string[] args)
        {
            //狗狗会叫 猫咪会叫
            Animal An = new Cat();//Dog();
            An.Bark();

            Console.ReadKey();
        }
    }
    //关健词 abstract
    public abstract class Animal
    {
        //抽象方法是没有方法体的
        public abstract void Bark();
        public abstract string Name
        {
            get;
            set;
        }
        public int Age { get => _age; set => _age = value; }

        private int _age;
        

        public Animal(int age)
        {
            this.Age = age;
        }
        public Animal() { }

    }
    public class Dog : Animal
    {
        public override string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        //进行重写。
        public override void Bark()
        {
            Console.WriteLine("狗在汪汪叫");
        }
    }
    public class Cat : Animal
    {
        public override string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void Bark()
        {
            Console.WriteLine("猫猫在咪咪的叫");
        }
    }
}
