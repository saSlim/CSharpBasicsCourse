using System;

namespace _17.PrintLongSequence
{
    class PrintLongSequence
    {
        static void Main(string[] args)
        {
            string all = "";

            for (int i = 2; i <= 1001; i++)
            {
                int n = i;
                if (i % 2 != 0)
                    n = i * -1;

                all += n + ", ";
            }

            Console.WriteLine(all);
        }
    }
}
