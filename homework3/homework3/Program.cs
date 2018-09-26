using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework3
{ 
    //创建图形父类
    public abstract class Shape
    {
        private string Name;
        public Shape(string p)
        {
            Id = p;
        }
        public string Id
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }
        public abstract double Area();
        public void Put()
        {
            Console.WriteLine(Name+"的面积是:"+Area());
        }
    }
    //创建正方形模型
    public class Square:Shape
    {
        private double Size;
        public Square(double p,string name):base(name)
        {
            Size = p;
        }
        public override double Area()
        {
            return Size * Size;
        }

    }
    //创建圆形模型
    public class Circle : Shape
    {
        private double Radius;
        public Circle(double p,string name):base(name)
        {
            Radius = p;
        }
        public override double Area()
        {
            return 3.14 * Radius * Radius;
        }
    }
    //创建矩形模型
    public class Rectangle : Shape
    {
        private double Length;
        private double Width;
        public Rectangle(double x,double y,string name):base(name)
        {
            Length = x;
            Width = y;
        }
        public override double Area()
        {
            return Length * Width;
        }
    }
    //创建三角形模型
    public class Triangle : Shape
    {
        private double Size1;
        private double Size2;
        private double Size3;
        public Triangle(double x,double y,double z,string name):base(name)
        {
            if (x+y<=z||x+z<=y||y+z<=x)
            {
                Console.WriteLine("fause");
                Size1 = Size2 = Size3 = 0;
            }
            Size1 = x;
            Size2 = y;
            Size3 = z;
        }
        public override double Area()
        {
            double p = (Size1 + Size2 + Size3) / 2;
            return Math.Sqrt(p * (p - Size1) * (p - Size2) * (p - Size3));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = { new Square(6.1, "Square"), new Circle(3.0, "Circle"), new Rectangle(2.5, 4, "Rectangle"), new Triangle(3, 4, 5, "Triangle") };
            foreach(Shape s in shapes)
            {
                s.Put();
            }
        }
    }
}
