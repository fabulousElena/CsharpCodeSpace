using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_抽象类练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //作业：计算形状Shape(圆Circle，矩形Square ，正方形Rectangle)的面积、周长
            Shape shape = new Square(5,7);//new Circle(5);
            double area = shape.GetArea();
            double perimeter = shape.GetPerimeter();
            Console.WriteLine(area);
            Console.WriteLine(perimeter);
            Console.ReadKey(); 
        }
    }

    public abstract class Shape
    {
        public abstract double GetArea();
        public abstract double GetPerimeter();
    }

    public class Square : Shape
    {
        public double Height
        { 
            get;
            set;
        }

        public double Width
        {
            get;
            set;
        }

        public Square(double height, double width)
        {
            this.Height = height;
            this.Width = width;
        }

        public override double GetArea()
        {
            return this.Height * this.Width;
        }

        public override double GetPerimeter()
        {
            return (this.Height + this.Width) * 2;
        }
    }


    public class Circle : Shape
    {
        public double R
        {
            get;
            set;
        }
        public Circle(double r)
        {
            this.R = r;
        }

        public override double GetArea()
        {
            return Math.PI * this.R * this.R;
        }

        public override double GetPerimeter()
        {
            return 2 * Math.PI * this.R;
        }
    }
}
