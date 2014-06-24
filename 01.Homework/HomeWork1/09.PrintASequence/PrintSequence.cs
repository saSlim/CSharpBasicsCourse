using System;

namespace _09.PrintASequence
{
    class PrintSequence
    {
        static void Main()
        {
            string all = "";
            
            for (int i = 2; i <= 11; i++)
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
