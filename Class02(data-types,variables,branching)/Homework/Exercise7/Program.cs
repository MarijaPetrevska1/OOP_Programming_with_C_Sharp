
Console.WriteLine("======= Exercise 7 =======");
Console.WriteLine("");

// Asking the user to enter a number between 1 and 3
Console.Write("Enter a number from 1 to 3: ");
string input = Console.ReadLine();

// Try to parse the input as an integer
if (int.TryParse(input, out int number))
{
    // Checking the value of the entered number and print the corresponding message
    if (number == 1)
    {
        Console.WriteLine("You got a new car!");
    }
    else if (number == 2)
    {
        Console.WriteLine("You got a new plane!");
    }
    else if (number == 3)
    {
        Console.WriteLine("You got a new bike!");
    }
    else
    {
        // Error message if the number is not between 1 and 3
        Console.WriteLine("Error: You must enter a number between 1 and 3.");
    }
}
else
{
    // Error message if the input is not a valid number
    Console.WriteLine("Error: Please enter a valid number.");
}

Console.ReadLine();