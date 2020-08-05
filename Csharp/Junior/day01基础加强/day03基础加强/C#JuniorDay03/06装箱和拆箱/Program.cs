using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Diagnostics;
namespace _06装箱和拆箱
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList list = new ArrayList();
            //00:00:00.5282219
            //00:00:00.0750373
            //List<int> list = new List<int>();
            ////list.Add(100)
            //Stopwatch sw = new Stopwatch();
            //sw.Start();
            //for (int i = 0; i < 1000000; i++)
            //{

            //    list.Add(i);
            //}
            //sw.Stop();
            //Console.WriteLine(sw.Elapsed);
            //Console.ReadKey();

            //int n = 10;
            //object o = n;//装箱

            //double d = (double)o;
            //Console.WriteLine(d);
            //Console.ReadKey();

            //int n = 10;
            //IComparable com=n;//装箱操作

            // Test(100)

            //int n = 10;
            //object o = n;//装箱
            //n = 100;
            //Console.WriteLine(n + "," + (int)o);
            //Console.ReadKey();

            ////int n = 10;
            ////double d = 3.14;
            ////string s = "zhangsan";
            ////Console.WriteLine(n + d + s);

            ////string.Concat()

            //int n = 10;
            //string s1 = n.ToString();
            //string s2 = n.GetType().ToString();//由于GetType()不是虚方法子类没有重写，所以调用时需要通过object来调用，查看IL
            //Console.WriteLine(s1 + "\t\t\t" + s2);

            string s1 = "a";
            int n1 = 10;
            double d1 = 99.9;
            object o = 10;
            string s2 = "x";
            string s3 = s1 + n1 + d1 + o + s2;
            Console.WriteLine(s3);
            Console.ReadKey();
            //string.Concat()


        }

        static void Test(object o)
        { }

        static void Test(int n)
        { }
    }
}
