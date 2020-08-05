using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05里氏转换
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Student();
            Teacher t = person as Teacher;
            //Teacher s = (Teacher)person;
            if (person is Student)
            {
                Console.WriteLine("OK,可以转换");
            }
            else
            {
                Console.WriteLine("No,不可以转换");
            }
            //Console.WriteLine(s.Salary);
            Console.ReadKey();
            //Student student = new Student();
            //Teacher teacher = new Teacher();
           
        }
    }

    public class Person
    {
        public string Name
        {
            get;
            set;
        }
    }
    public class Student : Person
    {
        public int ID
        {
            get;
            set;
        }
    }
    public class Teacher:Person
    {
        public double Salary
        {
            get;
            set;
        }
    }
}
