using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr12.CountOfNames
{
    class CountOfNames
    {
        //        Problem 12. Count of Names
        //Write a program that reads a list of names and prints for each name how many times it appears in the list. The names should be listed in alphabetical order. Use the input and output format from the examples below. 

        static void Main(string[] args)
        {
            Console.Title = "Problem 12. Count of Names";

            List<string> list = Console.ReadLine().Split(' ').Select(n => n).ToList();

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
