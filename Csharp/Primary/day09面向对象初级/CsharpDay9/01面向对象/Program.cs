using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01面向对象
{
    class Program
    {
        static void Main(string[] args)
        {
            // string s;
            // Person sunQuan;//自定义类
            // 创建Person类的对象
            Person suQuan = new Person();
            suQuan.Name = "孙全";
            suQuan.Age = 23;
            suQuan.Gender = '春';
            suQuan.CHLSS();
            Console.ReadKey();
        }
    }
}
