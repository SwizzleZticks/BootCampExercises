using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Write("Enter a number: ");
                int userNumber = int.Parse(Console.ReadLine());

                int sum = 0;

                for (int i = 1; i <= userNumber; i++)
                {
                    sum += i;
                }

                Console.WriteLine(sum);
            } while (GetUserChoice());

            Console.ReadLine();
        }

        static bool GetUserChoice()
        {
            string userInput = "";
            bool isActive = false;

            do
            {
                Console.WriteLine("Would you like to continue? (Y/N): ");
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
