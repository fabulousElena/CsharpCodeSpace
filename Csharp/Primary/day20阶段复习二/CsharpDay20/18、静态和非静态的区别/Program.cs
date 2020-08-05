using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_静态和非静态的区别
{
    class Program
    {
        static void Main(string[] args)
        {
            Student.Test();
            Student.Test();
            Student.Test();
            Console.ReadKey();
        }
    }

    public class Person
    {
        private static string _name;
        private int _age;
        public void M1()
        { 
           
        }

        public static void M2()
        { 
            
        }


        public Person()
        {
            Console.WriteLine("非静态类构造函数");
        }

    }

    public static class Student
    {
         static Student()
        {
            Console.WriteLine("静态类构造函数");
        }

         public static void Test()
         {
             Console.WriteLine("我是静态类中的静态方法");
         }
      //  private string _name;
    }
}
