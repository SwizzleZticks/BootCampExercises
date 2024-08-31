using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Enter a second number: ");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine(firstNumber / secondNumber);

            Console.ReadLine();
        }
    }
}
