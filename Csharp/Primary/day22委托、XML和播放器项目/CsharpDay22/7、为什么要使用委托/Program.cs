using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_为什么要使用委托
{
    public delegate string DelProStr(string name);
    class Program
    {
        static void Main(string[] args)
        {
            //三个需求
            //1、将一个字符串数组中每个元素都转换成大写
            //2、将一个字符串数组中每个元素都转换成小写
            //3、将一个字符串数组中每个元素两边都加上 双引号
            string[] names = { "abCDefG", "HIJKlmnOP", "QRsTuvW", "XyZ" };
            //ProStToUpper(names);
            //ProStrToLower(names);
            // ProStrSYH(names);

            ProStr(names, delegate(string name)
            {
                return "\"" + name + "\"";
            });
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.ReadKey();
        }


        public static void ProStr(string[] name, DelProStr del)
        {
            for (int i = 0; i < name.Length; i++)
            {
                name[i] = del(name[i]);
            }
        }

        //public static string StrToUpper(string name)
        //{
        //    return name.ToUpper();
        //}

        //public static string StrToLower(string name)
        //{
        //    return name.ToLower();
        //}

        //public static string StrSYH(string name)
        //{
        //    return "\"" + name + "\"";
        //}


        //public static void ProStToUpper(string[] name) 
        //{
        //    for (int i = 0; i < name.Length; i++)
        //    {
        //        name[i] = name[i].ToUpper();
        //    }
        //}
        //public static void ProStrToLower(string[] name)
        //{
        //    for (int i = 0; i < name.Length; i++)
        //    {
        //        name[i] = name[i].ToLower();
        //    }
        //}
        //public static void ProStrSYH(string[] names)
        //{
        //    for (int i = 0; i < names.Length; i++)
        //    {
        //        names[i] = "\"" + names[i] + "\"";
        //    }
        //}


    }
}
