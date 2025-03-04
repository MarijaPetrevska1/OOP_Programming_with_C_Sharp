Console.WriteLine("============== DATA TYPES AND VARIABLES ===============");

#region Variables and data types

//int testVariable;
int number = 5;
int studentCount = 19;

//int veryBigNumber1 = -21474383648;

long veryBigNumber2 = -2147483648223231231;
short buildingFloors = 10;

//Console.WriteLine(testVariable);
Console.WriteLine(number);
Console.WriteLine(studentCount);
Console.WriteLine(veryBigNumber2);
Console.WriteLine(buildingFloors);


double price = 19.4;
decimal tax = 1.4M;
float weight = 70.4f;

char specialCharacter = '%';
string firstName = "Marija";
string lastName = "Petrevska";
bool isThursday = true;
bool isRaining = false;

Console.WriteLine(price);
Console.WriteLine(tax);
Console.WriteLine(weight);
Console.WriteLine(specialCharacter);
Console.WriteLine(firstName);
Console.WriteLine(lastName);
Console.WriteLine(isThursday);
Console.WriteLine(isRaining);

#endregion


#region Operators

Console.WriteLine("==========OPERATORS==========");

int a = 10;
int b = 15;

double c = 10;
double d = 15;

int sum = a + b;
int difference = a - b;
int product = a * b;

double division = c / d;
int modulus = a % b;

Console.WriteLine(sum);
Console.WriteLine(difference);
Console.WriteLine(division);
Console.WriteLine(product);
Console.WriteLine(modulus);

bool isGreater = a > b;
Console.WriteLine(isGreater);

string academyName = "SEDC";
string courseName = "QA Automation";
string fullCourseName = academyName + " " + courseName;
Console.WriteLine(fullCourseName);

#endregion

#region Default values

Console.WriteLine("========== DEFAULT VALUES ============");

int someNumber = default;        // default for int is 0
string someText = default;       // default for string is null
bool someBoolean = default;      // default for bool is false
double someDouble = default;     // default for double is 0

Console.WriteLine(someNumber);
Console.WriteLine(someText);
Console.WriteLine(someBoolean);
Console.WriteLine(someDouble);


#endregion

#region Exercises

Console.WriteLine("=== EXERCISE 1 ===");
Console.WriteLine("");

double doubleVar1 = 10.5;
double doubleVar2 = 2.5;
double doubleDivision = doubleVar1 / doubleVar2;

int intVar1 = 10;
int intVar2 = 2;
int intDivison = intVar1 / intVar2;

Console.WriteLine("Double Division: " + doubleDivision);
Console.WriteLine("Integer Divison: " + intDivison);
Console.ReadLine();

Console.WriteLine("=== EXERCISE 2 ===");
Console.WriteLine("");

string greeting = "Hello";
string entity = "World";
string fullGreeting = greeting + " " + entity;


string numberStr1 = "9";
string numberStr2 = "3";
string concatenatedNumberStr = numberStr1 + numberStr2;

Console.WriteLine("Concatenated String: " + fullGreeting);
Console.WriteLine("Concatenated Number and String: " + concatenatedNumberStr);
Console.ReadLine();

Console.WriteLine("=== EXERCISE 3 ===");
Console.WriteLine("");

int someNum = 9;
string text = " apples";
string concatenatedResult = someNum + text;
Console.WriteLine("Concatenated Result: " + concatenatedResult);
Console.ReadLine();

Console.WriteLine("=== EXERCISE 4 ===");
Console.WriteLine("");

int totalCredits = 102;
int costPerSms = 5;
int numberOfSms = totalCredits / costPerSms;
Console.WriteLine("Number of SMS messages you can send: " + numberOfSms);

#endregion