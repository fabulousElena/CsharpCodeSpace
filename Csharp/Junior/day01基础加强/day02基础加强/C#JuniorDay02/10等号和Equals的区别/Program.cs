using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10等号和Equals的区别
{
    class Program
    {
        static void Main(string[] args)
        {
            //对于string类型而言，不管是等号还是Equals比较的都是值本身。
            //Equals默认比较的是地址，但是我们在自己定义的类中如果用到Equals，都会将Equals进行重写，使之按照我们自己的需求进行比较
            Person p1 = new Person() { Name = "刘德华", Age = 18 };
            Person p2 = new Person() { Name = "刘德华", Age = 18 };
            //if (p1.Equals(p2))
            //{
            //    Console.WriteLine("相等");
            //}
            //else
            //{
            //    Console.WriteLine("不相等");
            //}

            Console.WriteLine(p1.ToString());//这个对象所在的类的命名空间

            Console.WriteLine(p2.ToString());
            //StringBuilder sb = new StringBuilder();
            //sb.Append("123");
            //sb.Append("张三");
            //Console.WriteLine(sb.ToString());
            Console.ReadKey();
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }


        public override bool Equals(object obj)
        {
            Person person = obj as Person;
            if (this.Name == person.Name && this.Age == person.Age)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }


        public override string ToString()
        {
            return "哈哈哈，我是被重写的ToString()";
        }
      
    }
}
