using System;

namespace Pr04.NumberComparer
{
    class NumComparer
    {
        //Problem 4. Number Comparer
        //Write a program that gets two numbers from the console and prints the greater of them. Try to implement this without if statements.


        static void Main(string[] args)
        {
            Console.Title = "Problem 4. Number Comparer";

            double a;
            double b;

            Console.Write("Please enter value for a = ");
            double.TryParse(Console.ReadLine(), out a);

            Console.Write("Please enter value for b = ");
            double.TryParse(Console.ReadLine(), out b);

            Console.WriteLine("The greater number is {0} ", (a > b) ? a : b);
        }
    }
}
