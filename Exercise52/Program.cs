using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise52
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sqList = new List<Square>();
            var triList = new List<Triangle>();
            var circList = new List<Circle>();
            bool isActiveLoop = true;

            do
            {
                Console.Clear();
                Console.WriteLine("Enter a new shape(1-3 or q to quit).\n1.Sqaure\n2.Triangle\n3.Circle");
                string userInput = Console.ReadLine().Substring(0, 1).ToLower();
                
                if (userInput != "q")
                {
                    int menuNumber = int.Parse(userInput);
                    switch (menuNumber)
                    {
                        case 1:
                            {
                                Console.Write("Enter a side length: ");
                                int sideLength = int.Parse(Console.ReadLine());
                                Square sq = new Square(sideLength);
                                sqList.Add(sq);
                                break;
                            }
                        case 2:
                            {
                                Console.WriteLine("Enter the side lengths of a triangle: ");
                                string[] sides = Console.ReadLine().Split(' ');
                                Triangle tri = new Triangle(int.Parse(sides[0]), int.Parse(sides[1]), int.Parse(sides[2]));
                                triList.Add(tri);
                                break;
                            }
                        case 3:
                            {
                                Console.WriteLine("Enter the radius: ");
                                int radius = int.Parse(Console.ReadLine());
                                Circle circle = new Circle(radius);
                                circList.Add(circle);
                                break;
                            }
                    }
                }
                if (userInput == "q")
                {
                    //average area of all objects
                    Console.WriteLine($"Average Area: {Square.GetArea(sqList) + Triangle.CalculateArea(triList) + Circle.GetArea(circList) / sqList.Count + triList.Count + circList.Count }");
                    //average perimeter of all objects
                    Console.WriteLine($"Average Perimeter: {Square.GetPerimeter(sqList) + Triangle.GetPerimeter(triList) + Circle.GetPerimeter(circList) / sqList.Count + triList.Count + circList.Count}");
                    isActiveLoop = GetUserChoice("Would you like to continue (y/n)? ");
                }
                
            } while (isActiveLoop) ;

                Console.ReadLine();
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
