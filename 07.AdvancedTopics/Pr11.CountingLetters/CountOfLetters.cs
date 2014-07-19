using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr11.CountOfLetters
{
    class CountOfLetters
    {
        //        Problem 11. Count of Letters
        //Write a program that reads a list of letters and prints for each letter how many times it appears in the list. The letters should be listed in alphabetical order. Use the input and output format from the examples below.

        static void Main(string[] args)
        {
            Console.Title = "Problem 11. Count of Letters";

            List<char> list = Console.ReadLine().Split(' ').Select(n => n[0]).ToList();

            var q = list.GroupBy(x => x)
                        .Select(g => new { Value = g.Key, Count = g.Count() })
                        .OrderBy(x => x.Value);

            foreach (var x in q)
            {
                Console.WriteLine("{0}->{1}", x.Value, x.Count);
            }

        }
    }
}
