using System;
using System.Globalization;
using System.Threading;

namespace Pr05.FormatNumbers
{
    class FormatNums
    {

        //        Problem 5. Formatting Numbers
        //Write a program that reads 3 numbers: an integer a (0 ≤ a ≤ 500), a floating-point b and a floating-point c and prints them in 4 virtual columns on the console.
        //Each column should have a width of 10 characters. 
        //The number a should be printed in hexadecimal, left aligned; 
        //then the number a should be printed in binary form, padded with zeroes, 
        //then the number b should be printed with 2 digits after the decimal point, right aligned;
        //the number c should be printed with 3 digits after the decimal point, left aligned.

        static void Main(string[] args)
        {
            Console.Title = "Problem 5. Formatting Numbers";
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            int a;
            double b;
            double c;

            do
            {
                Console.Write("Please enter a = ");
                int.TryParse(Console.ReadLine(), out a);

            } while (a < 0 || a > 500);

            Console.Write("Please enter b = ");
            double.TryParse(Console.ReadLine(), out b);

            Console.Write("Please enter c = ");
            double.TryParse(Console.ReadLine(), out c);


            Console.WriteLine("|{0,-10:X}|{1,-10:0}|{2,10:0.00}|{3,-10:0.000}|", a, Convert.ToString(a, 2).PadLeft(10,'0'), b, c);

        }
    }
}
