using System;

namespace Task1
{
    internal class Program
    {
        // TASK: 
        // -> Make a method called AgeCalculator
        // -> The method will have one input parameter, your birthday date
        // -> The method should return your age
        // -> Show the age of a user after he inputs a date
        // -> Note: take into consideration if the birthday is today, after or before today
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n============== Homework3 - TASK 1 ==============\n");
            Console.WriteLine("\n ===== AgeCalculator ===== \n");
            Console.ResetColor();
            // Asking the user for their birthday
            Console.WriteLine("Please enter your birthdate in the format (yyyy-MM-dd):");
            string input = Console.ReadLine();

            // Validate and calculate age
            if (DateTime.TryParse(input, out DateTime birthDate))
            {
                if (birthDate > DateTime.Now)
                {
                    Console.WriteLine("The date you entered is in the future! Please enter a valid date.");
                }
                else
                {
                    int age = AgeCalculator(birthDate);
                    Console.WriteLine(" ");
                    Console.WriteLine($"Your age is: {age} years old.");

                    // Checking if the birthday is today
                    if (birthDate.Day == DateTime.Now.Day && birthDate.Month == DateTime.Now.Month)
                    {
                        Console.WriteLine("\n Happy Birthday! :) \n");
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid date format. Please try again.");
            }
            Console.WriteLine(" ");
            Console.WriteLine("Press Enter to exit.");
            Console.ReadLine();
        }

        static int AgeCalculator(DateTime birthDate)
        {
            // Get the current date for age calculation
            DateTime currentDate = DateTime.Now;

            // Calculate age in years
            int age = currentDate.Year - birthDate.Year;

            // Checking if the birthday has already occurred this year
            if (currentDate < birthDate.AddYears(age))
            {
                age--;
            }

            return age;
        }
    }
}
