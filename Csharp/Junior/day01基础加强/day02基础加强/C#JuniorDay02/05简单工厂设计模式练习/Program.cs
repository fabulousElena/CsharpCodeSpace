using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05简单工厂设计模式练习
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入你想要的笔记本品牌");
            string brand = Console.ReadLine();
            //整个简单工厂的核心   工厂
            //根据用户的输入 返回相应的笔记本 父类
            NoteBook nb = GetNoteBook(brand);
            if (nb != null)
            {
                nb.SayHello();
            }
            else
            {
                Console.WriteLine("没有你想要的电脑品牌！！！！");
            }
            Console.ReadKey();
        }

        static NoteBook GetNoteBook(string brand)
        {
            NoteBook nb = null;
            switch (brand)
            { 
                case "IBM":
                    nb = new IBM();
                    break;
                case "Acer":
                    nb = new Acer();
                    break;
                case "Lenovo":
                    nb = new Lenovo();
                    break;
                case "Dell":
                    nb = new Dell();
                    break;
            }
            return nb;
        }
    }
    abstract class NoteBook
    {
        public abstract void SayHello();
    }

    class IBM : NoteBook
    {
        public override void SayHello()
        {
            Console.WriteLine("我是IBM笔记本");
        }
    }

    class Lenovo : NoteBook
    {
        public override void SayHello()
        {
            Console.WriteLine("我是联想笔记本");
        }
    }

    class Dell : NoteBook
    {
        public override void SayHello()
        {
            Console.WriteLine("我是戴尔笔记本");
        }
    }

    class Acer : NoteBook
    {
        public override void SayHello()
        {
            Console.WriteLine("我是鸿基笔记本");
        }
    }

}
