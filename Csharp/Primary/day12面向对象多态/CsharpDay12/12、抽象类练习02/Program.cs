using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_抽象类练习02
{
    class Program
    {
        static void Main(string[] args)
        {
            //使用多态求矩形的面积和周长以及圆形的面积和周长
            Shape rc = new Rectangle(4,5);
            rc.GetArea();
            Console.ReadKey();

            
        }
    }

    public abstract class Shape
    {

        public Shape()
        {

        }

        public abstract void GetArea();
        public abstract void GetPerimeter();

    }

    class Rectangle : Shape
    {
        public Rectangle() {

        }
        private double _width;
        private double _height;
        private double _longth;
        /// <summary>
        /// 计算面积的重载
        /// </summary>
        /// <param name="w"> 宽 </param>
        /// <param name="h"> 高 </param>
        /// <param name="l"> 长 </param>
        public Rectangle(double w,double h ,double l) {
            this.Height = h;
            this.Width = w;
            this.Longth = l;
        }
        /// <summary>
        /// 计算面积的重载
        /// </summary>
        /// <param name="h">高</param>
        /// <param name="l">底</param>
        public Rectangle(double l, double h)
        {
            this.Height = h;
            
            this.Longth = l;
        }


        public double Width { get => _width; set => _width = value; }
        public double Height { get => _height; set => _height = value; }
        public double Longth { get => _longth; set => _longth = value; }

        public override void GetArea()
        {
            double area = 0.0;

            area = Longth * Height;

            Console.WriteLine("底为{0}，高为{1}的矩形面积是{2}",Longth,Height,area);
        }

        public override void GetPerimeter()
        {
            
            //return Width * 2 + Longth * 2;
        }
    }


}
