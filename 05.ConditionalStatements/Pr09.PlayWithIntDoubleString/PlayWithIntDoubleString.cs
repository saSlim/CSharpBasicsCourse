using System;
using System.Globalization;
using System.Threading;

namespace Pr09.PlayWithIntDoubleString
{
    class PlayWithIntDoubleString
    {

        //        Problem 9. Play with Int, Double and String
        //Write a program that, depending on the user’s choice, inputs an int, double or string variable. If the variable is int or double, the program increases it by one. If the variable is a string, the program appends "*" at the end. Print the result at the console. Use switch statement. 
        static void Main(string[] args)
        {
            Console.Title = "PlayWithIntDoubleString";
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            int choice;
            dynamic input;

            Console.WriteLine("Please choose a type: \n\t1 --> int\n\t2 --> double\n\t3 --> string");
            int.TryParse(Console.ReadLine(), out choice);

            switch (choice)
            {
                case 1:
                    Console.Write("Please enter a int: ");
                    input = int.Parse(Console.ReadLine());
                    input++;
                    break;

                case 2:
                    Console.Write("Please enter a double: ");
                    input = double.Parse(Console.ReadLine());
                    input++;
                    break;

                case 3:
                    Console.Write("Please enter a string: ");
                    input = Console.ReadLine();
                    input += "*";
                    break;
                
                default:
                    input = "Incorect input!";
                    break;
            }
            Console.WriteLine(input);
        }
    }
}
