Console.WriteLine("===== Homework1 (Data Types, Variables and Branching) =====");
Console.WriteLine("===== Task 1: RealCalculator =====");
Console.WriteLine();

// Asking the user for the first number
Console.Write("Please enter the first number: ");
double firstNumber;
if (!double.TryParse(Console.ReadLine(), out firstNumber))
{
    Console.WriteLine("Invalid input for the first number.");
    return;
}

// Asking the user to input the second number
Console.Write("Please enter the second number: ");
double secondNumber;
if (!double.TryParse(Console.ReadLine(), out secondNumber))
{
    Console.WriteLine("Invalid input for the second number.");
    return;
}

// Asking the user to input the operation
Console.Write("Enter the Operation (+, -, *, /): ");
string operation = Console.ReadLine();

// Performing the operation and display the result
double result = 0;
bool validOperation = true;

switch (operation)
{
    case "+":
        result = firstNumber + secondNumber;
        break;
    case "-":
        result = firstNumber - secondNumber;
        break;
    case "*":
        result = firstNumber * secondNumber;
        break;
    case "/":
        // Checking for division by zero
        if (secondNumber != 0)
        {
            result = firstNumber / secondNumber;
        }
        else
        {
            Console.WriteLine("Error! Division by zero is not allowed!");
            return;
        }
        break;
    default:
        Console.WriteLine("Invalid operation entered.");
        validOperation = false;
        break;
}

if (validOperation)
{
    // Display the result: 
    Console.WriteLine("The result is: " + result);
}
Console.ReadLine();

