using System;

namespace Pr11.NumsInRangeDivByNumber
{
    class NumsDivByNumber
    {

        //        Problem 11. * Numbers in Interval Dividable by Given Number
        //Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0.

        static void Main(string[] args)
        {
            Console.Title = "Problem 11. * Numbers in Interval Dividable by Given Number";

            int start;
            int end;
            int p = new int();
            string numbers = string.Empty;

            do
            {
                Console.Write("Enter start: ");
                int.TryParse(Console.ReadLine(), out start);
            } while (start < 0);

            do
            {
                Console.Write("Enter end: ");
                int.TryParse(Console.ReadLine(), out end);
            } while (end < 0);


            for (int i = start; i <= end; i++)
            {
                if (i % 5 == 0)
                {
                    p++;
                    if(!string.IsNullOrEmpty(numbers))
                    {
                        numbers +=", ";
                    }
                    numbers += i;
                }
            }

            Console.WriteLine("\nP = {0}, numbers are: {1}", p, string.IsNullOrEmpty(numbers)? "-": numbers);
        }
    }
}
