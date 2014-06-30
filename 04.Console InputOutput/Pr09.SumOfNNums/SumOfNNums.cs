using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Pr09.SumOfNNums
{
    class SumOfNNums
    {

        //        Problem 9. Sum of n Numbers
        //Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. Note that you may need to use a for-loop.

        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.Title = "Problem 9. Sum of n Numbers";


            int n;
            double[] inputArray;

            Console.Write("Enter number : ");
            int.TryParse(Console.ReadLine(), out n);

            inputArray = new double[n];
            
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter number : ");
                double.TryParse(Console.ReadLine(), out inputArray[i]);
            }

            Console.WriteLine("The sum of the numbers is: {0}", inputArray.Sum());

        }
    }
}
