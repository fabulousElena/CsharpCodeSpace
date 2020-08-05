using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace _06序列化
{
    class Program
    {
        static void Main(string[] args)
        {
            //要将序列化对象的类 标记为可以被序列化的

            //Person p = new Person();
            //p.Name = "张三";
            //p.Age = 10;
            //p.Gender = '男';

            //using (FileStream fsWrite = new FileStream(@"C:\Users\SpringRain\Desktop\new.txt", FileMode.OpenOrCreate, FileAccess.Write))
            //{
            //    BinaryFormatter bf = new BinaryFormatter();
            //    bf.Serialize(fsWrite, p);
            //}
            //Console.WriteLine("序列化成功");

            //Console.ReadKey();
              
            Person p;
            using (FileStream fsRead = new FileStream(@"C:\Users\SpringRain\Desktop\new.txt", FileMode.OpenOrCreate, FileAccess.Read))
            {
                BinaryFormatter bf = new BinaryFormatter();
                p = (Person)bf.Deserialize(fsRead);
            }
            Console.WriteLine(p.Name);
            Console.WriteLine(p.Age);
            Console.WriteLine(p.Gender);
            Console.ReadKey();

        }
    }

    [Serializable]
    public class Person
    {
        public string Name
        {
            get;
            set;
        }

        public int Age
        {
            get;
            set;
        }
        public char Gender
        {
            get;
            set;
        }
    }
}
