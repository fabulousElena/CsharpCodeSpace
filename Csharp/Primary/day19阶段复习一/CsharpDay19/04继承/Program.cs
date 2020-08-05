using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04继承
{
    class Program
    {
        static void Main(string[] args)
        {
        }  
    }


    public class Person
    {

        public Person(string name, int age, char gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }
        public void CHLSS()
        { 
            
        }
        public string Name
        {
            get;
            set;
        }
        public char Gender
        {
            get;
            set;
        }
        public int Age
        {
            get;
            set;
        }
    }
    public class Student:Person
    {
        //在子类中调用父类的构造函数 使用关键字 base
        public Student(string name, int age, char gender, int id)
            : base(name, age, gender)
        {
            this.ID = id;
        }


        public int ID
        {
            get;
            set;
        }
    }


    public class Teacher:Person
    {
        public Teacher(string name, int age, char gender, double salary)
            : base(name, age, gender)
        {
            this.Salary = salary;
        }


        public double Salary
        {
            get;
            set;
        }
    }

}
