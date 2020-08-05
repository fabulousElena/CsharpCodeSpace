using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06里氏转换
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Student();

            //if (person is Teacher)
            //{
            //    ((Teacher)person).TeacherSayHello();
            //}
            //else
            //{
            //    Console.WriteLine("转换失败");
            //}

            Student s = person as Student;//将person转换为student对象
            if (s != null)
            {
                s.StudentSayHello();
            }
            else
            {
                Console.WriteLine("转换失败");
            }
            Console.ReadKey();
            //is as
        }
    }
    class Person
    {
        public void PersonSayHello()
        {
            Console.WriteLine("我是父类");
        }
    }

    class Student : Person
    {
        public void StudentSayHello()
        {
            Console.WriteLine("我是学生");
        }
    }

    class Teacher : Person
    {
        public void TeacherSayHello()
        {
            Console.WriteLine("我是老师");
        }
    }
}
