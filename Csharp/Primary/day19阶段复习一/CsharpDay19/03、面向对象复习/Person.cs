using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_面向对象复习
{
    class Person
    {
        //字段、属性、构造函数、方法、接口
        string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                if (value != "孙全")
                {
                    value = "孙全";
                }
                _name = value;
            }
        }
        int _age;
        public int Age
        {
            get
            {
                if (_age < 0 || _age > 100)
                {
                    return _age = 0;
                }
                return _age;
            }
            set { _age = value; }
        }
        char _gender;
        public char Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        int _chinese;

        public int Chinese
        {
            get { return _chinese; }  
            set { _chinese = value; }
        }

        int _math;

        public int Math
        {
            get { return _math; }
            set { _math = value; }
        }

        int _english;

        public int English
        {
            get { return _english; }
            set { _english = value; }
        }

        public Person(char gender)
        {
            if (gender != '男' && gender != '女')
            {
                gender = '男';
            }
            this.Gender = gender;
        }


        public Person(string name, int age, char gender, int chinese, int math, int english)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.Chinese = chinese;
            this.Math = math;
            this.English = english;
        }

        public Person(string name, int age, char gender)
            : this(name, age, gender, 0, 0, 0)
        {
            //this.Name = name;
            //this.Age = age;
            //this.Gender = gender;
        }


        public Person()
        {

        }
        public void SayHello()
        {
            // string Name = "张三";
            Console.WriteLine("{0}---{1}----{2}", this.Name, this.Age, this.Gender);
        }
    }
}
