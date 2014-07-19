using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr09.RemoveNames
{
    class RemoveNames
    {


        //        Problem 9. Remove Names
        //Write a program that takes as input two lists of names and removes from the first list all names given in the second list. The input and output lists are given as words, separated by a space, each list at a separate line. 

        static void Main(string[] args)
        {
            Console.Title = "Problem 9. Remove Names";

            List<string> list1 = Console.ReadLine().Split(' ').ToList();
            List<string> list2 = Console.ReadLine().Split(' ').ToList();

            for (int i = 0; i < list1.Count; i++)
            {
                string s = list1[i];
                if (list2.Contains(s))
                {
                    while (list1.Contains(s))
                    {
                        list1.Remove(s);
                    }
                }
            }

            Console.WriteLine(string.Join(" ", list1));
        }
    }
}
