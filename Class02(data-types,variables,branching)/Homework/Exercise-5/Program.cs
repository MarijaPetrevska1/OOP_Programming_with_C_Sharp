Console.WriteLine("======= Exercise 5 =======");
Console.WriteLine("");

// Given values
int numberOfBranches = 12;
int applesPerBranch = 8;
int applesPerBasket = 5;

// Step 1: Asking the user for the number of trees
Console.WriteLine("Please enter the number of trees: ");
string input = Console.ReadLine();

// Step 2: Checking if the input is Null or Empty, and try to parse the integer
int numberOfTrees;
if (string.IsNullOrWhiteSpace(input) || !int.TryParse(input, out numberOfTrees) || numberOfTrees <= 0)
{
    Console.WriteLine("Invalid input. Please enter a positive number for the number of trees.");
    Console.ReadLine();  
    return; // Exit the program if the input is invalid
}

// Step 3: Calculate the total number of apples for all the trees
int totalApplesPerTree = numberOfBranches * applesPerBranch;
int totalApplesForAllTrees = numberOfTrees * totalApplesPerTree;

// Step 4: Calculate the number of baskets needed using integer division and remainder
int basketsNeeded = (totalApplesForAllTrees + applesPerBasket - 1) / applesPerBasket;

// Output the result
Console.WriteLine("Total number of baskets needed: " + basketsNeeded);
Console.ReadLine();  

