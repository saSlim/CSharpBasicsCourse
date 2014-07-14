using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr10.OddEvenProduct
{
    class OddEvenProduct
    {

        //        Problem 10. Odd and Even Product
        //You are given n integers (given in a single line, separated by a space). Write a program that checks whether the product of the odd elements is equal to the product of the even elements. Elements are counted from 1 to n, so the first element is odd, the second is even, etc.

        static void Main(string[] args)
        {
            Console.Title = "Problem 10. Odd and Even Product";

            string input;
            int[] inputArr;
            int oddProd = 1;
            int evenProd = 1;

            input = Console.ReadLine();

            inputArr = input.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();

            for (int i = 1; i <= inputArr.Length; i++)
            {
                if (i % 2 == 0)
                {
                    evenProd *= inputArr[i-1];
                }
                else
                {
                    oddProd *= inputArr[i-1];
                }
            }

            if (evenProd == oddProd)
            {
                Console.WriteLine("yes");
                Console.WriteLine("product = {0}", evenProd);
            }
            else
            {
                Console.WriteLine("no");
                Console.WriteLine("odd_product = {0}", oddProd);
                Console.WriteLine("even_product = {0}", evenProd);
            }
        }
    }
}
