using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16超市收银系统newDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperMarket sp = new SuperMarket();
            sp.GetInGoods();
            sp.UiWhenBuy();
            

            //Storage st = new Storage();
            //st.InGoods();
            //st.ShowGoods();
            Console.ReadKey();


        }
    }
}
