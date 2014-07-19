using System;

namespace Pr05.SortingNumbers
{
    class SortingNumbers
    {
        //        Problem 5. Sorting Numbers
        //Write a program that reads a number n and a sequence of n integers, sorts them and prints them.

        static void Main(string[] args)
        {
            Console.Title = "Problem 5. Sorting Numbers";

            int n = Convert.ToInt32(Console.ReadLine());
            int[] nArr = new int[n];

            for (int i = 0; i < n; i++)
            {
                nArr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Sort(nArr);

            for (int j = 0; j < n; j++)
            {
                Console.WriteLine(nArr[j]);
            }
        }
    }
}
