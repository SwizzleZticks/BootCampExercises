using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Write("Enter your height in inches: ");
                double userHeight = double.Parse(Console.ReadLine());

                if (userHeight < 54)
                {
                    Console.WriteLine("\nSorry you cannot ride the Raptor. You need " + (54 - userHeight) + " more inches.");
                }
                else
                {
                    Console.WriteLine("\nGreat you can ride the Raptor!");
                }
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
