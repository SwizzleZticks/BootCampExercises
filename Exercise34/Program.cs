using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 16, 32, 64, 128, 256, };
            bool isActiveLoop = true;

            do
            {
                Console.Write("Enter a command (half/double):");
                string userInput = Console.ReadLine().ToLower();

                if(userInput == "half")
                {
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        int halfOfNum = numbers[i] / 2;
                        numbers[i] = halfOfNum;
                    }

                    Console.Write("The array now contains: ");
                    
                    foreach(int number in numbers)
                    {
                        Console.Write($"{number}, ");
                    }
                }
                else if(userInput == "double")
                {
                    for(int i = 0; i < numbers.Length; i++)
                    {
                        int doubledNum = numbers[i] * 2;
                        numbers[i] = doubledNum;
                    }

                    Console.Write("The array now contains: ");

                    foreach (int number in numbers)
                    {
                        Console.Write($"{number}, ");
                    }
                }

                isActiveLoop = GetUserChoice("\nWould you like to continue (y/n)?");

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
