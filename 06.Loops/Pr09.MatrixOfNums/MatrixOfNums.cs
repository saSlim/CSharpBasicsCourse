using System;

namespace Pr09.MatrixOfNums
{
    class MatrixOfNums
    {

        //        Problem 9. Matrix of Numbers
        //Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix like in the examples below. Use two nested loops. 

        static void Main(string[] args)
        {
            Console.Title = "Problem 9. Matrix of Numbers";

            int n = 1;
            int n2;
            string output = string.Empty;

            do
            {
                Console.Write("Enter n: ");
                int.TryParse(Console.ReadLine(), out n);

            } while (n < 1 || n > 20);

            n2 = n;

            for (int i = 1; i <= n; i++)
            {
                output = string.Empty;
                n2++;
                for (int s = i; s < n2; s++)
                {
                    output += s;
                }
                Console.WriteLine(output);
            }

        }
    }
}
