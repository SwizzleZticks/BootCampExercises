using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise36
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 12, 11, 10, 9, 8 };
            string[] words = { "Drummers Drumming", "Pipers Piping", "Lords a-Leaping", "Ladies Dancing", "Maids a-Milking" };

            bool isActiveLoop = true;

            do
            {
                Console.WriteLine("Enter a command (sing/quit): ");
                string userInput = Console.ReadLine().ToLower();

                if(userInput == "sing" && !string.IsNullOrEmpty(userInput))
                {
                    for(int i = 0; i < numbers.Length; i++)
                    {
                        Console.Write($"{numbers[i]} {words[i]}\n");
                    }
                }
                if(userInput == "quit" && !string.IsNullOrEmpty(userInput))
                {
                    isActiveLoop = false;
                }
                
            }while (isActiveLoop);

            Console.WriteLine("Goodbye!");
        }
        
    }
}
