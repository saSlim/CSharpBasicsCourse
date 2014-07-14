using System;
using System.Linq;

namespace Pr15.HexToDecimal
{
    class HexToDecimal
    {

        //        Problem 15. Hexadecimal to Decimal Number
        //Using loops write a program that converts a hexadecimal integer number to its decimal form. The input is entered as string. The output should be a variable of type long. Do not use the built-in .NET functionality. 

        static void Main(string[] args)
        {
            Console.Title = "Problem 15. Hexadecimal to Decimal Number";


            string input = Console.ReadLine();
            long output = new long();

            input = new string(input.Reverse().ToArray());

            for (int i = 0; i < input.Length; i++)
            {
                string temp = input[i].ToString().ToUpper();

                switch (temp)
                {
                    case "A":
                        temp = "10";
                        break;
                    case "B":
                        temp = "11";
                        break;
                    case "C":
                        temp = "12";
                        break;
                    case "D":
                        temp = "13";
                        break;
                    case "E":
                        temp = "14";
                        break;
                    case "F":
                        temp = "15";
                        break;

                    default:
                        break;
                }

                output += int.Parse(temp) * (long)Math.Pow(16, i);
            }
            Console.WriteLine(output);

        }
    }
}
