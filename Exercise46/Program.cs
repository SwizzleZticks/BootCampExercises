using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise46
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isActiveLoop = true;
            do
            {
                Console.Write("Enter the side lengths of a triangle: ");
                string[] sides =  Console.ReadLine().Split(' ');

                Triangle tri = new Triangle(double.Parse(sides[0]), double.Parse(sides[1]), double.Parse(sides[2]));

                Console.WriteLine($"The triangle side lengths {tri.Side1Length}, {tri.Side2Length}, and {tri.Side3Length}. Its area is {tri.CalculateArea()}, and its perimeter is {tri.CalculatePerimeter()}.");

                isActiveLoop = GetUserChoice("Would you like to continue (y/n)? ");

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
