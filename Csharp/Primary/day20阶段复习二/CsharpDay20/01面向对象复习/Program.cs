using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01面向对象复习
{
    class Program
    {
        static void Main(string[] args)
        {
            //this 
            //new
            Person p = new Person();
           
        }
    }

    public class Person
    {

        protected string _name;
        internal int _age;
    }

    internal class Teacher : Person
    {
        public void T()
        { 
            
        }
    }
}
