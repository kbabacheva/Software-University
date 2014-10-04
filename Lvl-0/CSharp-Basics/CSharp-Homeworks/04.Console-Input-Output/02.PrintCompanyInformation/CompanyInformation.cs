using System;
// A company has name, address, phone number, fax number, web site and manager. 
// The manager has first name, last name, age and a phone number. 
// Write a program that reads the information about a company and its manager and prints it back on the console.

class CompanyInformation
{
    static void Main()
    {
        Console.WriteLine("Company name:");
        string companyName = Console.ReadLine();
        Console.WriteLine("Company Adress:");
        string companyAdress = Console.ReadLine();
        Console.WriteLine("Phone Number:");
        string phoneNumber = Console.ReadLine();
        Console.WriteLine("Fax number:");
        string faxNumber = Console.ReadLine();
        Console.WriteLine("Web site:");
        string webSite = Console.ReadLine();
        Console.WriteLine("Manager first name:");
        string firstName = Console.ReadLine();
        Console.WriteLine("Manager last name:");
        string lastName = Console.ReadLine();
        string fullName = firstName + " " + lastName;
        Console.WriteLine("Manager's age:");
        string age = Console.ReadLine();
        Console.WriteLine("Manager phone:");
        string phone = Console.ReadLine();
        Console.WriteLine(companyName);
        Console.WriteLine("Adress: {0}", companyAdress);
        Console.WriteLine("Tel: {0}", phoneNumber);
        Console.WriteLine("Fax: {0}", faxNumber);
        Console.WriteLine("Web site: {0}", webSite);
        Console.WriteLine("Manager: {0} (age: {1}, tel: {2})", fullName, age, phone);
    }
}

