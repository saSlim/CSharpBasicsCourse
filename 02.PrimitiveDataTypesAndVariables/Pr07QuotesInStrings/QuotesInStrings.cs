
using System;
namespace Pr07QuotesInStrings
{
    //    Problem 7. Quotes in Strings
    //      Declare two string variables and assign them with following value:
    //    The "use" of quotations causes difficulties.
    //    Do the above in two different ways: with and without using quoted strings. 
    //    Print the variables to ensure that their value was correctly defined.

    class QuotesInStrings
    {
        static void Main()
        {
            Console.Title = "Problem 7. Quotes in Strings";

            string str1 = "The \"use\" of quotations causes difficulties.";
            string str2 = @"The ""use"" of quotations causes difficulties.";

            Console.WriteLine("Using \'\\\' : {0}", str1);
            Console.WriteLine("Using \'@\' : {0}", str2);
        }
    }
}
