using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isMoreWords = true;
            bool isActiveProgram = true;
            string sentence = string.Empty;

            do
            {
                do 
                { 
                    string userInput = GetUserInput("Enter a word: ");
                    sentence += userInput + " ";

                    isMoreWords = ContinueOrEndLoop("\nWould you like to enter another word (y/n)? ");

                    if (!isMoreWords)
                    {
                        Console.WriteLine(sentence);
                        sentence = string.Empty;
                    }
                    
                } while (isMoreWords);


                if (ContinueOrEndLoop("\nWould you like to continue (y/n)? "))
                {
                    isMoreWords = true;
                }
                else
                {
                    isActiveProgram = false;
                }
            } while (isActiveProgram);

            Console.WriteLine("\nThank you for using my program, Press enter to close the app...");
            Console.ReadLine();

        }

        static string GetUserInput(string message)
        {
            string userInput = string.Empty;

            do
            {
                Console.Write(message);
                userInput = Console.ReadLine();

            } while (string.IsNullOrEmpty(userInput));

            return userInput;
        }

        static bool ContinueOrEndLoop(string message)
        {
            string userChoice = string.Empty;
            bool isActiveLoop = true;
            bool isMoreInput = false;

            do
            {
                Console.Write(message);
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
