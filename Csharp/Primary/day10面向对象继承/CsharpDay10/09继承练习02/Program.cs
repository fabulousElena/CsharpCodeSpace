using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09继承练习02
{
    class Program
    {
        static void Main(string[] args)
        {
            //记者：我是记者  我的爱好是偷拍 我的年龄是34 我是一个男狗仔
            //司机：我叫舒马赫 我的年龄是43 我是男人  我的驾龄是 23年
            //程序员：我叫孙全 我的年龄是23 我是男生 我的工作年限是 3年
            Reporter rp = new Reporter("张三", 15, "男", "偷拍");
            rp.ReporterSayHello();
            Console.WriteLine(rp.Name);
            Console.ReadKey();
        }
    }

    class Person
    {
        //共同属性：姓名，年龄。性别
        private string _name;
        private int _age;
        private string _gender;

        public Person(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }

        public string Gender { get => _gender; set => _gender = value; }
        public int Age { get => _age; set => _age = value; }
        public string Name { get => _name; set => _name = value; }
    }

    class Reporter : Person
    {
        public Reporter(string name, int age, string gender, string hobby) : base(name, age, gender)
        {
            this.Hobby = hobby;
        }
        private string _hobby;

        public string Hobby { get => _hobby; set => _hobby = value; }

        public void ReporterSayHello()
        {
            Console.WriteLine("我叫{0},我是一名狗仔，我的爱好是{1}，我是{2}生，我今年{3}岁了", this.Name, this.Hobby, this.Gender, this.Age);
        }
    }

    class Driver : Person
    {
        public Driver(string name, int age, string gender, int driverAge) : base(name, age, gender)
        {
            this.DriverAge = driverAge;
        }

        int _driverAge;

        public int DriverAge { get => _driverAge; set => _driverAge = value; }

        public void DriverSayHello()
        {
            Console.WriteLine("我叫{0}，我是一名司机，我是{1}生，我今年{2}岁了，我的驾驶年限是{3}年", this.Name, this.Gender, this.Age, this.DriverAge);
        }

    }

}
