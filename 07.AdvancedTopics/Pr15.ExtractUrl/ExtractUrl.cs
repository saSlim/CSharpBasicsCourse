using System;
using System.Text.RegularExpressions;

namespace Pr15.ExtractUrl
{
    class ExtractUrl
    {
        //        Problem 15. Extract URLs from Text
        //Write a program that extracts and prints all URLs from given text. URL can be in only two formats:
        //http://something, e.g. http://softuni.bg, http://forums.softuni.bg, http://www.nakov.com 
        //www.something.domain, e.g. www.nakov.com, www.softuni.bg, www.google.com


        static void Main(string[] args)
        {
            Console.Title = "Problem 15. Extract URLs from Text";


            Regex urlRx = new Regex(@"((http?|ftp|file)\://|www.)[A-Za-z0-9\.\-]+(/[A-Za-z0-9\?\&\=;\+!'\(\)\*\-\._~%]*)*", RegexOptions.IgnoreCase);

            string text = Console.ReadLine();

            MatchCollection matches = urlRx.Matches(text);
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }

        }
    }
}
