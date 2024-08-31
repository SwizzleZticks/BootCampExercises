using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise37
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            bool isActiveLoop = true;
            int sum = 0;
            do
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.Write("Enter a number: ");
                    numbers[i] = int.Parse(Console.ReadLine());
                }
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (i != 4)
                    {
                        Console.Write(numbers[i] + " + ");
                    } 

                    sum += numbers[i];

                    if(i == 4)
                    {
                        Console.Write(numbers[i] + " = " + sum);
                    }
                }

                isActiveLoop = GetUserChoice("\nWould you like to continue (y/n)? ");

            }while (isActiveLoop);

            Console.WriteLine("Goodbye!");
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
