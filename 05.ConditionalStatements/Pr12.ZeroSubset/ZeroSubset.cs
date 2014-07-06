using System;
using System.Collections.Generic;
using System.Linq;

namespace Pr12.ZeroSubset
{
    class ZeroSubset
    {
        //        Problem 12. * Zero Subset
        //We are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0. Assume that repeating the same subset several times is not a problem. 
        //The problem is for 5 numbers but this works for as much as you like :)

        static void Main(string[] args)
        {
            Console.Title = "Problem 12. * Zero Subset";

            string input;
            int[] inputArr = new int[0];
            int numOfSubsets;
            bool inputIsZeros = true;
            bool isZeroSubset = false;

            Console.Write("Enter 5 integer numbers separated by space: ");
            input = Console.ReadLine();

            try
            {
                inputArr = input.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
            }
            catch
            {
                Console.WriteLine("Incorect Input!");
                return;
            }

            //Check if all elements are 0
            for (int ia = 0; ia < inputArr.Length; ia++)
            {
                if (inputArr[ia] != 0)
                {
                    inputIsZeros = false;
                    break;
                }
            }

            if (!inputIsZeros)
            {
                numOfSubsets = 1 << inputArr.Length;

                for (int i = 0; i < numOfSubsets; i++)
                {
                    int pos = inputArr.Length - 1;
                    int bitmask = i;
                    List<int> Subset = new List<int>();

                    while (bitmask > 0)
                    {
                        if ((bitmask & 1) == 1)
                        {
                            Subset.Add(inputArr[pos]);
                        }
                        bitmask >>= 1;
                        pos--;
                    }

                    if (Subset.Count > 0 && Subset.Sum() == 0)
                    {
                        isZeroSubset = true;
                        string result = string.Empty;

                        for (int n = 0; n < Subset.Count; n++)
                        {
                            if (n == 0)
                            {
                                result += Subset[n];
                            }
                            else
                            {
                                result += " + " + Subset[n];
                            }
                        }
                        Console.WriteLine(result + " = 0");
                    }
                    Subset.Clear();
                }

                if (!isZeroSubset)
                {
                    Console.WriteLine("no zero subset");
                }
            }
            else
            {
                string allZeros = "0";
                
                for (int si = 1; si < inputArr.Length; si++)
                {
                    allZeros += " + " + "0";
                }
                Console.WriteLine(allZeros + " = 0");
            }

        }
    }
}
