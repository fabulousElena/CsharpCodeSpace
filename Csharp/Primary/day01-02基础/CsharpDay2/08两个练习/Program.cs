using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08两个练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //有个叫卡卡西的人在旅店登记的时候前台让他填一张表,
            //这张表的里的内容要存到电脑上,
            //有姓名、年龄、邮箱、家庭住址,工资.
            //之后把这些信息显示出来
            //string name = "卡卡西";
            //int age = 30;
            //string email = "kakaxi@qq.com";
            //string address = "火影村";
            //decimal salary = 5000m;

            //Console.WriteLine("我叫{0}，我今年{1}岁了，我住在{2},我的邮箱是{3}，我的工资是{4}", name, age, address, email, salary);


            //Console.WriteLine("我叫" + name + ",我住在" + address + ",我今年" + age + "岁了" + ",我的邮箱是" + email + ",我的工资是" + salary);
            //Console.ReadKey();


            //int age = 18;
            //age = 81;
            //Console.WriteLine("原来你都" + age + "岁了呀");
            //Console.ReadKey();


            //3.定义四个变量,分别存储一个人的姓名、性别(Gender)、年龄、电话
            //(TelephoneNumber)。然后打印在屏幕上 (我叫X,我今年 X岁了,我是X生,
            //我的电话是XX)(电话号用什么类型,如:010-12345)
            string name = "张三";
            char gender = '男';
            int age = 18;
            string tel = "12345678900";
            Console.WriteLine("我叫{0},我今年{1}岁了，我是{2}生，我的电话是{3}", name, age, gender, tel);
            Console.ReadKey();


        }
    }
}
