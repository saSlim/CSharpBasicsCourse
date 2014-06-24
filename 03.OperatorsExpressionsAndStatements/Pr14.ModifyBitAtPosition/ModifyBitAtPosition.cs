using System;

namespace Pr14.ModifyBitAtPosition
{
    class ModifyBitAtPosition
    {

        //        Problem 14. Modify a Bit at Given Position
        //We are given an integer number n, a bit value v (v=0 or 1) and a position p. Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p from the binary representation of n while preserving all other bits in n

        static void Main(string[] args)
        {
            Console.Title = "Problem 14. Modify a Bit at Given Position";


            int input;
            byte v;
            int position;

            Console.WriteLine("Enter number: ");
            int.TryParse(Console.ReadLine(), out input);

            Console.WriteLine("Enter bit position:");
            int.TryParse(Console.ReadLine(), out position);

            Console.WriteLine("Enter bit value(0 or 1): ");
            byte.TryParse(Console.ReadLine(), out v);

            if (v == 0)
                input &= ~(1 << position);

            if (v == 1)
                input |= (1 << position);

            Console.WriteLine("Result: {0}", input);

        }
    }
}
