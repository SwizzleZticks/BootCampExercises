using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1_22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isActiveProgram = true;

            do
            {
                int minValue = GetUserNumber("Enter a number: ");
                int maxValue = GetUserNumber("Enter another number: ");
                int userNumber = GetUserNumber("Enter a number to verify it is in range: ");

                CheckUserInput(minValue, maxValue, userNumber);
                

                isActiveProgram = ContinueOrEndLoop("Would you like to continue (y/n)? ");
            } while(isActiveProgram);
        }       
        static int GetUserNumber(string message)
        {
            int userNumber = 0;
            bool isParsable = false;

            do
            {
                Console.WriteLine(message);
                isParsable = int.TryParse(Console.ReadLine(), out userNumber);
            } while (!isParsable);

            return userNumber;
        }

        static void CheckUserInput(int min, int max, int userInput)
        {
            bool isInRange = userInput <= max && userInput >= min;

            if (isInRange)
            {
                Console.WriteLine($"{userInput} is in the range.");
            }
            else
            {
                Console.WriteLine($"{userInput} is outside the range.");
            }
        }

        static bool ContinueOrEndLoop(string message)
        {
            string userChoice = string.Empty;
            bool isActiveLoop = true;
            bool isMoreInput = false;

            do
            {
                Console.WriteLine(message);
                userChoice = Console.ReadLine().ToLower();

                if (userChoice.Substring(0, 1).ToLower() == "y" && !string.IsNullOrEmpty(userChoice))
                {
                    isMoreInput = true;
                    isActiveLoop = false;

                }
                else if (userChoice.Substring(0, 1).ToLower() == "n" && !string.IsNullOrEmpty(userChoice))
                {
                    isMoreInput = false;
                    isActiveLoop = false;
                }
            } while (isActiveLoop);

            return isMoreInput;
        }
    }
}
