using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03简单工厂设计模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入您想要的笔记本品牌");
            string brand = Console.ReadLine();
            NoteBook nb = GetNoteBook(brand);
            nb.SayHello();
            Console.ReadKey();
        }


        /// <summary>
        /// 简单工厂的核心 根据用户的输入创建对象赋值给父类
        /// </summary>
        /// <param name="brand"></param>
        /// <returns></returns>
        public static NoteBook GetNoteBook(string brand)
        {
            NoteBook nb = null;
            switch (brand)
            {
                case "Lenovo": nb = new Lenovo();
                    break;
                case "IBM": nb = new IBM();
                    break;
                case "Acer": nb = new Acer();
                    break;
                case "Dell": nb = new Dell();
                    break;
            }
            return nb;
        }
    }

    public abstract class NoteBook
    {
        public abstract void SayHello();
    }

    public class Lenovo : NoteBook
    {
        public override void SayHello()
        {
            Console.WriteLine("我是联想笔记本，你联想也别想");
        }
    }


    public class Acer : NoteBook
    {
        public override void SayHello()
        {
            Console.WriteLine("我是 宏碁笔记本");
        }
    }

    public class Dell : NoteBook
    {
        public override void SayHello()
        {
            Console.WriteLine("我是戴尔笔记本");
        }
    }

    public class IBM : NoteBook
    {
        public override void SayHello()
        {
            Console.WriteLine("我是IBM笔记本");
        }
    }
}
