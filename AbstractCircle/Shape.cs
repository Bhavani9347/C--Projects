using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractcircle
{
        abstract class Shape//abstarct class
        {
            public abstract double CalculatingArea();//abstract method for calculating the total area
            public abstract double CalculatingPerimeter();//abstract method for calculating the total perimeter
    }

        class Circle : Shape//inherit
        {
            public double Radius { get; }

            public Circle(double radius)//parameterized constructor
            {
                Radius = radius;
            }

            public override double CalculatingArea()
            {
                return Math.PI * Radius * Radius;
            }

            public override double CalculatingPerimeter()
            {
                return 2 * Math.PI * Radius;
            }
        }

        class Rectangle : Shape//inherit
        {
            public double Height { get; }
            public double Width { get; }

            public Rectangle(double width, double height)//parameterixed constructor
            {
                Width = width;
                Height = height;
            }
            public override double CalculatingArea()//method1 for are of rectangle
            {
                return Height * Width;
            }

            public override double CalculatingPerimeter()//method 2 for calculating the perimeter of rectangle
            {
                return 2 * (Height + Width);
            }
        }

        class Triangle : Shape
        {
            public double A { get; }
            public double B { get; }
            public double C { get; }

            public Triangle(double a, double b, double c)
            {
                A = a;
                B = b;
                C = c;
            }
        public override double CalculatingArea()//method1 for area of triangle
        {
            return 0.5 * A + 0.5 * B;//assuming a as length and b as breadth
        }
        public override double CalculatingPerimeter()//method2 for perimeter of traingle
        {
            return (A + B + C) / 2;
        }
    }
}
