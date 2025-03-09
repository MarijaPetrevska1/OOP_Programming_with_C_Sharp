
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("\n============== Homework - TASK 2 ==============\n");
Console.WriteLine("\nConsole application: StudentGroup\n");
Console.ResetColor();

// Steps to do:
// => Make a new console application called StudentGroup
// => Make 2 arrays called studentsG1 and studentsG2 and fill them with 5 student names.
// => Get a number from the console between 1 and 2 and print the students from that group in the console.

// Two arrays with student names
string[] studentsGroupG1 = { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
string[] studentsGroupG2 = { "Marija", "Leonid", "Marko", "Aleksandar", "Ana" };

// Prompt user to enter the student group number (1 or 2)
Console.Write("Enter student group: (there are 1 and 2) ");

string input = Console.ReadLine();
int group;

// Checking if the user input is valid 
while (!int.TryParse(input, out group) || (group != 1 && group != 2))
{
    Console.Write("Invalid input. Please enter a valid group number (1 or 2): ");
    input = Console.ReadLine();
}

// Display the corresponding students from the selected group
if (group == 1)
{
    Console.WriteLine("The Students in Group G1 are:");
    for (int i = 0; i < studentsGroupG1.Length; i++)
    {
        Console.WriteLine($"{i + 1}. {studentsGroupG1[i]}");
    }
}
else if (group == 2)
{
    Console.WriteLine("The Students in Group G2 are:");
    for (int i = 0; i < studentsGroupG2.Length; i++)
    {
        Console.WriteLine($"{i + 1}. {studentsGroupG2[i]}");
    }
}
Console.ReadLine();
