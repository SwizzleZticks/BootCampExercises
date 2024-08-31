using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isActiveLoop = true;
            int[] numbers = { 2, 8, 0, 24, 51 };

            do
            {
                Console.Write("Enter an index of the array: ");
                int index = int.Parse(Console.ReadLine());

                Console.WriteLine($"The value at index {index} is {numbers[index]}. ");
                bool isReplacingValue = GetUserChoice("Would you like to change it (Y/N)?");

                if (isReplacingValue)
                {
                    Console.Write($"Enter the new value at index {index}: ");
                    int newValue = int.Parse(Console.ReadLine());

                    numbers[index] = newValue;
                }

                Console.WriteLine($"The new value at index {index} is {numbers[index]}");
                
                isActiveLoop = GetUserChoice("Would you like to continue (Y/N)? ");
            } while (isActiveLoop);


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
