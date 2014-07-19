using System;
using System.Globalization;

namespace Pr04.DiffBetweenDates
{
    class DiffBetweenDates
    {
        //        Problem 4. Difference between Dates
        //Write a program that enters two dates in format dd.MM.yyyy and returns the number of days between them.

        static void Main(string[] args)
        {
            Console.Title = "Problem 4. Difference between Dates";

            DateTime date1 = DateTime.ParseExact(Console.ReadLine(), "d.MM.yyyy", CultureInfo.InvariantCulture);
            DateTime date2 = DateTime.ParseExact(Console.ReadLine(), "d.MM.yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine((date2-date1).TotalDays);
        }
    }
}
