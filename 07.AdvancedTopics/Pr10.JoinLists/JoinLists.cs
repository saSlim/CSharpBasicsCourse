using System;
using System.Collections.Generic;
using System.Linq;

namespace Pr10.JoinLists
{
    class JoinLists
    {

        //        Problem 10. Join Lists
        //Write a program that takes as input two lists of integers and joins them. The result should hold all numbers from the first list, and all numbers from the second list, without repeating numbers, and arranged in increasing order. The input and output lists are given as integers, separated by a space, each list at a separate line.

        static void Main(string[] args)
        {
            Console.Title = "Problem 10. Join Lists";

            List<int> list1 = Console.ReadLine().Split(' ').Select(n => Convert.ToInt32(n)).ToList();
            List<int> list2 = Console.ReadLine().Split(' ').Select(n => Convert.ToInt32(n)).ToList();

            for (int i = 0; i < list2.Count; i++)
            {
                list1.Add(list2[i]);
            }

            list1 = list1.Distinct().ToList();
            list1.Sort();

            Console.WriteLine(string.Join(" ", list1));
        }
    }
}
