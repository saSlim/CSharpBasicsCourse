using System;
using System.Collections.Generic;
using System.Linq;

namespace Pr14.LongestWord
{
    class LongestWord
    {
        //        Problem 14. Longest Word in a Text
        //Write a program to find the longest word in a text.

        static void Main(string[] args)
        {
            Console.Title = "Problem 14. Longest Word in a Text";

            List<string> text = Console.ReadLine().Split(new char[] { ' ', '.', ',' }).ToList();

            string longest = text.OrderByDescending(s => s.Length).First();

            Console.WriteLine(longest);

        }
    }
}
