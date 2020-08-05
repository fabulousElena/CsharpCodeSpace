using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11接口的使用
{
    class Program
    {
        static void Main(string[] args)
        {
            //实现多态
            IKouLan kl = new Driver();//new Teacher();//new Student();
            kl.KouLan();
            Console.ReadKey();
        }
    }

    class Person
    {
        public void CHLSS()
        {
            Console.WriteLine("人类可以吃喝拉撒睡");
        }
    }

    class NoTuiPerson : Person
    {

    }

    class Student : Person, IKouLan
    {
        public void KouLan()
        {
            Console.WriteLine("学生可以扣篮");
        }
    }
    class Teacher : Person, IKouLan
    {

        public void KouLan()
        {
            Console.WriteLine("老师也可以扣篮");
        }
    }

    class Driver : Person, IKouLan
    {
        public void KouLan()
        {
            Console.WriteLine("司机也可以扣篮");
        }
    }

    interface IKouLan
    {
        void KouLan();
    }


    class NBAPlayer : Person
    {
        public void KouLan()
        {
            Console.WriteLine("NBA球员可以扣篮");
        }
    }
}
