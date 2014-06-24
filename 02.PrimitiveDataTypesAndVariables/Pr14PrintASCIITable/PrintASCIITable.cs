
using System;
using System.Text;
namespace Pr14PrintASCIITable
{
    //    Problem 14. * Print the ASCII Table
    //      Find online more information about ASCII (American Standard Code for Information Interchange) and write a program to 
    //    prints the entire ASCII table of characters at the console (characters from 0 to 255). Note that some characters 
    //    have a special purpose and will not be displayed as expected. You may skip them or display them differently. 
    //    You may need to use for-loops (learn in Internet how).

    class PrintASCIITable
    {
        static void Main()
        {

            Console.Title = "Problem 14.* Print the ASCII Table";
            Console.InputEncoding = Encoding.ASCII;

            char symbol;

            for (int i = 0; i <= 255; i++)
            {
                symbol = (char)i;

                Console.WriteLine("{0}:{1}", i, symbol);
            }



        }
    }
}
