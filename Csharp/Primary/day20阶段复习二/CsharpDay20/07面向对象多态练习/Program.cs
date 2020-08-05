using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07面向对象多态练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //作业:员工类、部门经理类 程序猿类
            //（部门经理也是员工，所以要继承自员工类。员工有上班打卡的方法。用类来模拟。

            Employee emp = new Programmer();//new Manager();//new Employee();
            emp.DaKa();
            Console.ReadKey();
        }
    }
    public class Employee
    {
        public virtual void DaKa()
        {
            Console.WriteLine("员工九点打卡");
        }
    }

    public class Manager : Employee
    {
        public override void DaKa()
        {
            Console.WriteLine("经理十一点打卡");
        }
    }

    public class Programmer : Employee
    {
        public override void DaKa()
        {
            Console.WriteLine("程序猿不打卡");
        }
    }

}
