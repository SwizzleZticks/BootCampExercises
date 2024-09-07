using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise49
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
        public static void GetArea(List<Square> sqList)
        {
            double total = 0;
            foreach (Square square in sqList)
            {
                double squareArea = square._sideLength * square._sideLength;
                total += squareArea;
            }

            Console.WriteLine($"Average Area: {total / sqList.Count}");
        }
        public static void GetPerimeter(List<Square> sqList)
        {
            double total = 0;

            foreach (Square square in sqList)
            {
                double squarePerim = square._sideLength * 4;
                total += squarePerim;
            }

            Console.WriteLine($"Average Perimeter: {total / sqList.Count}");
        }
        public override string ToString()
        {
            return _sideLength.ToString();
        }
    }
}
