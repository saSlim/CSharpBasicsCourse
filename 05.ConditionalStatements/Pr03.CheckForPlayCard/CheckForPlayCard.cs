using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr03.CheckForPlayCard
{
    class CheckForPlayCard
    {

        //        Problem 3. Check for a Play Card
        //Classical play cards use the following signs to designate the card face: 2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. Write a program that enters a string and prints “yes” if it is a valid card sign or “no” otherwise. 

        static void Main(string[] args)
        {
            Console.Title = "Problem 3. Check for a Play Card";

            string[] cards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            string input = Console.ReadLine();
            bool validCard = false;

            foreach (string s in cards)
            {
                if (input.Equals(s))
                {
                    validCard = true;
                }
            }

            Console.WriteLine("{0}", validCard ? "yes" : "no");
        }
    }
}
