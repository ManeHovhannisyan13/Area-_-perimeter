using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area___perimeter
{
    public abstract class Shape
    {
        public abstract double GetSurface();

        public abstract double GetPerimeter();

        public abstract void DisplayInfo();

        public int Sides { get;  set; }

        public double Width { get;  set; }

        public double Length { get; set; }

        public double SquareSides { get; set; }
    }
}
