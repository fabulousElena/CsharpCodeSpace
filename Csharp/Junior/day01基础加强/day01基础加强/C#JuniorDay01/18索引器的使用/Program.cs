using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18索引器的使用
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] nums = { 1, 2, 3, 4, 5 };
            //Console.WriteLine(nums[2]);
            Person p = new Person();
            //p.Numbers = new int[] { 1, 2, 3, 4, 5 };

            p[0] = 1;
            p[1] = 2;
            p[2] = 3;
            p[3] = 4;
            Console.WriteLine(p[0]);
            Console.WriteLine(p[1]);


            p["张三"] = "一个好人";
            p["大黄"] = "汪汪汪";
            p["春生"] = "哈哈哈";
            Console.ReadKey();
        }
    }

    class Person
    {
        private int[] numbers = new int[5];

        public int[] Numbers
        {
            get { return numbers; }
            set { numbers = value; }
        }

        //索引器 让对象以索引的方式操作数组
        public int this[int index]
        {
            get { return numbers[index]; }
            set { numbers[index] = value; }
        }


        Dictionary<string, string> dic = new Dictionary<string, string>();
        public string this[string index]
        {
            get { return dic[index]; }
            set { dic[index] = value; }
        }


        Dictionary<int, string> dic2 = new Dictionary<int, string>();
      
    }
}
