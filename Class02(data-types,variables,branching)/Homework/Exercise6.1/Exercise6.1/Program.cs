Console.WriteLine("======= Exercise 6.1 =======");
Console.WriteLine("");

// 1. Asking the user to input two numbers
int num3, num4;

// User Input for the first number
Console.Write("Enter the first number: ");
string input1 = Console.ReadLine();
if (!int.TryParse(input1, out num3))
{
    Console.WriteLine("Invalid input for the first number. Please enter a valid integer.");
    return;
}

// User Input for the second number
Console.Write("Enter the second number: ");
string input2 = Console.ReadLine();
if (!int.TryParse(input2, out num4))
{
    Console.WriteLine("Invalid input for the second number. Please enter a valid integer.");
    return;
}

// 2. Checking if both numbers are the same
if (num3 == num4)
{
    Console.WriteLine("Both numbers are the same.");
}
else
{
    // 3. Checking which number is larger
    int largerNumber1;
    if (num3 > num4)
    {
        largerNumber1 = num3;
    }
    else
    {
        largerNumber1 = num4;
    }

    // 4. Checking if the larger number is even or odd
    string evenOrOdd1;
    if (largerNumber1 % 2 == 0)
    {
        evenOrOdd1 = "even";
    }
    else
    {
        evenOrOdd1 = "odd";
    }

    // Output the results to the console
    Console.WriteLine("The larger number from the two is " + largerNumber1);
    Console.WriteLine("The number is " + evenOrOdd1);
}

Console.ReadLine();


