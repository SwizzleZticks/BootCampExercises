using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise50
{
    public class Triangle
    {
        private int sideLength1;
        private int sideLength2;
        private int sideLength3;

        public int SideLength1 { get; set; }
        public int SideLength2 { get; set; }
        public int SideLength3 { get; set; }
        public Triangle(int side1, int side2, int side3)
        {
            sideLength1 = side1;
            sideLength2 = side2;
            sideLength3 = side3;
        }

        public static double CalculateArea(List<Triangle> triList)
        {
            double areaTotal = 0;

            foreach (Triangle t in triList)
            {
                double area = .5 *  t.sideLength1 * t.sideLength2;
                areaTotal += area;
            }

            return areaTotal/triList.Count;
        }

        public static double CalculatePerimeter(List<Triangle> triList)
        {
            double perimeterTotal = 0;
            foreach (Triangle t in triList) 
            {
                double triPerim = t.sideLength1 + t.sideLength2 + t.sideLength3;
                perimeterTotal += triPerim;
            }

            return perimeterTotal/triList.Count;
        }
    }
}
