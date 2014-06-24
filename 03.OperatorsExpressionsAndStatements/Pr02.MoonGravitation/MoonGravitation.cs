using System;

namespace Pr02.MoonGravitation
{
    class MoonGravitation
    {
        //        Problem 2. Gravitation on the Moon
        //The gravitational field of the Moon is approximately 17% of that on the Earth. Write a program that calculates the weight of a man on the moon by a given weight on the Earth.

        static void Main()
        {
            Console.Title = "Gravitation on the Moon";

            double weight;
            double moonWeight;

            Console.WriteLine("Enter your weight:");
            double.TryParse(Console.ReadLine(), out weight);

            moonWeight = weight / 100.0 * 17;

            Console.WriteLine("On the moon your weight will be {0}.", moonWeight);

        }
    }
}
