using System;

namespace Pr03.DivideBy7And5
{
    class DivideBy7And5
    {

        //        Problem 3. Divide by 7 and 5
        //Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.

        static void Main()
        {
            Console.Title = "Divide by 7 and 5";

            int n;

            Console.WriteLine("Please enter number to check if it can be dividet by 7 and 5:");
            int.TryParse(Console.ReadLine(), out n);

            Console.WriteLine("Your number can{0} be divided by 7 and 5!", n % 35 == 0 ? "" : "\'t");

        }
    }
}
