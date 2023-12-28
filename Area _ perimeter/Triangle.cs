using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Triangle
namespace Area___perimeter
{
    public class Triangle : Shape
    {
        public Triangle(double side1, double side2, double side3)
        {
            Sides = 3;
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }

        public double Side1 { get;  set; }

        public double Side2 { get;  set; }

        public double Side3 { get;  set; }

        public override double GetSurface()
        {
            double s = (Side1 + Side2 + Side3) / 2;
            return (s * (s - Side1) * (s - Side2) * (s - Side3));
        }

        public override double GetPerimeter()
        {
            return Side1 + Side2 + Side3;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Triangle: Sides = {Sides}, Side1 = {Side1}, Side2 = {Side2}, Side3 = {Side3}");
            Console.WriteLine($"Surface Area: {GetSurface()}, Perimeter: {GetPerimeter()}");
        }
    }
}
