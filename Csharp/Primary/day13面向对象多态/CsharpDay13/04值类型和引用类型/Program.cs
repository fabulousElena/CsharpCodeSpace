using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04值类型和引用类型
{
    class Program
    {
        static void Main(string[] args)
        {
            //值类型:int double char decimal bool enum struct 
            //引用类型：string 数组  自定义类 集合 object 接口

            //值传递和引用传递
            //int n1 = 10;
            //int n2 = n1;
            //n2 = 20;
            //Console.WriteLine(n1);
            //Console.WriteLine(n2);
            //Console.ReadKey();

            //Person p1 = new Person();
            //p1.Name = "张三";
            //Person p2 = p1;
            //p2.Name = "李四";
            //Console.WriteLine(p1.Name);
            //Console.ReadKey();

            //Person p = new Person();
            //p.Name = "张三";
            //Test(p);
            //Console.WriteLine(p.Name);
            //Console.ReadKey();

            //string s1 = "张三";
            //string s2 = s1;
            //s2 = "李四";
            //Console.WriteLine(s1);
            //Console.WriteLine(s2);
            //Console.ReadKey();

            int number = 10;
            TestTwo(ref  number);
            Console.WriteLine(number);
            Console.ReadKey();
        }
        //int n=number;
        public static void TestTwo(ref  int n)
        {
            n += 10;
        }

        //Person pp=p;
        public static void Test(Person pp)
        {
            Person p = pp;
            p.Name = "李四";
        }
    }

    public class Person
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }
}
