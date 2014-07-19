using System;
using System.Collections.Generic;
using System.Linq;

namespace Pr08.LongestNonDecreasingSubSeq
{
    class LongestNonDecreasingSubSeq
    {
        //        Problem 8. * Longest Non-Decreasing Subsequence
        //Write a program that reads a sequence of integers and finds in it the longest non-decreasing subsequence. In other words, you should remove a minimal number of numbers from the starting sequence, so that the resulting sequence is non-decreasing. In case of several longest non-decreasing sequences, print the leftmost of them. The input and output should consist of a single line, holding integer numbers separated by a space.


        static void Main(string[] args)
        {
            Console.Title = "Problem 8. * Longest Non-Decreasing Subsequence";

            string input = Console.ReadLine();
            int[] inputArr = input.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
            List<int[]> subSets = new List<int[]>();

            int numOfSubsets = 1 << inputArr.Length;

            for (int i = 0; i < numOfSubsets; i++)
            {
                int pos = inputArr.Length - 1;
                int bitmask = i;
                List<int> Subset = new List<int>();
                List<int> SubsetOfEquals = new List<int>();

                while (bitmask > 0)
                {
                    if ((bitmask & 1) == 1)
                    {
                        if (Subset.Count < 1 || Subset.Last() > inputArr[pos])
                        {
                            Subset.Add(inputArr[pos]);
                        }

                        if (SubsetOfEquals.Count < 1 || SubsetOfEquals.Last() == inputArr[pos])
                        {
                            SubsetOfEquals.Add(inputArr[pos]);
                        }
                    }
                    bitmask >>= 1;
                    pos--;
                }
                subSets.Add(Subset.ToArray());
                subSets.Add(SubsetOfEquals.ToArray());
                
                Subset.Clear();
                SubsetOfEquals.Clear();
            }

            int[] longest = subSets.OrderByDescending(s => s.Length).First();
            Array.Reverse(longest);

            Console.WriteLine(string.Join(" ", longest));
        }

    }
}
