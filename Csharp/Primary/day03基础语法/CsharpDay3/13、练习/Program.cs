using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //比较3个数字的大小 不考虑相等

            //分别的提示用户输入三个数字 我们接受并且转换成int类型
            //Console.WriteLine("请输入第一个数字");
            //int numberOne = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入第二个数字");
            //int numberTwo = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入第三个数字");
            //int numberThree = Convert.ToInt32(Console.ReadLine());


            //三种情况 应该使用 if else-if来做
            //如果第一个数字大于第二个数字 并且第一个数字还大于第三个数字 
            //if (numberOne > numberTwo && numberOne > numberThree)
            //{
            //    Console.WriteLine(numberOne);
            //}
            ////如果第二个数字大于第一个数字并且第二个数字大于第三个数字
            //else if (numberTwo > numberOne && numberTwo > numberThree)
            //{
            //    Console.WriteLine(numberTwo);
            //}
            ////如果第三个数字大于第一个数字并且第三个数字大于第二个数字
            //else
            //{
            //    Console.WriteLine(numberThree);
            //}


            //我先让第一个数字跟第二个数字比较 如果大于第二个数字 再让第一个数字跟第三个数字比较
            //if (numberOne > numberTwo)
            //{
            //    //如果第一个数字大于了第二个数字 再让第一个数字跟第三个数字比较
            //    if (numberOne > numberThree)
            //    {
            //        Console.WriteLine(numberOne);
            //    }
            //    else//第三个数字要大于第一个数字
            //    {
            //        Console.WriteLine(numberThree);
            //    }
            //}
            //else//第二个数字大于了第一个数字
            //{ 
            //    //让第二个数字跟第三个数字进行比较 如果第二个数字大于第三个数字  第二个数字最大 否则第三个数字最大
            //    if (numberTwo > numberThree)
            //    {
            //        Console.WriteLine(numberTwo);
            //    }
            //    else//第三个数字最大
            //    {
            //        Console.WriteLine(numberThree);
            //    }
            //}



            //练习1：提示用户输入密码，如果密码是“88888”则提示正确，否则要求再输入一次，            //如果密码是“88888”则提示正确，否则提示错误,程序结束。            //(如果我的密码里有英文还要转换吗,密码:abc1)

            //Console.WriteLine("请输入密码");
            //string pwd = Console.ReadLine();
            //if (pwd == "888888")
            //{
            //    Console.WriteLine("登陆成功");
            //}
            //else//要求用户再输入一次
            //{
            //    Console.WriteLine("密码错误，请重新输入");
            //    pwd = Console.ReadLine();
            //    if (pwd == "888888")
            //    {
            //        Console.WriteLine("输了两遍，终于正确了");
            //    }
            //    else//输入第二次错误
            //    {
            //        Console.WriteLine("两边都不对，程序结束");
            //    }
            //}

            //Console.ReadKey();




            //练习2：提示用户输入用户名，然后再提示输入密码，如果用户名是“admin”并且密码是“88888”，
            //则提示正确，否则，如果用户名不是admin还提示用户用户名不存在,
            //如果用户名是admin则提示密码错误.
            //Console.WriteLine("请输入用户名");
            //string name = Console.ReadLine();
            //Console.WriteLine("请输入密码");
            //string pwd = Console.ReadLine();


            ////第一种情况：用户名和密码全部输入正确
            //if (name == "admin" && pwd == "888888")
            //{
            //    Console.WriteLine("登陆成功");
            //}
            ////第二种情况：密码错误
            //else if (name == "admin")
            //{
            //    Console.WriteLine("密码输入错误，程序退出");
            //}
            ////第三种情况：用户名错误
            //else if (pwd == "888888")
            //{
            //    Console.WriteLine("用户名错误，程序退出");
            //}
            ////第四种情况：用户名和密码全部错误
            //else
            //{
            //    Console.WriteLine("用户名和密码全部错误，程序退出");
            //}



            //练习3：提示用户输入年龄，如果大于等于18，则告知用户可以查看，如果小于10岁，
            //则告知不允许查看，如果大于等于10岁并且小于18，
            //则提示用户是否继续查看（yes、no），如果输入的是yes则提示用户请查看，
            //否则提示"退出,你放弃查看"。

            //第一种情况  >=18   
            //第二种情况  <10
            //第三种情况  >=10  && <18

            Console.WriteLine("请输入你的年龄");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("看吧，早晚你都要知道的");
            }
            else if (age < 10)
            {
                Console.WriteLine("滚蛋，回家吃奶去");
            }
            else
            {
                Console.WriteLine("确定要看么？yes/no");
                //input 要么是yes要么是no
                string input = Console.ReadLine();
                if (input == "yes")
                {
                    Console.WriteLine("看吧，早熟的孩子，后果自负哟");
                }
                else//no
                {
                    Console.WriteLine("乖孩子，回家吃奶去吧");
                }
            }

            Console.ReadKey();

        }
    }
}
