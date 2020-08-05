using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProOperation;

namespace _06简单工厂设计模式之计算器练习
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入第一个数字");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入第二个数字");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入操作符");
            string oper = Console.ReadLine();

            //根据用户输入的操作符 返回算符的父类

            Operation operation = GetOperation(oper, n1, n2);
            if (operation != null)
            {
                int result = operation.GetResult();
                Console.WriteLine("{0}{1}{2}={3}", n1, oper, n2, result);
            }
            else
            {
                Console.WriteLine("没有你想要的运算符");
            }
            Console.ReadKey();
        }

        static Operation GetOperation(string oper, int n1, int n2)
        {
            Operation operation = null;
            switch (oper)
            { 
                case "+":
                    operation = new Add(n1, n2);
                    break;
                case "-":
                    operation = new Sub(n1, n2);
                    break;
                case "*":
                    operation = new Cheng(n1, n2);
                    break;
                case "/":
                    operation = new Chu(n1, n2);
                    break;
            }
            return operation;
        }
    }
}
