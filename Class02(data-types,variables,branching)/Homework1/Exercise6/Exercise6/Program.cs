Console.WriteLine("======= Exercise 6 =======");
Console.WriteLine("");

// 1. Declare and initialize two variables
int num1 = 10;
int num2 = 25;

// 2. Checking which number is larger
int largerNumber;
if (num1 > num2)
{
    largerNumber = num1;
}
else
{
    largerNumber = num2;
}

// 3. Checking if the larger number is even or odd
string evenOrOdd;
if (largerNumber % 2 == 0)
{
    evenOrOdd = "even";
}
else
{
    evenOrOdd = "odd";
}

//4. Output the results to the console
Console.WriteLine("The larger number from the two is " + largerNumber);
Console.WriteLine("And the number is " + evenOrOdd);
Console.ReadLine();

