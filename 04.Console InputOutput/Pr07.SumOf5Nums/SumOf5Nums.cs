using System;
using System.Globalization;
using System.Threading;
using System.Linq;

namespace Pr07.SumOf5Nums
{
    class SumOf5Nums
    {

        //        Problem 7. Sum of 5 Numbers
        //Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum. 

        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.Title = "Problem 7. Sum of 5 Numbers";

            string input;
            double[] inputArray;

            Console.Write("Enter 5 Numbers separated by space: ");
            input = Console.ReadLine();
            
            inputArray = input.Split(' ').Select(n => Convert.ToDouble(n)).ToArray();

            Console.WriteLine("The sum of the numbers is: {0}", inputArray.Sum());

        }
    }
}
