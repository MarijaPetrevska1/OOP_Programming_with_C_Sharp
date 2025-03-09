
Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine("\n============== Homework - TASK 1 ==============\n");
Console.WriteLine("\nConsole application: SumOfEven\n");
Console.ResetColor();

//1. Make a console application called SumOfEven.
//2. Inside it create an array of 6 integers. 
//3. Get numbers from the input, find and print the sum of the even numbers from the array.

// Creating an array to hold 6 integers
int[] numbers = new int[6];

// Loop to get input for the array
for (int i = 0; i < 6; i++)
{
    int userInput;
    bool isValidInput = false;

    // Continue asking until a valid integer is entered
    while (!isValidInput)
    {
        Console.WriteLine($"Enter integer no.{i + 1}:");
        string input = Console.ReadLine();

        // Try to parse the input to an integer
        if (int.TryParse(input, out userInput))
        {
            numbers[i] = userInput;
            isValidInput = true; 
        }
        else
        {
            Console.WriteLine("This is invalid input. Please enter a valid integer!");
        }
    }
}

// The sum of even numbers
int sum = 0;
foreach (int number in numbers)
{
    if (number % 2 == 0)
    {
        sum = sum + number;
    }
}

// Display the result
Console.WriteLine($"The result is: {sum}");
Console.ReadLine();