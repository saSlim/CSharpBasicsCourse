using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr11.NumberAsWords
{
    class NumberAsWords
    {

        //        Problem 11. * Number as Words
        //Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.

        static void Main(string[] args)
        {
            Console.Title = "Problem 11. * Number as Words";

            string input;
            string output = string.Empty;
            bool isTeen = false;

            Console.Write("Enter Number: ");

            input = Console.ReadLine();
            
            //Add zero so the array has always 3 elements even if the input is 1 digit
            while (input.Length < 3)
            {
                input = '0' + input;
            }


            for (int i = 0; i < input.Length; i++)
            {
                switch (input[i])
                {
                    case '0':
                        if (i == 2 && (input[1] == '0' && input[0] == '0'))
                        {
                            output += "zero";
                        }
                        break;

                    case '1':
                        if (i == 1)
                        {
                            if (input[2] == '0')
                            {
                                output += "ten";
                            }
                            else if (input[2] == '1')
                            {
                                output += "eleven";
                            }
                            else if (input[1] == '1' && input[2] == '2')
                            {
                                output += "twelve";
                            }
                            else if (input[1] == '1' && input[2] == '3')
                            {
                                output += "thirteen";
                            }
                            else if (input[1] == '1' && input[2] == '5')
                            {
                                output += "fifthteen";
                            }
                            else if (input[1] == '1' && input[2] == '8')
                            {
                                output += "eighteen";
                            }
                            else
                            {
                                isTeen = true;
                            }

                        }
                        else if (input[1] != '1' || i == 0)
                        {
                            output += "one";
                        }
                        break;


                    case '2':

                        if (i == 1)
                        {
                            output += "twen";
                        }
                        else if (input[1] != '1' || i == 0)
                        {
                            output += "two";
                        }
                        break;

                    case '3':
                        if (i == 1)
                        {
                            output += "thir";
                        }
                        else if (input[1] != '1')
                        {
                            output += "three";
                        }
                        break;

                    case '4':
                        output += "four";
                        break;

                    case '5':
                        if (i == 1)
                        {
                            output += "fif";
                        }
                        else if (input[1] != '1')
                        {
                            output += "five";
                        }
                        break;

                    case '6':
                        output += "six";
                        break;

                    case '7':
                        output += "seven";
                        break;

                    case '8':
                        if (i == 1)
                        {
                            output += "eigh";
                        }
                        else if (input[1] != '1')
                        {
                            output += "eight";
                        }
                        break;

                    case '9':
                        output += "nine";
                        break;

                    default:
                        Console.WriteLine("not a digit");
                        return;

                }
                // Add "ty" 
                if (i == 1 && input[1] != '0' && input[1] != '1')
                {
                    output += "ty";
                }

                //Add Space
                if (input[i] != '0' && !isTeen)
                {
                    output += " ";
                }

                //Add "hundred"(" and")
                if (i == 0 && input[0] != '0')
                {
                    output += "hundred";
                    if (input[1] != '0' || input[2] != '0')
                    {
                        output += " and ";
                    }
                }

                //Add teen
                if (isTeen && i == 2 && input[1] == '1')
                {
                    output = output + "teen";
                }
            }

            output = ToUpperFirstLetter(output);

            Console.WriteLine(output);

        }

        public static string ToUpperFirstLetter(string source)
        {
            if (string.IsNullOrEmpty(source))
                return string.Empty;
            // convert to char array of the string
            char[] letters = source.ToCharArray();
            // upper case the first char
            letters[0] = char.ToUpper(letters[0]);
            // return the array made of the new char array
            return new string(letters);
        }
    }
}
