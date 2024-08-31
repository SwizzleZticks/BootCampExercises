using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            float firstNumber = float.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Enter a second number: ");
            float secondNumber = float.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine(firstNumber + secondNumber);

            Console.ReadLine();
        }
    }
}
