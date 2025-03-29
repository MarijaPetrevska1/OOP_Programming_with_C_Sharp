using System;
using System.Collections.Generic;

class Program
{

    static void SearchPhoneBook(Dictionary<long, string> phoneBook, long phoneNumber)
    {

        // Checking if the phone number exists in the phonebook
        if (!phoneBook.ContainsKey(phoneNumber))
        {
            Console.WriteLine("No such contact found! Sorry!");
            return;
        }
        Console.WriteLine($"The contact for phone number {phoneNumber} is: {phoneBook[phoneNumber]}");
    }

    static void Main(string[] args)
    {
        Dictionary<long, string> phoneBook = new Dictionary<long, string>()
        {
            { 070111222, "Marija" },
            { 078222333, "Bob" },
            { 077123444, "Jill" },
            { 071123678, "John" },
            { 070888999, "Hana" }
        };

        while (true)
        {
            Console.WriteLine("Please enter a phone number:");

            string input = Console.ReadLine();

            // Checking if the input is a valid number
            if (long.TryParse(input, out long userInput))
            {
                // Checking if the phone number exists in the phonebook
                SearchPhoneBook(phoneBook, userInput);
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a valid phone number.");
            }

            Console.WriteLine("Do you need another contact to search? (Y/N)");

            string choice = Console.ReadLine();
            if (choice.ToLower() == "n")
            {
                break;
            }

            Console.Clear();
        }
    }
}
