using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise54
{
    public class Triangle : Shape
    {
        private double _base;
        private double _sideOne;
        private double _sideTwo;

        public double Base 
        { 
            get {  return _base; }
            set { _base = value; }
        }
        public double SideOne
        { 
            get { return _sideOne;}
            set { _sideOne = value; }
        }
        public double SideTwo 
        {
            get { return _sideTwo; }
            set { _sideTwo = value; }
        }

        public Triangle(double triBase, double sideOne, double sideTwo) : base("Triangle")
        {
            Base = triBase;
            SideOne = sideOne;
            SideTwo = sideTwo;
        }

        public override double Area()
        {
            return .5 * _base * _sideOne;
        }

        public override double Perimeter()
        {
            return _base + _sideOne + _sideTwo;
        }
    }
}
