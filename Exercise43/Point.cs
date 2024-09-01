using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise43
{
    public class Point
    {
        public double X;
        public double Y;

        public Point(double x, double y) 
        {
            X = x;
            Y = y;
        }

        public double CalculateDistance()
        {
            return Math.Sqrt(X * X + Y * Y);
        }

        public static Point CalculateMidPoint(Point first, Point second)
        {
            double xMid = (first.X + second.X) / 2;
            double yMid = (first.Y + second.Y) / 2;

            return new Point(xMid, yMid);
        }
    }
}
