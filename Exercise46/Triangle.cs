using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise46
{
    public class Triangle
    {
        public double Side1Length;
        public double Side2Length;
        public double Side3Length;

        public Triangle(double side1Length, double side2Length, double side3Length)
        {
            Side1Length = side1Length;
            Side2Length = side2Length;
            Side3Length = side3Length;
        }

        public double CalculateArea()
        {
            return .5 * Side1Length * Side2Length;
        }
        public double CalculatePerimeter() 
        {
            return Side1Length + Side2Length + Side3Length;
        }
    }
}
