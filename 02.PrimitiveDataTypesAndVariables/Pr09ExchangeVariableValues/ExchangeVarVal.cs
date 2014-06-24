
using System;
namespace Pr09ExchangeVariableValues
{
    //    Problem 9. Exchange Variable Values
    //      Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by 
    //    using some programming logic. Print the variable values before and after the exchange.

    class ExchangeVarVal
    {
        static void Main()
        {
            Console.Title = "Problem 9. Exchange Variable Values";

            int a = 5;
            int b = 10;

            string before =string.Format( "| The values before exchange are: a = {0}, b = {1} |", a, b);
            
            Console.WriteLine("{0}" + new string('-', before.Length - 2) + "{0}", "+");
            Console.WriteLine(before);
            Console.WriteLine("{0}" + new string('-', before.Length - 2) + "{0}", "+");

            a = a + b;
            b = a - b;
            a = a - b;

            string after = string.Format("| The values after exchange are: a = {0}, b = {1} |", a, b);
            
            Console.WriteLine();
            Console.WriteLine("{0}" + new string('-', after.Length - 2) + "{0}", "+");
            Console.WriteLine(after);
            Console.WriteLine("{0}" + new string('-', after.Length - 2) + "{0}", "+");

        }
    }
}
