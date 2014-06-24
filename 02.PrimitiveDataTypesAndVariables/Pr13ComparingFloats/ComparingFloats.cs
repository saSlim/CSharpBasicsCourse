
using System;
namespace Pr13ComparingFloats
{
    //    Problem 13. * Comparing Floats
    //      Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001. 
    //    Note that we cannot directly compare two floating-point numbers a and b by a==b 
    //    because of the nature of the floating-point arithmetic. Therefore, we assume two numbers are equal if they are more 
    //    closely to    each other than a fixed constant eps.

    class ComparingFloats
    {
        static void Main()
        {
            Console.Title = " Problem 13.* Comparing Floats";

            double a;
            double b;
            double? difference;

            double eps = 0.000001;

            Console.WriteLine("Type a double:");
            
            if (!double.TryParse(Console.ReadLine(), out a)) // Try to parse the string as an double
                Console.WriteLine("Not a double!");

            Console.WriteLine("Type a double:");
            
            if (!double.TryParse(Console.ReadLine(), out b)) // Try to parse the string as an double
                Console.WriteLine("Not a double!");

            //if (a > b)
            //    difference = a - b;
            //else
            //    difference = b - a;

            difference = (a > b) ? (a - b) : (b - a);

            Console.WriteLine ((difference > eps) ? "false":"true");
               
        }
    }
}
