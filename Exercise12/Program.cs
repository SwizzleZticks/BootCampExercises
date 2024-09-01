using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                for (int i = 9; i >= 0; i--)
                {
                    Console.Write(i + " ");
                }

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
