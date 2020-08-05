using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_结构和类的区别
{
    class Program
    {
        static void Main(string[] args)
        {
            //类型
            //结构：值类型 
            //类：引用类型

            //声明的语法：class  struct

            //在类中，构造函数里，既可以给字段赋值，也可以给属性赋值。构造函数是可以重载的
            //但是，在结构的构造函数当中，必须只能给字段赋值。
            //在结构的构造函数当中，我们需要给全部的字段赋值，而不能去选择的给字段赋值

            //调用：

            PersonClass pc = new PersonClass();


            //结构是否可以New？
            //在栈开辟空间  结构new  调用结构的构造函数
            PersonStruct ps = new PersonStruct();
            ps.M2();
            PersonStruct.M1();
            Console.ReadKey();
            //结构和类的构造函数：
            //相同点：不管是结构还是类，本身都会有一个默认的无参数的构造函数
            //不同点:当你在类中写了一个新的构造函数之后，那个默认的无参数的构造函数都被干掉了
            //但是，在结构当中，如果你写了一个新的构造函数，那么个默认的无参数的构造函数依然在。
            //
            //如果我们只是单纯的存储数据的话，我们推荐使用结构。

            //如果我们想要使用面向对象的思想来开发程序，我们推荐使用我们的Class

            //结构并不具备面向对象的特征


          //  int
        }
    }

    public class PersonClass
    { 
        //字段、属性、方法、构造函数
    }

    public struct PersonStruct
    {
        //字段、属性
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private int _age;
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        private char _gender;
        public char Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        public static void M1()
        {
            Console.WriteLine("我是结构中的静态方法");
        }
        public void M2()
        {
            Console.WriteLine("我是结构的非静态方法");
        }

        public PersonStruct(string name, int age, char gender)
        {
            //this.Name = name;
            //this.Age = age;
            //this.Gender = gender;

            this._name = name;
            this._age = age;
            this._gender = gender;
        }


        //public PersonStruct(string name)
        //{
        //    this._name = name;
        //}

    }
}
