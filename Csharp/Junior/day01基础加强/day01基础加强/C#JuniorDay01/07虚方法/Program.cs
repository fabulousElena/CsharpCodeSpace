using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07虚方法
{
    class Program
    {
        static void Main(string[] args)
        {
            //员工九点打卡  经理11点打卡 程序猿不打卡

           // Employee emp = new Employee();
           //// emp.DaKa();
           // Manager m = new Manager();
           // //m.DaKa();
           // Programmer p = new Programmer();
           // //p.DaKa();

          //  Employee e = m;

            //Employee[] emps = { emp, m, p };
            //for (int i = 0; i < emps.Length; i++)
            //{
            //    //if (emps[i] is Manager)
            //    //{
            //    //    ((Manager)emps[i]).DaKa();  
            //    //}
            //    //else if (emps[i] is Programmer)
            //    //{
            //    //    ((Programmer)emps[i]).DaKa();
            //    //}
            //    //else
            //    //{
            //    //    emps[i].DaKa();
            //    //}
            //    emps[i].DaKa();
            //}

            Employee emp = new Programmer();//new Manager(); //new Employee();
            emp.DaKa();


            Console.ReadKey();
        }
    }

    class Employee
    {
        public virtual void DaKa()
        {
            Console.WriteLine("员工九点打卡");
        }
    }

    class Manager : Employee
    {
        public override void DaKa()
        {
            Console.WriteLine("经理11点打卡");
        }
    }

    class Programmer : Employee
    {
        public override void DaKa()
        {
            Console.WriteLine("程序猿不打卡");
        }
    }
}
