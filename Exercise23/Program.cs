using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1_23
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

                for (int i = 0; i < 10; i++)
                {
                    Console.Write($"The first ten characters were: {userInput[i]}");
                }

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
