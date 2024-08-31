using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise38
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = new double[5];
            bool isActiveLoop = true;
            double sum = 0;
            do
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.Write("Enter a number: ");
                    numbers[i] = double.Parse(Console.ReadLine());
                }
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (i != 4)
                    {
                        if (i == 0)
                        {
                            Console.Write("(" + numbers[i] + " + ");
                        }
                        else
                        {
                            Console.Write(numbers[i] + " + ");
                        }
                    }

                    sum += numbers[i];

                    if (i == 4)
                    {
                        Console.Write(numbers[i] + ")/" + numbers.Length + " = " + sum/5);
                    }
                }

                isActiveLoop = GetUserChoice("\nWould you like to continue (y/n)? ");

            } while (isActiveLoop);

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
