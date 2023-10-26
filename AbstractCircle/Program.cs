using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractcircle
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = new Shape[]//array
            {
                new Circle(6.0),
                new Rectangle(2.0, 2.0),
                new Triangle(2.0, 3.0, 4.0)
            };
            double TotalArea = 0.0;
            double TotalPerimeter = 0.0;

            foreach (var shape in shapes)
            {
                TotalArea += shape.CalculatingArea();
                TotalPerimeter += shape.CalculatingPerimeter();
            }

            Console.WriteLine($"The total area of shapes is = {TotalArea}");
            Console.WriteLine($"The total perimeter of shapes is = {TotalPerimeter}");

        }
    }
}