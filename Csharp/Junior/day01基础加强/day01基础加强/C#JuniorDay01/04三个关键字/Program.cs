using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04三个关键字
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student s = new Student();
            //s.Name = "大黄老师";
            //s.Test();


            //Teacher t = new Teacher("大黄老师", 18, '女', 50, 50, 50);
            //t.ShowScore();
            //t.SayHi();

            //Teacher t2 = new Teacher("春老师", 18, '女');
            //t2.SayHi();

            Teacher t3 = new Teacher("张三", 100, 100, 100);
            t3.ShowScore();
            Console.ReadKey();
        }
    }

    class Person
    {
        public void SayHello()
        {
            Console.WriteLine("我是人类");
        }


    }

    class Student : Person
    {
        public new void SayHello()//彻底隐藏了父类的SayHello()
        {
            Console.WriteLine("我是学生");
        }

        public Student GetStudent()
        {
            return this;
        }

        public void GetPerson()
        {
            base.SayHello();
        }

        public string Name { get; set; }

        public void Test()
        {
            //局部变量优先级高于成员变量
            string Name = "春生老师";
            Console.WriteLine("我的名字叫{0}", this.Name);
        }
    }


    class Teacher
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public char Gender { get; set; }

        public int Chinese { get; set; }
        public int Math { get; set; }
        public int English { get; set; }


        public Teacher(string name, int age, char gender, int chinese, int math, int english)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.Chinese = chinese;
            this.Math = math;
            this.English = english;
        }


        public Teacher(string name, int age, char gender)
            : this(name, age, gender
                , 0, 0, 0)
        {

        }


        public Teacher(string name, int chinese, int math, int english)
            : this(name, 0, '\0', chinese, math, english)
        { }


        public void SayHi()
        {
            Console.WriteLine("我叫{0},今年{1}岁了,我是{2}生", this.Name, this.Age, this.Gender);
        }

        public void ShowScore()
        {
            Console.WriteLine("我叫{0}，我的总成绩是{1}，平均成绩是{2}", this.Name, this.Chinese + this.Math + this.English, (this.Chinese + this.Math + this.English) / 3);
        }
    }
}
