using System;

namespace Pr02.NumsNotDiv3And7
{
    class NumsNotDiv3And7
    {

        //        Problem 2. Numbers Not Divisible by 3 and 7
        //Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n not divisible by 3 and 7, on a single line, separated by a space. 

        static void Main(string[] args)
        {
            Console.Title = "Problem 2. Numbers Not Divisible by 3 and 7";



            int n;
            string output = string.Empty;

            Console.Write("Enter n: ");
            int.TryParse(Console.ReadLine(), out n);

            for (int i = 1; i <= n; i++)
            {
                if ((i % 3 != 0) && (i % 7 != 0))
                {

                    if (i == 1)
                    {
                        output += i;
                    }
                    else
                    {
                        output += " " + i;
                    }
                }
            }

            Console.WriteLine(output);

        }
    }
}
