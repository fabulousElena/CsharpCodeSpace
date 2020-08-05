using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01索引器
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p[0] = "张三";
            p[1] = "李四";
            p[1, 1] = "新数组";
            p[2, 1] = "新数组";
            //p["张三"] = 15;
            //p["李四"] = 20;
          //  p[]
            //p[0] = 1;
            //p[1] = 2;
            //Console.WriteLine(p[0]);
            //Console.WriteLine(p[1]);
            Console.ReadKey();
        }
    }


    public class Person
    {
        //int[] nums = new int[10];
        //public int this[int index]
        //{
        //    get { return nums[index]; }
        //    set { nums[index] = value; }
        //}
        //string[] names = new string[10];
        ////public string this[int index]
        ////{
        ////    get { return names[index]; }
        ////    set { names[index] = value; }
        ////}

        string[] names = new string[10];
        string[] newNames = new string[20];
        public string this[int index]
        {
            get { return names[index]; }
            set { names[index] = value; }
        }

        public string this[int index,int n]
        {
            get { return newNames[index]; }
            set { newNames[index] = value; }
        }
      ////  List<string> list = new List<string>();
      //  Dictionary<string, int> dic = new Dictionary<string, int>();
      //  public int this[string index]
      //  {
      //      get { return dic[index]; }
      //      set { dic[index] = value; }
      //  }



            

    }
}
