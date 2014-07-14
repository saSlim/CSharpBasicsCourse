using System;
using System.Linq;

namespace Pr13.BinaryToDecimal
{
    class BinaryToDecimal
    {

        //        Problem 13. Binary to Decimal Number
        //Using loops write a program that converts a binary integer number to its decimal form. The input is entered as string. The output should be a variable of type long. Do not use the built-in .NET functionality. 

        static void Main(string[] args)
        {
            Console.Title = "Problem 13. Binary to Decimal Number";

            string input = Console.ReadLine();
            long output = new long();

            input = new string(input.Reverse().ToArray());

            for (int i = 0; i < input.Length; i++)
            {
                output += int.Parse(input[i].ToString()) * (long)Math.Pow(2, i);
            }
            Console.WriteLine(output);

        }
    }
}
