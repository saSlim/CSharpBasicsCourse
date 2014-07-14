using System;
using System.Linq;

namespace Pr16.DecimalToHex
{
    class DecimalToHex
    {

        //Problem 16. Decimal to Hexadecimal Number
        //Using loops write a program that converts an integer number to its hexadecimal representation. The input is entered as long. The output should be a variable of type string. Do not use the built-in .NET functionality. 

        static void Main(string[] args)
        {

            Console.Title = "Problem 16. Decimal to Hexadecimal Number";

            long input;
            string output = string.Empty;

            long.TryParse(Console.ReadLine(), out input);

            while ((input) >= 1)
            {
                string temp = ((input) % 16).ToString();

                switch (temp)
                {
                    case "10":
                        temp = "A";
                        break;
                    case "11":
                        temp = "B";
                        break;
                    case "12":
                        temp = "C";
                        break;
                    case "13":
                        temp = "D";
                        break;
                    case "14":
                        temp = "E";
                        break;
                    case "15":
                        temp = "F";
                        break;

                    default:
                        break;
                }
                                
                output += temp;
                input = input / 16;
            }

            output = new string(output.Reverse().ToArray());
            Console.WriteLine(output);
            
        }
    }
}
