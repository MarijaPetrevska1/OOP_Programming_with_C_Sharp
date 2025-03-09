Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("\n============== Homework - TASK 3 ==============\n");
Console.WriteLine("\n ===== Creating an array with names ===== \n");
Console.ResetColor();

// Steps:
// => 1.Create an array with names
// => 2.Give an option to the user to enter a name from the keyboard
// => 3.After entering the name put it in the array
// => 4.Ask the user if they want to enter another name(Y / N)
// => 5.Do the same process over and over until the user enters N
// => 6.Print all the names after user enters N


// Setting a maximum size for the array
int maxNames = 10;
string[] names = new string[maxNames];
int index = 0;

bool keepAddingNames = true;

while (keepAddingNames && index < maxNames)
{
    string name = "";

    // Loop until a valid name is entered ( => only alphabetic characters)
    bool validName = false;
    while (!validName)
    {
        // Ask the user to enter a name
        Console.Write("Please enter a name: ");
        name = Console.ReadLine();

        // Checking (validation) if the name contains only alphabetic characters
        bool isValid = true;
        foreach (char c in name)
        {
            // If the character is not a letter, it's invalid
            if (!char.IsLetter(c))
            {
                isValid = false;
                break;  
            }
        }

        if (!isValid)
        {
            Console.WriteLine("Invalid name! Please enter a name containing only letters (no numbers or special characters)!");
        }
        else
        {
            validName = true;  
        }
    }

    // Then add the entered name to the array
    names[index] = name;
    index++;

    // Asking if the user wants to enter another name
    string continueInput = "";
    bool validInput = false;

    while (!validInput)
    {
        Console.Write("Do you want to enter another name? (Y/N): ");
        continueInput = Console.ReadLine().ToUpper();

        if (continueInput == "Y" || continueInput == "N")
        {
            validInput = true;
        }
        else
        {
            Console.WriteLine("Invalid input! Please enter 'Y' for yes or 'N' for no.");
        }
    }

    // If the user entered 'N', the loop will stop
    if (continueInput == "N")
    {
        keepAddingNames = false;
    }
}
// Print all the names entered
Console.WriteLine("\nThe names you entered are:");

for (int i = 0; i < index; i++)
{
    Console.WriteLine($"{i + 1}. {names[i]}");
}
Console.ReadLine();
