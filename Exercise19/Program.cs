using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Write("Enter a number: ");
                int firstNumber = int.Parse(Console.ReadLine());

                Console.Write("Enter a second number: ");
                int secondNumber = int.Parse(Console.ReadLine());

                int sum = 0;

                for (int i = firstNumber; i <= secondNumber; i++)
                {
                    sum += i;
                }

                Console.WriteLine(sum);
            } while (GetUserChoice());
        }
        static bool GetUserChoice()
        {
            string userInput = "";
            bool isActive = false;

            do
            {
                Console.WriteLine("\nWould you like to continue? (Y/N): ");
                userInput = Console.ReadLine().ToUpper();

                if (userInput == "Y")
                {
                    isActive = true;
                }
                if (userInput == "N")
                {
                    isActive = false;
                }

            } while (userInput != "Y" && userInput != "N");

            return isActive;
        }
    }
}
