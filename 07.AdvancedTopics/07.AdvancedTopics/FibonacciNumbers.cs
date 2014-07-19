using System;

namespace _07.AdvancedTopics
{
    class FibonacciNumbers
    {

        //        Problem 1. Fibonacci Numbers
        //Define a method Fib(n) that calculates the nth Fibonacci number.

        static void Main(string[] args)
        {
            Console.Title = "Problem 1. Fibonacci Numbers";
            int n;
            Console.WriteLine("Enter n: ");
            int.TryParse(Console.ReadLine(), out n);

            Console.WriteLine(Fib(n));

        }
        static int Fib(int n)
        {
            int fib0 = 0;
            int fib1 = 0;
            int fibn = 0;

            if (n == 0 || n==1)
            {
                return 1;
            }
           
            for (int i = 2; i <= n; i++)
            {
                if (i == 2)
                {
                    fib0 = 1;
                    fib1 = 1;
                }
                fibn = fib1 + fib0;
                fib0 = fib1;
                fib1 = fibn;
            }
            return fibn;
        }

    }
}
