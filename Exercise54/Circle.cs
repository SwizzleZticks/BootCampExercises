using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise54
{
    public class Circle : Shape
    {
        private double _radius;
        public double Radius
        {
            get { return _radius;  }
            set { _radius = value; } //need to provide validation that the radius isnt negative
        }
        public Circle(double radius) : base("Circle")
        {
            _radius = radius;
        }
        public override double Area()
        {
            return Math.PI * _radius * _radius;
        }
        public override double Perimeter()
        {
            return 2 * Math.PI * _radius;
        }
        public override bool Equals(object obj)
        {
            if(obj.GetType() != this.GetType())
            {
                return false;
            }
            if (obj == this)
            {
                return true;
            }

            Circle otherCircle = obj as Circle;

            if (otherCircle._radius == this._radius)
            {
                return true;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode() * 17;
        }

        public override string ToString()
        {
            return _radius.ToString();
        }
    }
}
