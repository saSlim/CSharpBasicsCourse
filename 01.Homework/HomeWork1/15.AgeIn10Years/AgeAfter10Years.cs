using System;
using System.Globalization;

namespace _15.AgeIn10Years
{
    class AgeAfter10Years
    {
        static void Main(string[] args)
        {
            string input;

            Console.WriteLine("Please enter your birth date in format DD/MM/YYYY: ");
            input = Console.ReadLine();

            DateTime dOB = DateTime.ParseExact(input, "dd/MM/yyyy", DateTimeFormatInfo.InvariantInfo);

            DateTime today = DateTime.Today;
            int age = today.Year - dOB.Year;
            if (dOB > today.AddYears(-age)) age--;

            Console.WriteLine("You are {0} years old.", age);
            Console.WriteLine("After 10 years you will be {0}.", age + 10);
        }
    }
}
