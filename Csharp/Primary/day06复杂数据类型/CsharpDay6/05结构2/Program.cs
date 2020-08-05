using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05结构2
{
    public struct Person
    {
        public string _name; //字段
        public int _age;
        public Gender _gender;

    }

    public enum Gender
    {
        男,
        女
    }


    class Program
    {
        static void Main(string[] args)
        {
            Person zPerson;
            zPerson._name = "zhangsan";
            zPerson._age = 13;
            zPerson._gender = Gender.男;

            Person lPerson;
            lPerson._name = "lisi";
            lPerson._age = 15;
            lPerson._gender = Gender.女;

            Console.WriteLine(zPerson._name);
            Console.ReadKey();

        }
    }
}
