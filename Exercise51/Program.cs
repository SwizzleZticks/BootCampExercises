using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise51
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,string> dic = new Dictionary<string, string>
            {
                { "hello", "hola" },
                { "food", "comida" },
                { "world", "mundo" },
                { "computer", "computadora" },
                { "exercise", "ejercicio" }
            };

            bool isActiveLoop = true;
            do
            {
                Console.Write("Enter a word in english: ");
                string userInput = Console.ReadLine().ToLower();

                if (dic.ContainsKey(userInput))
                {
                    Console.WriteLine($"{userInput} in spanish is {dic[userInput]}");
                }
                else
                {
                    Console.WriteLine($"{userInput} cannot be translated.");
                }

                isActiveLoop = GetUserChoice("Would you like to continue (y/n)? ");
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
