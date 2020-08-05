using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05结构
{
    public struct Person
    {
        public string _name;//字段
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
            //XX大学管理系统
            //姓名、性别、年龄、年级  //5000  20000
            //string zsName = "张三";
            //int zsAge = 21;
            //char zsGender = '男';
            //int zsGrade = 3;

             string s = "123";

            Person zsPerson;
            zsPerson._name = "张三";
            zsPerson._age = 21;
            zsPerson._gender = Gender.男;


            Person lsPerson;
            lsPerson._name = "李四";
            lsPerson._age = 22;
            lsPerson._gender = Gender.女;


            Console.WriteLine(zsPerson._name);
            Console.WriteLine(lsPerson._name);
            Console.ReadKey();

        }
    }
}
