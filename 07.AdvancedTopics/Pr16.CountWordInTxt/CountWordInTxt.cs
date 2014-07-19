using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Pr16.CountWordInTxt
{
    class CountWordInTxt
    {

        //        Problem 16. * Counting a Word in a Text
        //Write a program that counts how many times a given word occurs in given text. The first line in the input holds the word. The second line of the input holds the text. The output should be a single integer number – the number of word occurrences. Matching should be case-insensitive. Note that not all matching substrings are words and should be counted. A word is a sequence of letters separated by punctuation or start / end of text.

        static void Main(string[] args)
        {
            Console.Title = "Problem 16. * Counting a Word in a Text";
            Console.SetIn(new StreamReader(Console.OpenStandardInput(8192)));

            string word = Console.ReadLine();
            string text = Console.ReadLine();

            Regex urlRx = new Regex(@"\b" + word + @"\b", RegexOptions.IgnoreCase);

            MatchCollection matches = urlRx.Matches(text);
            
            Console.WriteLine(matches.Count);
        }
    }
}
