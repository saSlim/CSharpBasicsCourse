using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr06.FourDigitNumber
{
    class FourDigitNum
    {

        //        Problem 6. Four-Digit Number
        //Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
        //Calculates the sum of the digits (in our example 2+0+1+1 = 4).
        //Prints on the console the number in reversed order: dcba (in our example 1102).
        //Puts the last digit in the first position: dabc (in our example 1201).
        //Exchanges the second and the third digits: acbd (in our example 2101).
        //The number has always exactly 4 digits and cannot start with 0. 

        static void Main(string[] args)
        {
            Console.Title = "Four Digit Number";

            int input;
            int[] tempArray;
            int temp;

            do
            {
                Console.WriteLine("Enter four digit number:");
            } while (!(int.TryParse(Console.ReadLine(), out input) && input >= 1000 && input < 10000));

            char[] inputArray = input.ToString().ToCharArray();

            int[] inputIntArr = Array.ConvertAll(inputArray, c => (int)Char.GetNumericValue(c));

            tempArray = (int[])inputIntArr.Clone();
            Console.WriteLine("The sum of the digits is: {0}", tempArray.Sum());

            Array.Reverse(tempArray);
            Console.WriteLine("Reversed input is: {0}", PrintArray(tempArray));

            tempArray = (int[])inputIntArr.Clone(); 
            temp = tempArray[1];
            tempArray[1] = tempArray[2];
            tempArray[2] = temp;
            Console.WriteLine("Exchanges the second and the third digits: {0}", PrintArray(tempArray));

            tempArray = (int[])inputIntArr.Clone(); 
            for (int i = tempArray.Length - 1; i >= 0; i--)
            {
                if (i == tempArray.Length - 1)
                    temp = tempArray[i];
                
                if (i < tempArray.Length - 1)
                    tempArray[i+1] = tempArray[i];

                if (i == 0)
                    tempArray[i] = temp;
            }

            Console.WriteLine("Put the last digit in the first position: {0}", PrintArray(tempArray));
        }

        static string PrintArray(int[] arr)
        {
            string tString = string.Empty;
            foreach (var n in arr)
                tString += n.ToString();

            return tString;
        }
    }
}
