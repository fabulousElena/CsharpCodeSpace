using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10多态练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //真的鸭子嘎嘎叫 木头鸭子吱吱叫 橡皮鸭子唧唧叫
            //RealDuck rd = new RealDuck();
            //rd.Bark();
            //MuDuck md = new MuDuck();
            //md.Bark();
            //XPDuck xd = new XPDuck();
            //xd.Bark();
            //Console.ReadKey();

            //RealDuck rd = new RealDuck();
            //MuDuck md = new MuDuck();
            //XPDuck xd = new XPDuck();
            //RealDuck[] ducks = { rd, md, xd };
            //for (int i = 0; i < ducks.Length; i++)
            //{
            //    ducks[i].Bark();
            //}
            //Console.ReadKey();


            //经理十一点打卡 员工9点打卡 程序猿不打卡
            //Employee emp = new Employee();
            //Manager mg = new Manager();
            //Programmer pm = new Programmer();
            //Employee[] emps = { emp, mg, pm };
            //for (int i = 0; i < emps.Length; i++)
            //{
            //    emps[i].DaKa();
            //}
            //Console.ReadKey();



            //狗狗会叫 猫咪也会叫

        }
    }

    public class Animal
    {
        public void Bark()
        { 
            
        }
    }


    public class Employee
    {
        public virtual void DaKa()
        {
            Console.WriteLine("九点打卡");
        }
    }

    public class Manager : Employee
    {
        public override void DaKa()
        {
            Console.WriteLine("经理11点打卡");
        }
    }

    public class Programmer : Employee
    {
        public override void DaKa()
        {
            Console.WriteLine("程序猿不打卡");
        }
    }





    public class RealDuck
    {
        public virtual void Bark()
        {
            Console.WriteLine("真的鸭子嘎嘎叫");
        }
    }

    public class MuDuck : RealDuck
    {
        public override void Bark()
        {
            Console.WriteLine("木头鸭子吱吱叫");
        }
    }

    public class XPDuck : RealDuck
    {
        public override void Bark()
        {
            Console.WriteLine("橡皮鸭子唧唧叫");
        }
    }
}
