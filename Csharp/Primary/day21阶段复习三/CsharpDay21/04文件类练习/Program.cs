using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04文件类练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //案例：对职工工资文件处理，所有人的工资加倍然后输出到新文件。
            //文件案例：
            //马大哈|3000
            //宋江|8000

            string[] str = File.ReadAllLines(@"C:\Users\SpringRain\Desktop\工资1.txt", Encoding.UTF8);
            for (int i = 0; i < str.Length; i++)
            {
                //张三|5000
                string[] strNew = str[i].Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                //张三  5000
                //int salary = int.Parse(strNew[1]) * 2;
                strNew[1] = (int.Parse(strNew[1]) * 2).ToString();
                //10000
                File.AppendAllLines(@"C:\Users\SpringRain\Desktop\工资1.txt", strNew,Encoding.UTF8);
             //   str[i] = strNew[0] + salary.ToString();
              //  File.WriteAllLines();
            }

         //   File.WriteAllLines(@"C:\Users\SpringRain\Desktop\工资.txt", str);
            Console.WriteLine("Ok");
            Console.ReadKey();
        }
    }
}
