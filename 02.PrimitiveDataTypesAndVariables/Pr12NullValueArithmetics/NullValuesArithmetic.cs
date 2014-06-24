
using System;
namespace Pr12NullValueArithmetics
{
    //    Problem 12. Null Values Arithmetic
    //      Create a program that assigns null values to an integer and to a double variable. Try to print these variables at the console.
    //    Try to add some number or the null literal to these variables and print the result.

    class NullValuesArithmetic
    {
        static void Main()
        {
            Console.Title = "Problem 12. Null Values Arithmetic";

            int? myInt = null;
            double? myDouble = null;

            Console.WriteLine("Variables are: myInt = {0}, myDouble = {1}", myInt, myDouble);

            myInt = myInt + 3;
            myDouble = myDouble + 7.4;

            Console.WriteLine("Variables after adding numbers are: myInt = {0}, myDouble = {1}", myInt, myDouble + 7);

        }
    }
}
