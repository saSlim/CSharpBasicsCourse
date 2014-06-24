
using System;
namespace Pr05BoolVar
{
    //    Problem 5. Boolean Variable
    //      Declare a Boolean variable called isFemale and assign an appropriate value corresponding to your gender. 
    //    Print it on the console.

    class BoolVar
    {
        static void Main()
        {
            Console.Title = "Problem 5. Boolean Variable";

            bool isFemale = new bool();
            char gender;
            Console.WriteLine("Please enter your gender (M/F):");
            char.TryParse(Console.ReadLine(), out gender);

            if (gender == 'm' || gender == 'f' || gender == 'M' || gender == 'F')
            {
                if (gender == 'm' || gender == 'M')
                    isFemale = false;
                else
                    isFemale = true;
            Console.WriteLine("Boolean variable isFemale is {0}", isFemale);
            }
            else
                Console.WriteLine("Incorrect input!");

        }
    }
}
