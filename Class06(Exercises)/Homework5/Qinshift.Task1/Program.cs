class Program

//Steps to resolve this task:
//1) Setting up a loop to allow the user(ask the user) to try again or exit
//2) Accept the user input and validate the input
//3) Number - checking if the number is positive, negative, or zero; if the number is an integer or a decimal;
//if the number is odd or even
//4) After printing the stats, ask the user wants to try again or exit
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("");
        Console.WriteLine("   Homework 5 - Qinsfhit Task 1");
        Console.WriteLine("");
        Console.ResetColor();

        bool shouldContinue = true;

        while (shouldContinue)
        {
            // Asking the user to input a number
            Console.Write("Please enter a number: ");
            string input = Console.ReadLine();

            if (double.TryParse(input, out double number))
            {
                // Calling the method NumberStats here
                NumberStats(number);
            }
            else
            {
                // Error if the input is not a valid number
                Console.WriteLine("This is invalid input! Please enter a valid number!");
            }

            // Asking the user if they want to try again or exit
            string response;
            do
            {
                Console.Write("Do you want to try again? (Please enter 'Y' for Yes or 'X' for Exit): ");
                response = Console.ReadLine().ToUpper(); 

                // Handle invalid responses
                if (response != "Y" && response != "X")
                {
                    Console.WriteLine("This is invalid response! Please enter 'Y' to continue or 'X' to exit.");
                }

            } while (response != "Y" && response != "X");  
            if (response == "X")
            {
                shouldContinue = false;
            }
        }
    }

    static void NumberStats(double number)
    {
        // Print the number stats
        Console.WriteLine($"\nStats for number: {number}");

        // Checking if the number is positive, negative, or zero
        if (number > 0)
        {
            Console.WriteLine("- Positive");
        }
        else if (number < 0)
        {
            Console.WriteLine("- Negative");
        }
        else
        {
            Console.WriteLine("- Zero");
        }

        // Checking if the number is an integer or a decimal
        if (number % 1 == 0)
        {
            Console.WriteLine("- Integer");
        }
        else
        {
            Console.WriteLine("- Decimal");
        }

        // Checking if the number is odd or even 
        if (number % 1 == 0) 
        {
            if (number % 2 == 0)
            {
                Console.WriteLine("- Even");
            }
            else
            {
                Console.WriteLine("- Odd");
            }
        }

        Console.WriteLine(); 
    }
}
