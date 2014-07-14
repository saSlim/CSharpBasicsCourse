using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;

namespace Pr03.MinMaxSumAvgOfNNums
{
    class MinMaxSumAvgOfNNums
    {
        //        Problem 3. Min, Max, Sum and Average of N Numbers
        //Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point). The input starts by the number n (alone in a line) followed by n lines, each holding an integer number. The output is like in the examples below. 

        static void Main(string[] args)
        {
            Console.Title = "Problem 3. Min, Max, Sum and Average of N Numbers";
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            int n;
            int i=new int();
            List<int> input = new List<int>();

            int.TryParse(Console.ReadLine(), out n);

            while (i < n)
            {
                i++;
                input.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine("min = {0}", input.Min());
            Console.WriteLine("max = {0}", input.Max());
            Console.WriteLine("sum = {0}", input.Sum());
            Console.WriteLine("avg = {0:#.00}", input.Average());
        }
    }
}
