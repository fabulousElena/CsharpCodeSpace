using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01复习
{
    class Program
    {
        static void Main(string[] args)
        {

            //作业：定义父亲类Father(姓lastName,财产property,血型bloodType),儿子Son类(玩游戏PlayGame方法),女儿Daughter类(跳舞Dance方法)，调用父类构造函数(:base())给子类字段赋值


            //作业：定义汽车类Vehicle属性（brand(品牌),color（颜色））方法run，子类卡车(Truck) 属性weight载重  方法拉货，轿车 (Car) 属性passenger载客数量  方法载客

            //Truck t = new Truck("解放牌卡车", VehicalColor.Red, 10000000);
            //t.LaHuo();

            //Car c = new Car("红旗轿车", VehicalColor.Black, 5);
            //c.LaRen();


            //作业：计算形状Shape(圆Circle，矩形Square ，正方形Rectangle)的面积、周长

            //Shape shape = new Square(5, 8);//new Circle(5);
            //double area = shape.GetArea();
            //double perimeter = shape.Getperimeter();
            //Console.WriteLine("这个形状的面积是{0:0.00},周长是{1:0.00}",area,perimeter);

            //Console.ReadKey();

            //业:橡皮rubber鸭子、木wood鸭子、真实的鸭子realduck。三个鸭子都会游泳，而橡皮鸭子和真实的鸭子都会叫，只是叫声不一样，橡皮鸭子“唧唧”叫，真实地鸭子“嘎嘎”叫，木鸭子不会叫.

            IBark bark = new XPDuck();//new RealDuck();//new MuDuck();
            bark.Bark();
            Console.ReadKey();
        }
    }

    public class Duck
    {
        public void Swim()
        {
            Console.WriteLine("鸭子们都会游泳，旱鸭子不会~~~~");
        }
    }

    interface IBark
    {
        void Bark();
    }

    class XPDuck : Duck, IBark
    {
        public void Bark()
        {
            Console.WriteLine("橡皮鸭子唧唧叫");
        }
    }

    class RealDuck : Duck, IBark
    {
        public void Bark()
        {
            Console.WriteLine("真是的鸭子嘎嘎叫");
        }
    }

    class MuDuck : Duck
    {

    }




    abstract class Shape
    {
        public abstract double GetArea();
        public abstract double Getperimeter();
    }

    class Circle : Shape
    {
        public double R { get; set; }
        public Circle(double r)
        {
            this.R = r;
        }
        public override double GetArea()
        {
            return Math.PI * this.R * this.R;
        }

        public override double Getperimeter()
        {
            return 2 * Math.PI * this.R;
        }
    }


    class Square : Shape
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public Square(double height, double width)
        {
            this.Height = height;
            this.Width = width;
        }

        public override double GetArea()
        {
            return this.Height * this.Width;
        }

        public override double Getperimeter()
        {
            return (this.Height + this.Width) * 2;
        }
    }


    enum VehicalColor
    {
        Black,
        Red,
        White,
        Blue,
        Yellow
    }

    class Vehicle
    {
        public string Brand { get; set; }
        public VehicalColor Color
        {
            get;
            set;
        }

        public void Run()
        {
            Console.WriteLine("是车都会跑");
        }

        public Vehicle(string brand, VehicalColor color)
        {
            this.Brand = brand;
            this.Color = color;
        }

    }

    class Truck : Vehicle
    {
        public double Weight
        {
            get;
            set;
        }

        public Truck(string brand, VehicalColor color, double weight)
            : base(brand, color)
        {
            this.Weight = weight;
        }

        public void LaHuo()
        {
            Console.WriteLine("卡车可以最多拉{0}KG的货物", this.Weight);
        }
    }

    class Car : Vehicle
    {
        public int Passenger
        {
            get;
            set;
        }

        public Car(string brand, VehicalColor color, int passenger)
            : base(brand, color)
        {
            this.Passenger = passenger;
        }

        public void LaRen()
        {
            Console.WriteLine("轿车最多可以拉{0}个人", this.Passenger);
        }
    }















    class Father
    {
        public string LastName { get; set; }
        public double Property { get; set; }

        public string BloodType { get; set; }

        public Father(string lastName, double property, string bloodType)
        {
            this.LastName = lastName;
            this.Property = property;
            this.BloodType = bloodType;
        }

    }

    class Son : Father
    {
        public Son(string lastName, double property, string bloodType)
            : base(lastName, property, bloodType)
        { }

        public void PlayGame()
        {
            Console.WriteLine("儿子可以玩游戏");
        }
    }

    class Daughter : Father
    {
        public Daughter(string lastName, double property, string bloodType)
            : base(lastName, property, bloodType)
        { }

        public void Dance()
        {
            Console.WriteLine("女儿会跳舞");
        }
    }

}
