using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area___perimeter
{
    public class Rectangle : Shape
    {
        public Rectangle(double width, double length)
        {
            Sides = 4;
            Length = length;
            Width = width;  
        }

        public double Width { get; set; }

        public double Length { get; set; }

        public override double GetSurface()
        {
            double s = Width * Length;
            return s;
        }

        public override double GetPerimeter()
        {
            return ((Width + Length) * 2);
            //return Width + Length + Width + Length;
            //return (Width * 2) + (Length * 2); 
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Triangle: Sides = {Sides}, Length = {Length} , Width = {Width} ");
            Console.WriteLine($"Surface Area: {GetSurface()}, Perimeter: {GetPerimeter()}");
        }
    }
}
