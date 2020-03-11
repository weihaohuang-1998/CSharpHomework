using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var area = Enumerable.Range(0, 10)
                .Select(_ => ShapeFactory.CreateShape())
                .Sum(i =>
                {
                    Console.WriteLine(i.ToString());
                    return i.Area;
                });
            Console.WriteLine($"Total area of the 10 shapes are {area}.");
            Console.ReadLine();
        }
    }

    interface Shape
    {
       double Area {get; }
    }

    class Rectangle : Shape
    {
        protected double Width, Height;
        public double Area => Width * Height;

        public Rectangle(double w,double h)
        {
            if(w>0&&h>0)
            {
                Width = w;
                Height = h;
            }
            else
            {
                throw new ArgumentException("Invalid shape");
            }
        }
        public override string ToString()
        {
            return $"Rectangle(w={Width},h={Height},S={Area})";
        }
    }

    class Square:Rectangle
    {
        public Square(double a) : base(a, a) { }
        public override string ToString()
        {
            return $"Square(a={Width},S={Area})";
        }
    }

    class Triangle : Shape
    {
        protected readonly double Width, Height;
        public double Area => Width * Height/2;

        //输入三角形的底和高时的构造函数
        public Triangle(double w,double h)
        {
            if(w>0&&h>0)
            {
                Width = w;
                Height = h;
            }
            else
            {
                throw new ArgumentException("Invalid shape.");
            }
        }

        //输入三角形三边时的构造函数
        public Triangle(double a,double b,double c)
        {
            if(a>0&&b>0&&c>0&&a+b>c&&a+c>b&&b+c>a)
            {
                Width = a;
                Height = Math.Sqrt(b * b - Math.Pow(a * a + b * b - c * c, 2) / (4 * a * a));
            }
            else
            {
                throw new ArgumentException("invalid shape.");
            }
        }
        public override string ToString()
        {
            return $"Triangle(w={Width},S={Area})";
        }
    }

    class ShapeFactory
    {
        private static readonly Random Rd = new Random();
       public static Shape CreateShape(String type)
       {
            switch (type.ToLower())
            {
                case "rectangle":
                    return new Rectangle(10 * Rd.NextDouble(), 10 * Rd.NextDouble());
                case "square":
                    return new Square(10 * Rd.NextDouble());
                case "triangle":
                    return new Triangle(10 * Rd.NextDouble(), 10 * Rd.NextDouble());
                default:
                    throw new ArgumentException("Unknown shape");
            }
       }
      public static Shape CreateShape()
      {
            var shapes = new List<String> { "rectangle", "square", "triangle" };
            return CreateShape(shapes[Rd.Next(0, 3)]);
      }     
    }

    
}

