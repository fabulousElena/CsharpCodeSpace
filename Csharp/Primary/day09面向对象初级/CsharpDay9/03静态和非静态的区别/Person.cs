using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03静态和非静态的区别
{
    public class Person
    {
        private static string _name;

        public static string Name
        {
            get { return Person._name; }
            set { Person._name = value; }
        }
        private char _gender;

        public char Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
        public void M1()
        {
           
            Console.WriteLine("我是非静态的方法");
        }
        public static void M2()
        {
            
            Console.WriteLine("我是一个静态方法");
        }
    }
}
