using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isActiveLoop = true;
            int[] numbers = { 2, 8, 0, 24, 51 };

            do
            {
                Console.WriteLine("Enter an index of the array: ");
                int userInput = int.Parse(Console.ReadLine());

                if (userInput <= numbers.Length && userInput >= 0)
                {
                    Console.WriteLine($"The value at index {userInput} is {numbers[userInput]}");
                }
                else
                {
                    Console.WriteLine("That is not a valid index.");
                }

                isActiveLoop = GetUserChoice();
            } while (isActiveLoop);


        }
        static bool GetUserChoice()
        {
            string userInput = "";
            bool isActiveLoop = false;

            do
            {
                Console.WriteLine("\nWould you like to continue? (Y/N)");
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
