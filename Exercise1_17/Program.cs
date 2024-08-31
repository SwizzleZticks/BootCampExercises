using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1_17
{
    internal class Program
    {
        static void Main()
        {
            int height = 10;

            for (int i = 1; i <= height; i++)
            {
                for (int j = height - i; j > 0; j--)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= i; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
