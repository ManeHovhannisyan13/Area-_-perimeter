using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Square
namespace Area___perimeter
{
    public class Square : Shape 
    { 
        public Square(double squareSide)
        {
            Sides = 4;
            SquareSide = squareSide;
        }

        public double SquareSide { get; set; }


        public override double GetSurface()
        {
            return SquareSide * SquareSide;
        }

        public override double GetPerimeter()
        {
            return SquareSide * 4;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Triangle: Sides = {Sides}, SquareSide = {SquareSide}");
            Console.WriteLine($"Surface Area: {GetSurface()}, Perimeter: {GetPerimeter()}");
        }
    }
}
