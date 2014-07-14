using System;
using System.Linq;

namespace Pr14.DecimalToBinary
{
    class DecimalToBinary
    {

        //        Problem 14. Decimal to Binary Number
        //Using loops write a program that converts an integer number to its binary representation. The input is entered as long. The output should be a variable of type string. Do not use the built-in .NET functionality.

        static void Main(string[] args)
        {
            Console.Title = "Problem 14. Decimal to Binary Number";

            long input;
            string output = string.Empty;

            long.TryParse(Console.ReadLine(), out input);


            while ((input) >= 1)
            {
                output += (input) % 2;
                input = input/2;
            }

            output = new string(output.Reverse().ToArray());
            Console.WriteLine(output);
        }
    }
}
