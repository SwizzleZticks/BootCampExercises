using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isActiveLoop = true;
            int[] numbers = { 2, 8, 0, 24, 51 };

            do
            {
                Console.WriteLine("Enter a number: ");
                int userInput = int.Parse(Console.ReadLine());

                if (numbers.Contains(userInput))
                {
                    Console.WriteLine($"The value {userInput} can be found at index {Array.IndexOf(numbers, userInput)}");
                }
                else
                {
                    Console.WriteLine("A value cannot be found in the array.");
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
