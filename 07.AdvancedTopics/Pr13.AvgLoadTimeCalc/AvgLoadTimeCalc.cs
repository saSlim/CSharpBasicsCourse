using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;

namespace Pr13.AvgLoadTimeCalc
{
    class AvgLoadTimeCalc
    {
        //        Problem 13. Average Load Time Calculator
        //We have a report that holds dates, web site URLs and load times (in seconds) in the same format like in the examples below. Your tasks is to calculate the average load time for each URL. Print the URLs in the same order as they first appear in the input report. Print the output in the format given below. Use double floating-point precision.

        static void Main(string[] args)
        {
            Console.Title = "Problem 13. Average Load Time Calculator";
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Dictionary<string, List<double>> report = new Dictionary<string, List<double>>();
            string[] inArr = new string[4];
            string line = Console.ReadLine();

            while (!string.IsNullOrEmpty(line))
            {
                line = Console.ReadLine();

                if (!string.IsNullOrEmpty(line))
                {
                    inArr = line.Split(' ').Select(n => n).ToArray();
                    if (report.ContainsKey(inArr[2]))
                    {
                        report[inArr[2]].Add(double.Parse(inArr[3]));
                    }
                    else
                    {
                        List<double> rL = new List<double>() 
                            {
                                double.Parse(inArr[3])
                            };

                        report.Add(inArr[2], rL);
                    }
                }
            }

            foreach (var item in report)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value.Average());
            }

        }
    }
}
