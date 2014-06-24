using System;

namespace Pr._15BitsExchange
{
    class BitsExchange
    {

        //Problem 15. * Bits Exchange
        //Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer. 
        static void Main(string[] args)
        {
            Console.Title = "Problem 15. Bits Exchange";

            uint input;

            int[,] positions = {
                                   {3,24},
                                   {4,25},
                                   {5,26}
                               };

            Console.WriteLine("Enter number: ");
            uint.TryParse(Console.ReadLine(), out input);

            for (int i = 0; i < positions.Length / 2; i++)
            {
                int pos1 = positions[i, 0];
                int pos2 = positions[i, 1];
                bool isDiff = ((input & (1 << pos1)) != 0) ^ ((input & (1 << pos2)) != 0);

                if (isDiff)
                {
                    if ((input & (1 << pos1)) != 0)
                    {
                        input |=(uint)(1 << pos2);
                        input &= (uint)~(1 << pos1);
                    }
                    else
                    {
                        input &= (uint)~(1 << pos2);
                        input |= (uint)(1 << pos1);
                    }
                }
            }

            Console.WriteLine("Result: {0}", input);

        }
    }
}
