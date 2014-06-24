using System;

namespace Pr12.ExtractBitFromInt
{
    class ExtractBitFromInt
    {

        //        Problem 12. Extract Bit from Integer
        //Write an expression that extracts from given integer n the value of given bit at index p.

        static void Main(string[] args)
        {
            Console.Title = "Problem 12. Extract Bit from Integer";
            
            uint input;
            int BitToTest;
            int isSet;

            Console.WriteLine("Enter number: ");
            uint.TryParse(Console.ReadLine(), out input);

            Console.WriteLine("Enter bit index:");
            int.TryParse(Console.ReadLine(), out BitToTest);

            isSet = ((input & (1 << BitToTest)) != 0) ? 1 : 0;

            Console.WriteLine("The bit at position {0} is {1}",BitToTest ,isSet);

        }
    }
}
