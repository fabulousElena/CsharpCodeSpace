using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04protected访问修饰符
{
    class Program
    {
        static void Main(string[] args)
        {
            //public private
            Person p = new Person();
            
        }
    }

    public class Person
    {
        protected string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }


    public class Student : Person
    {
        public void Test()
        { 
            
        }
    }
}
