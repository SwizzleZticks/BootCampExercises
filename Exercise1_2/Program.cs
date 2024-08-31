using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(userInput + 1);

            Console.ReadLine();
        }
    }
}
