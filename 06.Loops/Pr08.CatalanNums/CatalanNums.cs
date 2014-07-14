using System;
using System.Globalization;
using System.Numerics;
using System.Threading;

namespace Pr08.CatalanNums
{
    class CatalanNums
    {

        //        Problem 8. Catalan Numbers
        //In combinatorics, the Catalan numbers are calculated by the following formula:

        //Write a program to calculate the nth Catalan number by given n (1 < n < 100).

        static void Main(string[] args)
        {
            Console.Title = "Problem 8. Catalan Numbers";
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            //catalan = (2n)! /( (n+1)! * n! )


            int n;
            BigInteger factN = 1;
            BigInteger factNAdd1 = 1;
            BigInteger fact2N = 1;
            BigInteger catalan;

            do
            {
                Console.Write("Enter n: ");
                int.TryParse(Console.ReadLine(), out n);
            } while (n >= 100);

            for (int i = 1; i <= (2 * n); i++)
            {
                if (i <= n)
                {
                    factN = factN * i;
                }

                if (i <= n + 1)
                {
                    factNAdd1 = factNAdd1 * i;
                }

                fact2N = fact2N * i;
            }

            catalan = fact2N / (factNAdd1 * factN);

            Console.WriteLine(catalan);
        }


        ////// Alternative solution of the problem!


        //static void Main(string[] args)
        //{
        //    int n;

        //    do
        //    {
        //        Console.Write("Enter n: ");
        //        int.TryParse(Console.ReadLine(), out n);
        //    } while (n >= 100);

        //    Console.WriteLine(Catalan(n));
        //}

        //static int Catalan(int n)
        //{
        //    if (n == 1)
        //    {
        //        return 1; //since c(1)=1 is my base case
        //    }
        //    else
        //    {
        //        n = n - 1;
        //        return ((Catalan(n) * (2 * n + 2) * (2 * n + 1)) / ((n + 1) * (n + 2)));
        //    }
        //}



    }
}
