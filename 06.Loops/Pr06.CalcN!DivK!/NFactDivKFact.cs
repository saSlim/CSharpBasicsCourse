using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Numerics;

namespace Pr06.CalcN_DivK_
{
    class NFactDivKFact
    {

        //        Problem 6. Calculate N! / K!
        //Write a program that calculates n! / k! for given n and k (1 < k < n < 100). Use only one loop.

        static void Main(string[] args)
        {
            Console.Title = "Problem 6. Calculate N! / K!";
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;


            int n;
            int k;
            BigInteger factN = 1;
            BigInteger factK = 1;

            do
            {
                Console.Write("Enter n: ");
                int.TryParse(Console.ReadLine(), out n);
            } while (n >= 100);

            do
            {
                Console.Write("Enter k: ");
                int.TryParse(Console.ReadLine(), out k);
            } while (k >= n);

            for (int i = 1; i <= n; i++)
            {
                if (i <= k)
                {
                    factK = factK * i;
                }
                factN = factN * i;
            }
            Console.WriteLine("{0}", factN / factK);


        }
    }
}
