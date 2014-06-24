using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr13.CheckBitInPosition
{
    class CheckBitAtPosition
    {

        //        Problem 13. Check a Bit at Given Position
        //Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer number n has value of 1.
        static void Main(string[] args)
        {

            Console.Title = "Problem 13. Check a Bit at Given Position";

            uint input;
            int BitToTest;

            Console.WriteLine("Enter number: ");
            uint.TryParse(Console.ReadLine(), out input);

            Console.WriteLine("Enter bit index:");
            int.TryParse(Console.ReadLine(), out BitToTest);

          bool isSet = ((input & (1 << BitToTest)) != 0);

          Console.WriteLine("The bit at position {0} has value of 1 is: {1}", BitToTest, isSet);

        }
    }
}
