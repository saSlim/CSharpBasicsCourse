
using System;
namespace Pr10EmployeeData
{
    //    Problem 10. Employee Data
    //      A marketing company wants to keep record of its employees. Each record would have the following characteristics:
    //      First name
    //      Last name
    //      Age (0...100)
    //      Gender (m or f)
    //      Personal ID number (e.g. 8306112507)
    //      Unique employee number (27560000…27569999)
    //    Declare the variables needed to keep the information for a single employee using appropriate primitive data types. 
    //    Use descriptive names. Print the data at the console.

    class EmplData
    {
        static void Main()
        {
            Console.Title = "Problem 10. Employee Data";


            string fName = "firstName";
            string lName = "lastName";
            byte age = 32;
            char gender = 'm';
            ulong pIdNum = 8306112507;
            uint uniqEmplNum = 27560000;

            Console.WriteLine("                 Employee Data:");
            Console.WriteLine();
            Console.WriteLine("             First name: {0}", fName);
            Console.WriteLine("              Last name: {0}", lName);
            Console.WriteLine("                    Age: {0}", age);
            Console.WriteLine("                 Gender: {0}", gender);
            Console.WriteLine("     Personal ID Number: {0}", pIdNum);
            Console.WriteLine(" Unique employee number: {0}", uniqEmplNum);
            Console.WriteLine();
        }

    }
}
