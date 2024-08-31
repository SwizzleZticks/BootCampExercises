using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isActiveLoop = true;

            do
            {
                Console.WriteLine("Enter some text:");
                string userInput = Console.ReadLine();
                string result = string.Empty;

                for (int i = 10; i > 0; i--)
                {
                    result += userInput[userInput.Length - i];
                }

                Console.WriteLine($"The last 10 characters of {userInput} were: {result}");

                isActiveLoop = ContinueOrEndLoop("\nWould you like to continue (y/n)?");

                userInput = string.Empty;

            } while (isActiveLoop);
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
