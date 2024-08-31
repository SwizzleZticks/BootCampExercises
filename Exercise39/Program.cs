using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise39
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
                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.WriteLine("Enter a number: ");
                    numbers[i] = int.Parse(Console.ReadLine());
                }

                Array.Sort(numbers);
                foreach(int num in numbers)
                {
                    Console.Write(num + " ");
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
