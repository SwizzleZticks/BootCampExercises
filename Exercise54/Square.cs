using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Exercise54
{
    public class Square : Shape
    {
        private double _length;
        private double _width;
        public double Length 
        {
            get { return _length; }
            set {  _length = value; }
        }
        public double Width 
        {
            get { return _width; }
            set {  _width = value; }
        }

        public Square(double length, double width) : base("Square")
        {
            Length = length;
            Width = width;
        }
        public override double Area()
        {
            return _length * 4;
        }

        public override double Perimeter()
        {
            return _width * 4;
        }
    }
}
