using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise29
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

                string[] arrayOfWords = userInput.Split(' ');

                for (int i = 0; i < arrayOfWords.Length; i++)
                {
                    for (int j = 0; j < arrayOfWords[i].Length; j++)
                    {
                        string word = arrayOfWords[i];

                        if (IsVowel(word[j]) && j != 0 && j != word.Length)
                        {
                            string editedWord = word.Remove(j,1);
                            arrayOfWords[i] = editedWord;
                        }
                    }
                    Console.Write(arrayOfWords[i] + " ");
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
        static bool IsVowel(char character)
        {
            return "aeiouAEIOU".IndexOf(character) >= 0; //if this returns any number 0 or higher it is referencing the position by index which makes it true, -1 means false
        }
    }
}
