using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02方法的练习
{
    class Programe
    {
        static void Main(string[] args)
        {
            //95、接受输入后判断其等级并显示出来。
            //判断依据如下：等级={优 （90~100分）；良 （80~89分）
            //Console.WriteLine("请输入考试成绩");
            //int score = Convert.ToInt32(Console.ReadLine());

            //string level = GetLevel(score);
            //Console.WriteLine(level);
            //Console.ReadKey();


            //97、请将字符串数组{ "中国", "美国", "巴西", "澳大利亚", "加拿大" }中的内容反转
            //string[] names = { "中国", "美国", "巴西", "澳大利亚", "加拿大" };
            //Test(names);
            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.WriteLine(names[i]);
            //}
            //Console.ReadKey();

            //98写一个方法 计算圆的面积和周长  面积是 pI*R*R  周长是 2*Pi*r

            double r = 5;
            double perimeter;
            double area;
            GetPerimeterArea(r, out perimeter, out area);
            Console.WriteLine(perimeter);
            Console.WriteLine(area);
            Console.ReadKey();
        }


        public static void GetPerimeterArea(double r, out double perimeter,out double area)
        {
            perimeter = 2 * 3.14 * r;
            area = 3.14 * r * r;
        }








        public static void Test(string[] names)
        {
            for (int i = 0; i < names.Length / 2; i++)
            {
                string temp = names[i];
                names[i] = names[names.Length - 1 - i];
                names[names.Length - 1 - i] = temp;
            }
        }


        public static string GetLevel(int score)
        {
            string level = "";
            switch (score / 10)
            {
                case 10:
                case 9: level = "优"; break;
                case 8: level = "良"; break;
                case 7: level = "中"; break;
                case 6: level = "差"; break;
                default: level = "不及格";
                    break;
            }
            return level;
        }

    }
}
