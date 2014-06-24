
using System;
namespace _03.OperatorsExpressionsAndStatements
{

    //    Problem 1. Odd or Even Integers
    //Write an expression that checks if given integer is odd or even. 
    class OddOrEven
    {
        static void Main()
        {
            Console.Title = "Odd or Even?";

            int n;
            Console.WriteLine("Please enter number to check odd or even");

            int.TryParse(Console.ReadLine(), out n);

            Console.WriteLine("The number \'{0}\' is {1}!\n", n, n % 2 == 1 ? "odd" : "even");
        }
    }
}
