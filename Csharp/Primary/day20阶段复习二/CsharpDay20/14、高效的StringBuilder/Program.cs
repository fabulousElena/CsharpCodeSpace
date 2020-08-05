using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_高效的StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("张三");
            sb.Append("李四");
            sb.Append("王五");
            sb.Insert(1, 123);
            sb.Replace("李四", "颜世伟");
            sb.Replace("颜世伟", "杀马特");
            Console.WriteLine(sb.ToString());
            Console.ReadKey();
        }
    }
}
