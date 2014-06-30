using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr02.PrintCompanyInfo
{
    class PrintCompanyInfo
    {
        //        Problem 2. Print Company Information
        //A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number. Write a program that reads the information about a company and its manager and prints it back on the console.
        static void Main(string[] args)
        {
            Console.Title = "Print Company Information";


            string name;
            string address;
            string phNumber;
            string faxNumber;
            string webAddr;

            string managerFName;
            string managerLName;
            byte managerAge;
            string managerPhone;

            Console.WriteLine("Company name: ");
            name = Console.ReadLine();

            Console.WriteLine("Company address: ");
            address = Console.ReadLine();


            Console.WriteLine("Phone number: ");
            phNumber = Console.ReadLine();

            Console.WriteLine("Fax number: ");
            faxNumber = Console.ReadLine();

            Console.WriteLine("Web site: ");
            webAddr = Console.ReadLine(); ;

            Console.WriteLine("Manager first name: ");
            managerFName = Console.ReadLine();

            Console.WriteLine("Manager last name: ");
            managerLName = Console.ReadLine();

            Console.WriteLine("Manager age: ");
            byte.TryParse(Console.ReadLine(), out managerAge);


            Console.WriteLine("Manager phone: ");
            managerPhone = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(faxNumber))
                faxNumber = "no fax";

            string manFullName = string.Format("{0} {1}",managerFName , managerLName);

            Console.WriteLine("{0} \nCompany Address: {1} \nTel. {2} \nFax: {3} \nWeb Site: {4}"
                , name, address, phNumber, faxNumber, webAddr);

            Console.WriteLine("Manager: {0} (age: {1}, tel. {2})", manFullName, managerAge, managerPhone);


        }
    }
}
