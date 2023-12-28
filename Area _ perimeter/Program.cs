using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area___perimeter
{

    class Program
    {
        static void Main()
        {
            for (; ; )
            {
                Console.WriteLine("Enter the name of the image whose area and perimeter are to be calculated");
                Console.WriteLine("triangle , rectangle or square?");
                string n = Console.ReadLine();
                if (n == "triangle" || n == "Triangle" || n == "TRIANGLE")
                {
                    Console.WriteLine("Enter the sides of the triangle:");

                    Console.Write("Side 1: ");
                    double side1 = double.Parse(Console.ReadLine());

                    Console.Write("Side 2: ");
                    double side2 = double.Parse(Console.ReadLine());

                    Console.Write("Side 3: ");
                    double side3 = double.Parse(Console.ReadLine());

                    Triangle triangle = new Triangle(side1, side2, side3);
                    triangle.DisplayInfo();
                }
                else if (n == "rectangle" || n == "Rectangle" || n == "RECTANGLE")
                {
                    Console.WriteLine("Enter the sides of the rectangle:");

                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine());

                    Console.Write("Length: ");
                    double length = double.Parse(Console.ReadLine());

                    Rectangle rectangle = new Rectangle(width, length);
                    rectangle.DisplayInfo();
                }
                else if (n == "square" || n == "Square" || n == "SQUARE")
                {
                    Console.WriteLine("Enter the side of the square:");

                    Console.WriteLine("Square Sides : ");
                    double squareSides = double.Parse(Console.ReadLine());

                    Square square = new Square(squareSides);
                    square.DisplayInfo();
                }
                else { Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!"); }
            }
        }
    }
}
