
using System;
using System.Text;
namespace Pr08IsoscalesTriangle
{
    //    Problem 8. Isosceles Triangle
    //      Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:
    //       ©
    //      © ©
    //     ©   ©
    //    © © © ©
    //    Note that the © symbol may be displayed incorrectly at the console so you may need to change the console 
    //    character encoding to UTF-8 and assign a Unicode-friendly font in the console. Note also, that under old versions of
    //    Windows the © symbol may still be displayed incorrectly, regardless of how much effort you put to fix it.

    class IsoscaleTriangle
    {
        static void Main()
        {
            Console.Title = "Problem 8. Isosceles Triangle";
            Console.OutputEncoding = Encoding.UTF8;

            char symbol = '©';
            char plHolder = ' ';
            string print;
            string final;
            int numSymbols = 9;
            int numLines;

             ////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //  // Uncoment this if you want to print the triangle with custom size and symbols!!!                     // //
           //////=====================================================================================================/////
            
            //Console.WriteLine("Please enter symbol for the triangle:");
            //char.TryParse(Console.ReadLine(), out symbol);

            //Console.WriteLine("Please enter symbol for background of the figure:");
            //char.TryParse(Console.ReadLine(), out plHolder);

            //Console.WriteLine("Please enter min number of symbols you want to use for triangle:");
            //int.TryParse(Console.ReadLine(), out numSymbols);
            
            /////=====================================================================================================/////
           
            final = symbol.ToString();
            numLines = (int)Math.Sqrt(numSymbols) - 1;

            for (int i = 0; i < numLines; i++)
            {
                print = new string(plHolder, numLines - i) + symbol + new string(plHolder, i);
                if (i == 0)
                    print += new string(plHolder, numLines);
                else
                    print += new string(plHolder, i - 1) + symbol + new string(plHolder, numLines - i);

                Console.WriteLine(print);
                if (i <= numLines)
                    final += plHolder + symbol.ToString();
            }
            Console.WriteLine(final);
        }
    }
}
