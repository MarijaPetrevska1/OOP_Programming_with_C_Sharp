Console.WriteLine("===== Homework1 (Data Types, Variables and Branching) =====");
Console.WriteLine("===== Task 3: SwapNumbers  =====");
Console.WriteLine();

// Input the first number
Console.Write("Please enter the first number: ");
int firstNum;
if (!int.TryParse(Console.ReadLine(), out firstNum))
{
    Console.WriteLine("Invalid input for the first number!");
    return;
}

// Input the second number
Console.Write("Please enter the second number: ");
int secondNum;
if (!int.TryParse(Console.ReadLine(), out secondNum))
{
    Console.WriteLine("Invalid input for the second number!");
    return;
}

// The numbers before swapping
Console.WriteLine("\nThe numbers before swapping:");
Console.WriteLine("First Number: " + firstNum);
Console.WriteLine("Second Number: " + secondNum);

// Swapping the values of firstNum and secondNum
int swapTemp = firstNum;
firstNum = secondNum;
secondNum = swapTemp;

// The numbers after swapping
Console.WriteLine("\nThe numbers after swapping:");
Console.WriteLine("First Number: " + firstNum);
Console.WriteLine("Second Number: " + secondNum);

Console.ReadLine();
