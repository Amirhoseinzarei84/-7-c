// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Phone numbers
        string[] validPhoneNumbers = { "0123456789", "0147258369", "0999999888" };
        string[] invalidPhoneNumbers = { "1234567890", "012345678" };

        // Address
        string address = "rue Voltaire 145";

        // Customer care numbers
        List<string> customerCareNumbers = new List<string>
        {
            "0000000000",
            "9999999999",
            "0777778899"
        };

        // Display the processed information
        Console.WriteLine("Valid Phone Numbers:");
        foreach (var phoneNumber in validPhoneNumbers)
        {
            Console.WriteLine(phoneNumber);
        }

        Console.WriteLine("\nInvalid Phone Numbers:");
        foreach (var phoneNumber in invalidPhoneNumbers)
        {
            Console.WriteLine(phoneNumber);
        }

        Console.WriteLine($"\nAddress: {address}");

        Console.WriteLine("\nCustomer Care Numbers:");
        foreach (var number in customerCareNumbers)
        {
            Console.WriteLine(number);
        }
    }
}