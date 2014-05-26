//A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number. Write a program that reads the information about a company and its manager and prints them on the console.

using System;

class CompanyAndManagerInf
{
    static void Main()
    {
        Console.WriteLine("Please enter company name: ");
        string companyName = Console.ReadLine();
        Console.WriteLine("Please enter company address: ");
        string companyAddress = Console.ReadLine();
        Console.WriteLine("Please enter company phone: ");
        string companyPhone = Console.ReadLine();
        Console.WriteLine("Please enter company fax: ");
        string companyFax = Console.ReadLine();
        Console.WriteLine("Please enter company site: ");
        string companySite = Console.ReadLine();

        Console.WriteLine("Please enter the first name of the manager: ");
        string managerFName = Console.ReadLine();
        Console.WriteLine("Please enter the last name of the manager: ");
        string managerLName = Console.ReadLine();

        Console.WriteLine("Please enter the age of the manager: ");
        string managerAge = Console.ReadLine();
        byte managerAgeByte;

        // we'll check if the input age is correct. We will also set 2 additional conditions for the age of the manager - the age will be between 18 and 100 years.
        if (byte.TryParse(managerAge, out managerAgeByte) && managerAgeByte > 18 && managerAgeByte < 100) 
        {
            managerAgeByte = byte.Parse(managerAge);
        }
        else
        {
            Console.WriteLine("Please enter valid integer for the age of the manager!");
            managerAgeByte = byte.Parse(Console.ReadLine());
        }


        Console.WriteLine("Please enter the phone number of the manager: ");
        string managerPhone = Console.ReadLine();
        string managerFullName = managerFName + " " + managerLName;

        Console.WriteLine("Company - Name: {0}, Address: {1}, Phone: {2}, Fax: {3}, WebSite: {4}", companyName, companyAddress, companyPhone, companyFax, companySite);

        Console.WriteLine("Manager - Name: {0}, Age: {1}, Phone: {2}", managerFullName, managerAge, managerPhone);
    }
}