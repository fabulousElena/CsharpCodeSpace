using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16超市收银系统02
{
    class ProductFather
    {
        //价格  名称  条形码
        public double Price
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;

        }

        public string ID
        {
            get;
            set;
        }

        public ProductFather(double price, string name , string id) {
            this.Price = price;
            this.Name = name;
            this.ID = id;
        }
    }
}
