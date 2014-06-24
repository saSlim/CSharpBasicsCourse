
using System;
namespace Pr02FloatOrDouble
{
    //    Problem 2. Float or Double?
    //      Which of the following values can be assigned to a variable of type float and which to a variable of type double: 
    //    34.567839023, 12.345, 8923.1234857, 3456.091? 
    //    Write a program to assign the numbers in variables and print them to ensure no precision is lost.

    class FloatOrDouble
    {
        static void Main()
        {
            Console.Title = "Problem 2. Float or Double?";

            double firstNumber = 34.567839023;
            float secondNumber = 12.345f;
            double thirdNumber = 8923.1234857;
            float fourthNumber = 3456.091f;
            
            Console.WriteLine("First number: {0} is {1}\nSecond number: {2} is {3}\nThird number: {4} is {5}\nFourth number: {6} is {7}",
                               firstNumber, NumType(firstNumber), secondNumber, NumType(secondNumber), thirdNumber, NumType(thirdNumber), fourthNumber, NumType(fourthNumber));
            
        }
        
       static string NumType(object number)
        {
            return number.GetType() == typeof(System.Double) ? "Double" : "Float";

        }
    }
}

