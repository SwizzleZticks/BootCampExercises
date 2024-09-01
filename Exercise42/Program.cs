using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise42
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

                Point point = new Point(x, y);

                Console.WriteLine($"You have created a point object ({point.X},{point.Y}).");

                isActiveLoop = GetUserChoice("Would you like to continue(y/n)? ");
            }while (isActiveLoop);

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
