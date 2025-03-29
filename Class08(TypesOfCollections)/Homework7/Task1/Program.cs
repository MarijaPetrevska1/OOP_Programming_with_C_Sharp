using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("\n   HOMEWORK 7  \n");
        Console.ResetColor();
        Queue<int> numbersQueue = new Queue<int>();
        string userInput = "Y"; 

        // Loop to input numbers
        while (userInput == "Y")
        {
            int number;
            bool validInput = false;

            // Checking if the user enters a valid number
            while (!validInput)
            {
                Console.Write("Please enter a number: ");
                string input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Input cannot be empty. Please enter a valid integer.");
                    continue;
                }

                if (int.TryParse(input, out number))
                {
                    numbersQueue.Enqueue(number); 
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Invalid input! Please enter a valid integer.");
                }
            }

            // Asking the user if they want to input another number
            bool validChoice = false;
            while (!validChoice)
            {
                Console.Write("Do you want to enter another number? (Y/N): ");
                userInput = Console.ReadLine()?.ToUpper(); 

                // Validate the user input for Y or N
                if (userInput == "Y" || userInput == "N")
                {
                    validChoice = true;
                }
                else
                {
                    Console.WriteLine("Invalid choice! Please enter 'Y' for Yes or 'N' for No.");
                }
            }
        }

        // Print all numbers in the order 
        Console.WriteLine("\nNumbers entered in the order:");
        while (numbersQueue.Count > 0)
        {
            Console.WriteLine(numbersQueue.Dequeue());
        }
        Console.ReadLine();
    }
}
