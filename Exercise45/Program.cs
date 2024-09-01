using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise45
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isActiveLoop = true;

            do
            {
                Square square = new Square(GetNumber());

                Console.WriteLine($"The square has side length {square.SideLength}. Its area is {square.CalculateArea()} and its perimeter is {square.CalculatePerimeter()}.");
                isActiveLoop = GetUserChoice("Would you like to continue (y/n)? ");
            }while (isActiveLoop);
        }
        static int GetNumber()
        {
            bool isParsable = false;
            int input = 0;

            do
            {
                Console.Write("Enter a side length: ");
                isParsable = int.TryParse(Console.ReadLine(), out input);
            }while (!isParsable);

            return input;
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
