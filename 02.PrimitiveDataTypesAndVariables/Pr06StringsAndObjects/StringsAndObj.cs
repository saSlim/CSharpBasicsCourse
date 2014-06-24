
using System;
namespace Pr06StringsAndObjects
{
    //    Problem 6. Strings and Objects
    //      Declare two string variables and assign them with “Hello” and “World”. Declare an object variable and assign it with the 
    //    concatenation of the first two variables (mind adding an interval between). Declare a third string variable and 
    //    initialize it with the value of the object variable (you should perform type casting).

    class StringsAndObj
    {
        static void Main()
        {
            Console.Title = "Problem 6. Strings and Objects";

            string str1 = "Hello";
            string str2 = "World";
            object myObj = str1 + " " + str2;
            string concatStr;

            concatStr = myObj.ToString();   // using ToString method
            Console.WriteLine(concatStr);

            concatStr = (string)myObj;  // using type casting as is required
            Console.WriteLine(concatStr);
        }
    }
}
