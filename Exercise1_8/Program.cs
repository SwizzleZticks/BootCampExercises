using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do //exercise 2
            {
                Console.Write("Enter a number: ");
                int userInput = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(userInput + 1);

            } while (GetUserChoice());

            do //exercise 3
            {
                Console.Write("\nEnter a number: ");
                float userInput = float.Parse(Console.ReadLine());

                Console.WriteLine(userInput + .5f);

            } while (GetUserChoice());

            do //exercise 4
            {
                Console.Write("\nEnter a number: ");
                float firstNumber = float.Parse(Console.ReadLine());

                Console.WriteLine("\nEnter a second number: ");
                float secondNumber = float.Parse(Console.ReadLine());

                Console.WriteLine(firstNumber + secondNumber);

            }while(GetUserChoice());

            do //exercise 5
            {
                Console.Write("\nEnter a number: ");
                float firstNumber = float.Parse(Console.ReadLine());

                Console.WriteLine("\nEnter a second number: ");
                float secondNumber = float.Parse(Console.ReadLine());

                Console.WriteLine(firstNumber * secondNumber);

            }while(GetUserChoice());

        }
        static bool GetUserChoice()
        {
            string userInput = "";
            bool isActive = false;

            do
            {
                Console.Write("\nWould you like to continue? (Y/N): ");
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
