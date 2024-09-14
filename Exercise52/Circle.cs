using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise52
{
    public class Circle
    {
        private double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }     
        public static double GetArea(List<Circle> circ)
        {
                double total = 0;
                foreach (Circle circle in circ)
                {
                    total += circle.CalculateArea();
                }

                return total;
        }

        public static double GetPerimeter(List<Circle> circ)
        {
            double total = 0;
            foreach (Circle circle in circ)
            {
                total += circle.CalculatePerimeter();
            }

            return total;
        }

        private double CalculateArea()
        {
            return Math.PI * radius * radius;
        }
        public double GetRadius()
        {
            return radius;
        }

        private double CalculatePerimeter()
        {
            return 2 * Math.PI * radius;
        }
    }
}
