using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise50
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isActiveLoop = true;
            List<Triangle> triangles = new List<Triangle>();
            do
            {
                Console.Write("Enter triangle sides separated by spaces (q to quit): ");
                string[] sides = Console.ReadLine().Split(' ');

                if (sides[0] == "q")
                {
                    Console.WriteLine($"Average Area: {Triangle.CalculateArea(triangles)}");
                    Console.WriteLine($"Average Perimeter: {Triangle.CalculatePerimeter(triangles)}");
                    isActiveLoop = GetUserChoice("Would you like to continue (y/n)? ");
                }
                else if (sides.Length == 3)
                {
                    int side1 = int.Parse(sides[0]);
                    int side2 = int.Parse(sides[1]);
                    int side3 = int.Parse(sides[2]);

                    triangles.Add(new Triangle(side1, side2, side3));
                }

            }while (isActiveLoop);
        }
        static bool GetUserChoice(string message)
        {
            string userInput = "";
            bool isActiveLoop = false;

            do
            {
                Console.Write($"{message}");
                userInput = Console.ReadLine().ToUpper();

                if (userInput == "Y")
                {
                    isActiveLoop = true;
                }
                if (userInput == "N")
                {
                    isActiveLoop = false;
                }

            } while (userInput != "Y" && userInput != "N");

            return isActiveLoop;
        }
    }
}
