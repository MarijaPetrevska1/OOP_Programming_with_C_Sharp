Console.WriteLine("===== Homework1 (Data Types, Variables and Branching) =====");
Console.WriteLine("===== Task 2: AverageNumber  =====");
Console.WriteLine();


// First Number
Console.WriteLine("Enter the first number: ");
double firstNum;
if (!double.TryParse(Console.ReadLine(), out firstNum))
{
    Console.WriteLine("Invalid input for the first number!");
    return;
}

// Second number
Console.WriteLine("Enter the second number: ");
double secondNum;
if (!double.TryParse(Console.ReadLine(), out secondNum))
{
    Console.WriteLine("Invalid input for the second number!");
    return;
}

// Third number
Console.WriteLine("Enter the third number: ");
double thirdNum;
if (!double.TryParse(Console.ReadLine(), out thirdNum))
{
    Console.WriteLine("Invalid input for the third number!");
    return;
}

// Fourth number
Console.WriteLine("Enter the fourth number: ");
double fourthNum;
if (!double.TryParse(Console.ReadLine(), out fourthNum))
{
    Console.WriteLine("Invalid input for the fourth number!");
    return;
}

// Calculate the average
double average = (firstNum + secondNum + thirdNum + fourthNum) / 4;

// Display the result
Console.WriteLine("The average of the numbers" + " " + firstNum + " " + secondNum + " " + thirdNum + " " + fourthNum + " is: "+ average);

Console.ReadLine();