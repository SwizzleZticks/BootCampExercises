using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise52
{
    public class Square
    {
        private int _sideLength;

        public int SideLength 
        {
            get { return _sideLength; }
            set { _sideLength = value; }       
        }
   
        public Square(int sideLength)
        {
            _sideLength = sideLength;
        }
        public static double GetArea(List<Square> sqList)
        {
            double total = 0;
            foreach (Square square in sqList)
            {
                double squareArea = square._sideLength * square._sideLength;
                total += squareArea;
            }

            return total;
        }
        public static double GetPerimeter(List<Square> sqList)
        {
            double total = 0;

            foreach (Square square in sqList)
            {
                double squarePerim = square._sideLength * 4;
                total += squarePerim;
            }

            return total;
        }
        public override string ToString()
        {
            return _sideLength.ToString();
        }
    }
}
