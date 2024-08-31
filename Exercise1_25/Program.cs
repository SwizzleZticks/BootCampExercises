using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1_25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> wordList = new List<string>();
            bool isActiveLoop = true;

            do
            {
                Console.Write("Enter a sentence: ");
                string userInput = Console.ReadLine();

                string[] words = userInput.Split(' ');

                foreach (string word in words)
                {
                    Console.WriteLine(word);
                }

                isActiveLoop = GetUserChoice();

            } while (isActiveLoop);

            isActiveLoop = true;
            Console.Clear();

            do
            {
                Console.Write("Enter some text: ");
                string input = Console.ReadLine();

                wordList.Add(input);

                Console.Write("You have entered:");
                foreach (string word in wordList)
                {
                    Console.Write($" {word}");
                }
                Console.WriteLine();
                isActiveLoop = GetUserChoice();

            } while (isActiveLoop);


            Console.WriteLine("Press enter to close the app...");
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
    }
}
