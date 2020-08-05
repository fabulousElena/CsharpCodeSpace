using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16超市收银系统newDemo
{
    class Ipad : GoodsFather
    {
        public Ipad(string brand, string type, double price, int count, string id) : base(brand, type, price, count, id) { }
    }
}
