using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput;

            while (true)
            {
                Console.Clear();
                Console.Write("Enter true or false: ");
                userInput = Console.ReadLine();

                if (userInput.ToLower() == "true")
                {
                    Console.Clear();
                    Console.Write("The opposite of what you entered is: false");
                    break;
                }
                else if (userInput.ToLower() == "false")
                {
                    Console.Clear();
                    Console.Write("The opposite of what you entered is: true");
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
