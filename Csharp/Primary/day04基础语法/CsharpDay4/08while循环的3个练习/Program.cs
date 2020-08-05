using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08while循环的3个练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //输入班级人数,然后依次输入学员成绩，计算班级学员的平均成绩和总成绩
            //10 
            //循环体：提示输入学员成绩，接收，并转换成整数类型，累加到总成绩当中
            //循环条件：循环的次数小于等于班级人数

            //Console.WriteLine("请输入班级人数");
            //int count = Convert.ToInt32(Console.ReadLine());
            //int sum = 0;//用来存放总成绩
            //int i=1;//声明一个循环变量用来记录循环的次数
            //while (i <= count)
            //{
            //    Console.WriteLine("请输入第{0}个学员的考试成绩",i);
            //    int score = Convert.ToInt32(Console.ReadLine());
            //    //表示把每一个学员的成绩累加到总成绩当中
            //    sum += score;
            //    i++;
            //}
            //Console.WriteLine("{0}个人的班级总成绩是{1}平均成绩是{2}",count,sum,sum/count);
            //Console.ReadKey();


            //老师问学生,这道题你会做了吗?如果学生答"会了(y)",
            //则可以放学.如果学生不会做(n),则老师再讲一遍,再问学生是否会做了......
            //直到学生会为止,才可以放学.
            //直到学生会或老师给他讲了10遍还不会,都要放学


            //放学的两个条件：
            //1、会了
            //2、讲完第十遍 不管你会不会 我都放学

            //循环体：老师不停的提问，学生不停的回答，老师还要不停得奖
            //循环条件：学生不会、讲的次数小于10遍
            //string answer = "";
            //int i = 0;
            //while (answer !="yes" && i < 10)
            //{
            //    Console.WriteLine("这是我第{0}遍给你讲，你会了么？yes/no",i+1);
            //    answer = Console.ReadLine();//yes no
            //    //如果学生回答的是 会了 此时应该跳出循环
            //    if (answer == "yes")
            //    {
            //        Console.WriteLine("会了那就放学！！！");
            //        break;
            //    }
            //    i++;
            //}


            //2006年培养学员80000人，每年增长25%，
            //请问按此增长速度，到哪一年培训学员人数将达到20万人？

            //循环体:人数每年增长25%
            //循环条件:人数>=20万

            //double people = 80000;
            //int year = 2006;
            //while (people < 200000)
            //{
            //    people *= 1.25;
            //    year++;
            //}

            //Console.WriteLine("到第{0}年的时候人数将达到20万人",year);

            //Console.ReadKey();



            //提示用户输入yes或者no
            //要求：只能输入yes或者no，只要不是yes或者no就要求用户一直重新输入

            //循环体:提示用户输入 我们接收并且判断
            //循环条件：输入的不能是yes或者no

            //string input = "";//yes
            //while (input != "yes"&& input != "no")
            //{
            //    Console.WriteLine("请输入yes或者no");
            //    input = Console.ReadLine();
            //}



            //提示用户输入用户名和密码 要求用户名等于admin密码等于888888
            //只要用户名错误或者密码错误就重新输入
            //但是，最多只能输入3次

            //循环体：提示用户输入用户名和密码  接收  判断
            //循环条件：用户名或者密码错误  最多错误3次

            //int i = 1;
            //string userName = "";
            //string userPwd = "";
            //while ((userName != "admin" || userPwd != "888888") && i <= 3)
            //{
            //    Console.WriteLine("请输入用户名");
            //    userName = Console.ReadLine();
            //    Console.WriteLine("请输入密码");
            //    userPwd = Console.ReadLine();
            //    i++;
            //}
            //Console.ReadKey();


            //写两个循环
            //第一个循环提示用户A输入用户名 要求A的用户名不能为空，只要为空，就要求A一直重新输入

            //循环体：提示A输入用户名 接收  判断
            //循环条件:用户名为空

            string userNameA = "";
            while (userNameA == "")
            {
                Console.WriteLine("请输入用户名，不能为空");
                userNameA = Console.ReadLine();
            }
            //  Console.ReadKey();



            //第二个循环提示用户B输入用户名，要求B的用户名不能跟A的用户名相同 并且不能为空
            //只要为空，并且跟A的用户名相同，就一直提示用户B重新输入用户名


            //循环体：提示输入B的用户名 接收判断
            //循环条件：用户名为空 或者跟A的相同

            Console.WriteLine("请输入用户名，不能跟A相同，并且不能为空");
            string userNameB = Console.ReadLine();
            while (userNameB == "" || userNameB == userNameA)
            {
                if (userNameB == "")
                {
                    Console.WriteLine("用户名不能为空，请重新输入");
                    userNameB = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("用户名B不能跟A的用户名相同，请重新输入");
                    userNameB = Console.ReadLine();
                }
            }

            Console.ReadKey();





        }
    }
}
