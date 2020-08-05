using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04虚方法和抽象类
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    } 
    public abstract class Person
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public Person(string name)
        {
            this.Name = name;
        }
        public Person()
        { 
        
        }
        public  virtual void SayHello()
        { 
            
        }
        public abstract   double Test(string name);

      //  public abstract void Test();
    }

    public class Student : Person
    {

        public override double Test(string name)
        {
            return 123;
        }
       // public abstract void M();
        //public  void SayHello()
        //{
            
        //}
    }
}
