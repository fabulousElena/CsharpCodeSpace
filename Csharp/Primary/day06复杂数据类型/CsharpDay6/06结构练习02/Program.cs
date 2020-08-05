using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06结构练习02
{
    public struct Person {
        public string _name;
        public int _age;
        public Gender _gender;

    }

    public enum Gender {
        男,   
        女

    }


    class Program
    {
        static void Main(string[] args)
        {
            Person zhangSan;
            Person liSi;
            zhangSan._name = "awei";
            zhangSan._age = 18;
            zhangSan._gender = Gender.男;

            liSi._name = "lisi";
            liSi._age = 22;
            liSi._gender = Gender.女;
        }
    }
}
