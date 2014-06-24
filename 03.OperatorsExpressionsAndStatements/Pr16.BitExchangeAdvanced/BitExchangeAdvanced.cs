using System;

namespace Pr16.BitExchangeAdvanced
{
    class BitExchangeAdvanced
    {

        //        Problem 16. ** Bit Exchange (Advanced)
        //Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer. The first and the second sequence of bits may not overlap. 

        static void Main(string[] args)
        {

            Console.Title = "Problem 16. Bits Exchange (Advanced)";

            uint input;
            int p;
            int q;
            int k = new int();
            int[,] positions;

            Console.WriteLine("Enter number: ");
            uint.TryParse(Console.ReadLine(), out input);

            Console.WriteLine("Enter value for p: ");
            int.TryParse(Console.ReadLine(), out p);

            Console.WriteLine("Enter value for q: ");
            int.TryParse(Console.ReadLine(), out q);

            Console.WriteLine("Enter value for k: ");
            int.TryParse(Console.ReadLine(), out k);

            if ((p + k > 32) || (q + k > 32))
            {
                Console.WriteLine("Out of range!");
                return;
            }

            if ((p < q && (p + k > q)) || (p > q && (q + k > p)))
            {
                Console.WriteLine("Overlapping!");
                return;
            }

            positions = new int[k, 2];

            for (int i = 0; i < positions.Length / 2; i++)
            {
                positions[i, 0] = p + i;
                positions[i, 1] = q + i;
            }

            for (int i = 0; i < positions.Length / 2; i++)
            {
                int pos1 = positions[i, 0];
                int pos2 = positions[i, 1];
                bool isDiff = ((input & (1 << pos1)) != 0) ^ ((input & (1 << pos2)) != 0);

                if (isDiff)
                {
                    if ((input & (1 << pos1)) != 0)
                    {
                        input |= (uint)(1 << pos2);
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
