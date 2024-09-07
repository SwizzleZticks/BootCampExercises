using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise48
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isActiveLoop = true;
            List<int> numbers = new List<int>();
            int sum = 0;
            do
            {
                int input = GetUserInput("\nEnter a number (q to quit): ");
                if(input == -1)
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if(i != numbers.Count - 1)
                        {
                            Console.Write(numbers[i] + " + ");
                        }                       
                        sum += numbers[i];
                        if (i == numbers.Count - 1)
                        {
                            Console.Write(numbers[i] + " = " + sum);
                        }
                    }
                    isActiveLoop = false;
                }
                else
                {
                    numbers.Add(input);                    
                }
            }while(isActiveLoop);

            Console.ReadLine();
        }
    static int GetUserInput(string message)
    {
        bool isActiveLoop = true;
        string input = "";
        int result = -1;

        while (isActiveLoop)
        {
            Console.Write(message);
            input = Console.ReadLine();
            bool isParsable = int.TryParse(input, out result);
            
            if (isParsable)
            {
                return result;
            }
            else
            {
                result = -1;
                isActiveLoop = false;
            }
        }
            return result;
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
