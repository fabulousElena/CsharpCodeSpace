using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06面向对象练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //作业：定义父亲类Father(姓lastName,财产property,血型bloodType),
            //儿子Son类(玩游戏PlayGame方法),女儿Daughter类(跳舞Dance方法)，
            //调用父类构造函数(:base())给子类字段赋值

            //Son son = new Son("张三",10m,"AB");
            //son.PlayGame();
            //son.SayHello();
            //Daughter d = new Daughter("张梅梅", 100m, "O");
            //d.SayHello();
            //d.Dance();
            //Console.ReadKey();

            //作业：定义汽车类Vehicle属性（brand(品牌),color（颜色））方法run，
            //子类卡车(Truck) 属性weight载重  方法拉货，轿车 (Car) 属性passenger载客数量  方法载客

            //Truck truck = new Truck("解放牌卡车", "绿色", 30000);
            //Car car = new Car("奔驰", "黑色", 5);
            //truck.LaHuo();
            //car.LaKe();
            //Console.ReadKey();

        }
    }

    /// <summary>
    /// 汽车的父类
    /// </summary>
    public class Vehicle
    {
        public string Brand
        {
            get;
            set;
        }

        public string Color
        {
            get;
            set;
        }

        public void Run()
        {
            Console.WriteLine("我是汽车我会跑");
        }

        public Vehicle(string brand, string color)
        {
            this.Brand = brand;
            this.Color = color;
        }
    }


    public class Truck : Vehicle
    {
        public double Weight
        {
            get;
            set;
        }
        public Truck(string brand, string color, double weight)
            : base(brand, color)
        {
            this.Weight = weight;
        }


        public void LaHuo()
        {
            Console.WriteLine("我最多可以拉{0}KG货物",this.Weight);
        }
    }


    public class Car : Vehicle
    {
        public int Passenger
        {
            get;
            set;
        }
        public Car(string brand, string color, int passenger)
            : base(brand, color)
        {
            this.Passenger = passenger;
        }


        public void LaKe()
        {
            Console.WriteLine("我最多可以拉{0}个人",this.Passenger);
        }
    }


    public class Father
    {
        private string _lastName;
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        private decimal _property;
        public decimal Property
        {
            get { return _property; }
            set { _property = value; }
        }

        private string _bloodType;
        public string BloodType
        {
            get { return _bloodType; }
            set { _bloodType = value; }
        }

        public Father(string lastName, decimal property, string bloodType)
        {
            this.LastName = lastName;
            this.Property = property;
            this.BloodType = bloodType;
        }

        public void SayHello()
        {
            Console.WriteLine("我叫{0},我有{1}元，我是{2}型血",this.LastName,this.Property,this.BloodType);
        }

    }

    public class Son : Father
    {
        public Son(string lastName, decimal property, string bloodType)
            : base(lastName, property, bloodType)
        { 
            
        }

        public void PlayGame()
        {
            Console.WriteLine("儿子会玩游戏");
        }
    }

    public class Daughter : Father
    {
        public Daughter(string lastName, decimal property, string bloodType)
            : base(lastName, property, bloodType)
        { 
            
        }

        public void Dance()
        {
            Console.WriteLine("女儿会跳舞");
        }
    }
}
