using System;
using System.Globalization;

namespace Pr10.BeerTime
{
    class BeerTime
    {


        //        Problem 10. * Beer Time
        //A beer time is after 1:00 PM and before 3:00 AM. Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12], a minute in range [00…59] and AM / PM designator) and prints “beer time” or “non-beer time” according to the definition above or “invalid time” if the time cannot be parsed. Note that you may need to learn how to parse dates and times.

        static void Main(string[] args)
        {

            Console.Title = "Pr10. Beer Time";


            DateTime startTime = DateTime.Parse("1:00 PM");
            DateTime endTime = DateTime.Parse("3:00 AM");
            DateTime inputTime;

            Console.WriteLine("Enter time in format “hh:mm tt”: ");
            try
            {
                inputTime = DateTime.ParseExact(Console.ReadLine(), "h:mm tt", DateTimeFormatInfo.InvariantInfo);
            }
            catch
            {
                Console.WriteLine("invalid time");
                return;
            }

            if ((inputTime >= startTime) || (inputTime < endTime))
            {
                Console.WriteLine("beer time");
            }
            else
            {
                Console.WriteLine("non-beer time");
            }

        }
    }
}
