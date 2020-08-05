using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06多态复习
{
    class Program
    {
        static void Main(string[] args)
        {
            //虚方法、抽象类、接口
            //面向对象计算器 案例
            while (true)
            {
                Console.WriteLine("请输入第一个数字");
                double n1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("请输入第二个数字");
                double n2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("请输入运算符");
                string opera = Console.ReadLine();
                CalFather cal = GetCal(opera, n1, n2);
                double res = cal.GetResult();
                Console.WriteLine(res);
                Console.ReadKey();
            }
           
        }

        public static CalFather GetCal(string opear, double n1, double n2)
        {
            CalFather cal = null;
            switch (opear)
            {
                case "+": cal = new Add(n1, n2);
                    break;
                case "-": cal = new Sub(n1, n2);
                    break;
                case "*": cal = new Cheng(n1, n2);
                    break;
                case "/": cal = new Chu(n1, n2);
                    break;
            }
            return cal;
        }
    }


    public abstract class CalFather
    {
        public double NumberOne
        {
            get;
            set;
        }

        public double NumberTwo
        {
            get;
            set;
        }

        public CalFather(double n1, double n2)
        {
            this.NumberOne = n1;
            this.NumberTwo = n2;
        }


        public abstract double GetResult();
    }


    public class Add : CalFather
    {
        public Add(double n1, double n2)
            : base(n1, n2)
        {

        }

        public override double GetResult()
        {
            return this.NumberOne + this.NumberTwo;
        }
    }

    public class Sub : CalFather
    {
        public Sub(double n1, double n2)
            : base(n1, n2)
        {

        }

        public override double GetResult()
        {
            return this.NumberOne - this.NumberTwo;
        }
    }

    public class Cheng : CalFather
    {
        public Cheng(double n1, double n2)
            : base(n1, n2)
        {

        }

        public override double GetResult()
        {
            return this.NumberOne * this.NumberTwo;
        }
    }

    public class Chu : CalFather
    {
        public Chu(double n1, double n2)
            : base(n1, n2)
        {

        }

        public override double GetResult()
        {
            return this.NumberOne / this.NumberTwo;
        }
    }
}
