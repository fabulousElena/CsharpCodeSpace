using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.IO;
using _01复习;

namespace _02_命名空间
{
    class Program
    {
        static void Main(string[] args)
        {
            Person zsPerson = new Person();
            zsPerson.Name = "张三";
            Console.WriteLine(zsPerson.Name);
            Console.ReadKey();

            //A--->ProjectA---顾客类
            //B--->ProjcetB---顾客类
            //C-->ProjectC---顾客类
        }
    }
}
