using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04字符串
{
    class Program
    {
        static void Main(string[] args)
        {
            //字符串的不可变性
            //string name = "张三";
            //name = "孙全";
            //Console.WriteLine(name);
            //Console.ReadKey();

            //string s1 = "张三";
            //string s2 = "张三";
            //Console.ReadKey();

            //可以讲string类型 看做是char类型的一个只读数组
            string s = "abcdefg";
            s = "bbcdefg";
            // s[0] = 'b';不能这样做  因为是只读的
            //首先将字符串转换为char类型的数组
            char[] chs = s.ToCharArray();
            chs[0] = 'b';
            //将字符数组转换为我们的字符串
            s = new string(chs);
            //既然可以将string看做char类型的只读数组，所以我可以通过下标去访问字符串中的某一个元素
            Console.WriteLine(s[0]);
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
