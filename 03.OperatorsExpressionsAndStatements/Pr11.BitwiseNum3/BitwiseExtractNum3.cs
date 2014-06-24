using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr11.BitwiseNum3
{
    class BitwiseExtractNum3
    {
        //        Problem 11. Bitwise: Extract Bit #3
        //Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer. The bits are counted from right to left, starting from bit #0. The result of the expression should be either 1 or 0.
        static void Main(string[] args)
        {
            Console.Title = "Problem 11. Bitwise: Extract Bit #3";

            uint input;
            int BitToTest = 3;
            
            Console.WriteLine("Enter number: ");
            
            uint.TryParse(Console.ReadLine(), out input);

            int isSet = ((input & (1 << BitToTest)) != 0) ? 1 : 0;

            Console.WriteLine("The #3 bit is {0}", isSet);

        }
    }
}
