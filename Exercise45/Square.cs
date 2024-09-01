using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise45
{
    public class Square
    {
        public int SideLength;

        public Square(int sideLength) 
        { 
            SideLength = sideLength;
        }
        public int CalculatePerimeter()
        {
            return SideLength + SideLength + SideLength + SideLength;
        }
        public int CalculateArea()
        {
            return SideLength * SideLength;
        }
    }
}
