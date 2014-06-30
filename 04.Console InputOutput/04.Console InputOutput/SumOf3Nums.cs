using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Console_InputOutput
{
    class SumOf3Nums
    {

        //        Problem 1. Sum of 3 Numbers
        //Write a program that reads 3 real numbers from the console and prints their sum.

        static void Main(string[] args)
        {
            Console.Title = "Sum of Three Numbers";

            double a;
            double b;
            double c;

            Console.WriteLine("Enter value for a = ");
            double.TryParse(Console.ReadLine(), out a);

            Console.WriteLine("Enter value for b = ");
            double.TryParse(Console.ReadLine(), out b);
            
            Console.WriteLine("Enter value for c = ");
            double.TryParse(Console.ReadLine(), out c);

            Console.WriteLine("The sum of the numbers is {0}", a+b+c);

        }
    }
}
