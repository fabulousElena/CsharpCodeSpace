using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04面向对象练习02
{
    class Student
    {
        /// <summary>
        /// 构造体
        /// </summary>
        /// <param name="name">姓名</param>
        /// <param name="age">年龄</param>
        /// <param name="gender">性别</param>
        public Student(string name, int age, char gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;

        }

        private string _name;
        private int _age;
        private char _gender;

        public string Name { get => _name; set => _name = value; }
        public int Age { get => _age; set => _age = value; }
        public char Gender { get => _gender; set => _gender = value; }

        public void SayHello() {
            Console.WriteLine(this.Name + this.Age + this.Gender);
        }
    }
}
