using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr05.ThirdDigit
{
    class ThirdDigit
    {

        //        Problem 5. Third Digit is 7?
        //Write an expression that checks for given integer if its third digit from right-to-left is 7

        static void Main(string[] args)
        {
            Console.Title = "Third Digit";

            int number;
            int digit = 7;

            bool isDigit = false;

            Console.WriteLine("Please enter number:");
            int.TryParse(Console.ReadLine(), out number);

            if (number < 100)
                isDigit = false;

            if ((number / 100) % 10 == digit)
                isDigit = true;

            Console.WriteLine("The third digit from right-to-left {0} 7!", isDigit ? "is" : "is not");
        }
    }
}
