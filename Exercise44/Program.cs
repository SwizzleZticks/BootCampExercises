using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise44
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isActiveLoop = true;

            do
            {
                Console.Write("Enter an X coordinate: ");
                int x = int.Parse(Console.ReadLine());
                Console.Write("Enter an Y coordinate: ");
                int y = int.Parse(Console.ReadLine());
                Point point1 = new Point(x, y);

                Console.WriteLine("-----New Point Creation-----");

                Console.Write("Enter an X coordinate: ");
                x = int.Parse(Console.ReadLine());
                Console.Write("Enter an Y coordinate: ");
                y = int.Parse(Console.ReadLine());
                Point point2 = new Point(x, y);

                Point midPoint = Point.CalculateMidPoint(point1, point2);

                Console.WriteLine($"The midpoint between ({point1.X},{point1.Y}) and ({point2.X},{point2.Y}) is ({midPoint.X},{midPoint.Y})");

                isActiveLoop = GetUserChoice("Would you like to continue(y/n)? ");
            } while (isActiveLoop);

            Console.WriteLine("Goodbye!");
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
