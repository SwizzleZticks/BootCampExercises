using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Write("Enter a number: ");
                int userNumber = int.Parse(Console.ReadLine());

                int product = 1; //this needs to be 1 to get the original 6 to start

                for (int i = 0; i < 3; i++)
                {
                    int currentNumber = userNumber - i; //starts as 6
                    product *= currentNumber; // next iteration becomes 6 x 5 which product is equal to 30, then iterates back and makes  the 5 to a 4 which multiples to be 120
                }

                Console.WriteLine(product);

            } while (GetUserChoice());

            Console.ReadLine();
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
