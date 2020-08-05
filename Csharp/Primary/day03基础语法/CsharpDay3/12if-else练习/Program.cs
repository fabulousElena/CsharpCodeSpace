using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12if_else练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //如果小赵的考试成绩大于90(含)分,那么爸爸奖励他100元钱,
            //否则的话,爸爸就让小赵跪方便面.
            //Console.WriteLine("请输入小赵的考试成绩");
            //int score = Convert.ToInt32(Console.ReadLine());
            //if (score >= 90)
            //{
            //    Console.WriteLine("奖励你一百块");
            //}
            //else
            //{
            //    Console.WriteLine("去跪方便面");
            //}
            //Console.ReadKey();

            //对学员的结业考试成绩评测
            //         成绩>=90 ：A
            //90>成绩>=80 ：B 	
            //80>成绩>=70 ：C
            //70>成绩>=60 ：D
            //         成绩<60   ：E


            Console.WriteLine("请输入学员的考试成绩");
            int score = Convert.ToInt32(Console.ReadLine());
            //最正确的做法

            if (score >= 90)
            {
                Console.WriteLine("A");
            }
            else if (score >= 80)
            {
                Console.WriteLine("B");
            }
            else if (score >= 70)
            {
                Console.WriteLine("C");
            }
            else if (score >= 60)
            {
                Console.WriteLine("D");
            }
            //else if (score < 60)
            //{
            //    Console.WriteLine("E");
            //}
            else
            {
                Console.WriteLine("E");
            }

            Console.ReadKey();




            #region if的做法
            //if (score >= 90 && score < 100)
            //{
            //    Console.WriteLine("A");
            //}
            //if (score >= 80 && score < 90)//ctrl+k+d
            //{
            //    Console.WriteLine("B");
            //}
            //if (score >= 70 && score < 80)
            //{
            //    Console.WriteLine("C");
            //}
            //if (score >= 60 && score < 70)//98  88
            //{
            //    Console.WriteLine("D");
            //}
            ////else
            ////{
            ////    Console.WriteLine("E");
            ////}
            //if (score < 60)
            //{
            //    Console.WriteLine("E");
            //}
            #endregion
            #region if else-if
            //if (score >= 90)
            //{
            //    Console.WriteLine("A");
            //}
            //else//<90 
            //{
            //    if (score >= 80)
            //    {
            //        Console.WriteLine("B");
            //    }
            //    else//<80
            //    {
            //        if (score >= 70)
            //        {
            //            Console.WriteLine("C");
            //        }
            //        else//<70
            //        {
            //            if (score >= 60)
            //            {
            //                Console.WriteLine("D");
            //            }
            //            else//<60
            //            {
            //                Console.WriteLine("E");
            //            }
            //        }
            //    }
            //} 
            #endregion
            Console.ReadKey();

        }
    }
}
