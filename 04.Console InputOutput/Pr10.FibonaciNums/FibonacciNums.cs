using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr10.FibonacciNums
{
    class FibonacciNums
    {
        //Problem 10. Fibonacci Numbers
        //Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence (at a single line, separated by spaces) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …. Note that you may need to learn how to use loops.

        static void Main(string[] args)
        {
            Console.Title = "Problem 10. Fibonacci Numbers";

            int n;
            int fib0 = 0;
            int fib1 = 0;
            int fibn = 0;
            string fibSequence = string.Empty;

            Console.Write("Enter n = ");
            int.TryParse(Console.ReadLine(), out n);

            if (n == 1)
            {
                fibSequence = "0";
            }
            else if (n == 2)
            {
                fibSequence = "0 1";
            }

            for (int i = 2; i < n; i++)
            {
                if (i == 2)
                {
                    fibSequence = "0 1";
                    fib0 = 0;
                    fib1 = 1;
                }

                fibn = fib1 + fib0;
                fib0 = fib1;
                fib1 = fibn;

                fibSequence += " " + fibn;
            }

            Console.WriteLine("Fibonacci Sequence: {0}", fibSequence);

        }
    }
}
