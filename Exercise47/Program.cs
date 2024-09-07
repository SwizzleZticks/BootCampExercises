using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise47
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isActiveLoop = true;
            List<string> sentence = new List<string>();
            do
            {
                string input = GetUserInput("Enter some text: ");
                sentence.Add(input);

                Console.Write("You have entered: ");
                foreach(string word in sentence)
                {
                    Console.Write(word + " ");
                }
                isActiveLoop = GetUserChoice("\nWould you like to continue (y/n)? ");

            }while (isActiveLoop);

            Console.ReadLine();
        }

        static string GetUserInput(string message)
        {
            bool isValidInput = false;
            string word = string.Empty;

            while (!isValidInput)
            {
                Console.Write(message);
                word = Console.ReadLine();
                
                if (!string.IsNullOrEmpty(word))
                {
                    isValidInput = true;
                }
            }
            return word;
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
