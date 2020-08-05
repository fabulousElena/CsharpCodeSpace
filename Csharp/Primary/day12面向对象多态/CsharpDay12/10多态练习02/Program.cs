using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10多态练习02
{
    class Program
    {
        static void Main(string[] args)
        {
            //真的鸭子嘎嘎叫 木头鸭子吱吱叫 橡皮鸭子唧唧叫
            Duck duck = new Duck();
            duck.Name = "鸭子";
           

            WoodDuck wd = new WoodDuck();
            wd.Name = "木鸭子";
            

            XiangPiDuck xpd = new XiangPiDuck();
            xpd.Name = "橡皮鸭子";

            Duck[] newDuck = { duck, wd, xpd };
            for (int i = 0; i < newDuck.Length; i++)
            {
                newDuck[i].Talk();
            }

            Console.ReadKey();
        }
    }

    class Duck
    {
        private string _name;
        public string Name { get => _name; set => _name = value; }
        public virtual void Talk()
        {
            Console.WriteLine("我是{0},我在嘎嘎叫！",Name);
        }
    }

    class WoodDuck : Duck
    {

        private string _name;

        public string Name { get => _name; set => _name = value; }

        public override void Talk()
        {
            Console.WriteLine("我是{0},我在吱吱叫！",Name);
        }
    }

    class XiangPiDuck : Duck
    {
        private string _name;

        public string Name { get => _name; set => _name = value; }

        public override void Talk()
        {
            Console.WriteLine("我是{0},我在唧唧叫！",Name);
        }
    }
}
