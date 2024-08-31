using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise41
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isActiveLoop = true;

            do
            {
                Console.Write("Enter a number: ");
                double number1 = double.Parse(Console.ReadLine());
                Console.Write("Enter another number: ");
                double number2 = double.Parse(Console.ReadLine());

                if (number1 == 0 || number2 == 0)
                {
                    Console.WriteLine("You cannot divide by 0");
                }
                else
                {
                    double sum = number1 / number2;
                    Console.WriteLine($"{number1}/{number2} is approximately {sum.ToString(".##")}");
                }

                isActiveLoop = GetUserChoice("Continue (y/n)? ");
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
