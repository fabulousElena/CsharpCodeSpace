using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16超市收银系统newDemo
{
    //商品的父类
    class GoodsFather
    {
        private string _brand;
        private string _type;
        private double _price;
        private int _count;

        private string _id;
        //有参构造方法
        public GoodsFather(string brand, string type, double price, int count,string id)
        {
            this.Brand = brand;
            this.Type = type;
            this.Price = price;
            this.Count = count;
            this.Id = id;
            
        }
        //空参构造方法
        public GoodsFather() { }

        public string Brand { get => _brand; set => _brand = value; }
        public string Type { get => _type; set => _type = value; }
        public double Price { get => _price; set => _price = value; }
        public int Count { get => _count; set => _count = value; }
        public string Id { get => _id; set => _id = value; }
    }
}
