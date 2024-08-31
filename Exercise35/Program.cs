using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise35
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "cow", "elephant", "jaguar", "horse", "crow" };
            bool isActiveLoop = true;

            do
            {
                Console.Write("Enter two indices: ");
                string[] indexes = Console.ReadLine().Split(' ');
                int wordIndex = int.Parse(indexes[0]);
                int letterIndex = int.Parse(indexes[1]);

                string theWord = words[wordIndex];

                if ((wordIndex <= words.Length && wordIndex > 0) && (letterIndex > 0 && letterIndex > theWord.Length))
                {
                    Console.WriteLine($"The word at {words[wordIndex]}. The letter at index {theWord[letterIndex]}");
                }
                else
                {
                    Console.WriteLine("Those are not valid indices");
                }

                isActiveLoop = GetUserChoice("/nWould you like to continue (y/n)? ");

            }while (isActiveLoop);
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
