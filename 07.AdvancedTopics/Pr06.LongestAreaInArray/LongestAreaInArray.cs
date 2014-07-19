using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pr06.LongestAreaInArray
{
    class LongestAreaInArray
    {

        //        Problem 6. Longest Area in Array
        //Write a program to find the longest area of equal elements in array of strings. You first should read an integer n and n strings (each at a separate line), then find and print the longest sequence of equal elements (first its length, then its elements). If multiple sequences have the same maximal length, print the leftmost of them.

        static void Main(string[] args)
        {

            Console.Title = "Problem 6. Longest Area in Array";

            int n = Convert.ToInt32(Console.ReadLine());
            string[] nArr = new string[n];
            int counter = 0;
            Dictionary<string, int> duplicates = new Dictionary<string, int>();

            for (int i = 0; i < n; i++)
            {
                nArr[i] = Console.ReadLine();
            }

            for (int j = 0; j < nArr.Length; j++)
            {
                counter = 0;
                for (int k = 0; k < nArr.Length; k++)
                {
                    if (nArr[j].Equals(nArr[k]))
                        counter++;
                }
                if (!duplicates.ContainsKey(nArr[j]))
                    duplicates.Add(nArr[j], counter);
            }

            int max = duplicates.Values.Max();
            string[] relevantKeys = duplicates.Where(pair => max.Equals(pair.Value))
                .Select(pair => pair.Key).ToArray();

            Console.WriteLine(duplicates.Max(dup => dup.Value));
            Console.WriteLine(new StringBuilder(relevantKeys[0] + "\n", max));
        }
    }
}
