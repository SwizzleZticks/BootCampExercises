using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isActiveLoop = true;

            do
            {
                Console.Write("Enter some text: ");
                string userInput = Console.ReadLine();
                int vowelCount = 0;

                for (int i = 0; i < userInput.Length; i++)
                {
                    if (IsVowel(userInput[i]))
                    {
                        vowelCount++;
                    }
                }

                Console.WriteLine($"There are {vowelCount} vowels.");
                isActiveLoop = GetUserChoice();

            } while (isActiveLoop);

            Console.WriteLine("Goodbye!");
            Console.ReadLine();
        }
        static bool GetUserChoice()
        {
            string userInput = "";
            bool isActiveLoop = false;

            do
            {
                Console.WriteLine("Would you like to continue? (Y/N)");
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
        static bool IsVowel(char character)
        {
            return "aeiouAEIOU".IndexOf(character) >= 0; //if this returns any number 0 or higher it is referencing the position by index which makes it true, -1 means false
        }
    }
}
