using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02访问修饰符
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
        }
    }

    public class Person
    {
        //protected string _name;
        //public int _age;
        //private char _gender;
        //internal int _chinese;
        //protected internal int _math;
    }

    public class Student : Person
    { 
        
    }

    //public class Student:Person
    //{ 
        
    //}
}
