using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise49
{
    internal class Program
    {        
        static void Main(string[] args)
        {
            List<Square> squareList = new List<Square>();
            bool isActiveLoop = true;

            do
            {
                Console.Write("Enter a side length (q to quit): ");
                string userInput = Console.ReadLine();

                if (int.TryParse(userInput, out int result))
                {
                    squareList.Add(new Square(result));
                }
                else if (squareList.Count != 0 && userInput.Substring(0,1).ToLower() == "q")
                {
                    DisplaySquareInfo(squareList);
                    isActiveLoop = GetUserChoice("\nWould you like to continue (y/n)? ");
                }
              
            }while (isActiveLoop);
        }

        static void DisplaySquareInfo(List<Square> sqList)
        {
            Console.WriteLine($"You created {sqList.Count} sqaures.");
            Console.WriteLine($"Largest: {sqList.OrderBy(sq => sq.SideLength).LastOrDefault().ToString()}");
            Console.WriteLine($"Smallest: {sqList.OrderBy(sq => sq.SideLength).FirstOrDefault().ToString()}");
            Square.GetArea(sqList);
            Square.GetPerimeter(sqList);
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
