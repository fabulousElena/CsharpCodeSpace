using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_抽象类
{
    class Program
    {
        static void Main(string[] args)
        {
            //狗狗会叫 猫咪会叫

            Animal a = new Cat();//new Dog();
            a.Bark();
            
            Console.ReadKey();
        }
    }

    public abstract class Animal
    {

        public virtual void T()
        {
            Console.WriteLine("Animal live matters");
        }

        private int _age;

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public Animal(int age)
        {
            this.Age = age;
        }
        public abstract void Bark();
        public abstract string Name
        {
            get;
            set;
        }

     //   public abstract string TestString(string name);


        public Animal()
        { 
            
        }
        //public void Test()
        //{ 
        //    //空实现
        //}
    }


    public abstract class Test : Animal
    { 
        
    }

    public class Dog : Animal
    {
       // public abstract void Test();


        public override void Bark()
        {
            Console.WriteLine("狗狗旺旺的叫");
        }

        public override string Name
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        //public override string TestString(string name)
        //{
        //    //throw new NotImplementedException();
        //}
    }

    public class Cat : Animal
    {
        public override void Bark()
        {
            Console.WriteLine("猫咪喵喵的叫");
        }

        public override string Name
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
