using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a language: ");
            string language = Console.ReadLine();

            switch(language.ToUpper())
            {
                case "ENGLISH":
                    {
                        Console.WriteLine("Hello, World!");
                        break;
                    }
                case "SPANISH":
                    {
                        Console.WriteLine("Hola, Mundo!");
                        break;
                    }                    
                case "DUTCH":
                    {
                        Console.WriteLine("Hallo, werald!");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid input...");
                        break;
                    }
            }

            Console.WriteLine("Thank you for using my app press enter to close...");
            Console.ReadLine();
        }
    }
}
