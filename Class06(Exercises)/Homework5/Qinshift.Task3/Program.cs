using Qinshift.Task3.Models;

namespace Qinshift.Task3
{
    class Program
    {
        // List of customers (initial customers)
        static List<Customer> customers = new List<Customer>
        {
            new Customer("Bob Bobsky", 1234123412341234, 4325, 850),
            new Customer("Grace Green", 1111222233334444, 1234, 1250)
        };

        static void Main()
        {
            // Main ATM loop
            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("");
                Console.WriteLine("   Homework 5 - Qinsfhit Task 3");
                Console.WriteLine("");
                Console.ResetColor();
                Console.WriteLine("Welcome to the ATM app");

                // Prompt the user to enter their card number
                Console.WriteLine("Please enter your card number (e.g., 1234-1234-1234-1234):");
                string cardInput = Console.ReadLine();
                string sanitizedCard = cardInput.Replace("-", ""); 

                if (sanitizedCard.Length != 16)
                {
                    Console.WriteLine("Invalid card number length. Card number should be 16 digits.");
                    continue;
                }

                if (!long.TryParse(sanitizedCard, out long cardNumber))
                {
                    Console.WriteLine("Invalid card number format.");
                    continue;
                }

                Customer currentCustomer = null;

                // Checking if the entered card number exists in the customer list
                foreach (var customer in customers)
                {
                    if (customer.CardNumber == cardNumber)
                    {
                        currentCustomer = customer;
                        break;
                    }
                }

                if (currentCustomer == null)
                {
                    Console.WriteLine("Card not found. Do you want to register a new card? (yes/no)");
                    string registerChoice = Console.ReadLine().ToLower();
                    if (registerChoice == "yes")
                    {
                        RegisterCustomer(cardNumber); 
                    }
                    continue; 
                }

                // Prompt the user to enter the PIN
                Console.WriteLine("Enter PIN:");
                if (!int.TryParse(Console.ReadLine(), out int pinInput))
                {
                    Console.WriteLine("Invalid PIN format.");
                    continue;
                }

                // Checking if the PIN length is exactly 4 digits
                if (pinInput.ToString().Length != 4)
                {
                    Console.WriteLine("PIN must be 4 digits.");
                    continue;
                }

                // Authenticate the user using the entered PIN
                if (!currentCustomer.Authenticate(pinInput))
                {
                    Console.WriteLine("Incorrect PIN.");
                    continue;
                }

                Console.WriteLine($"Welcome {currentCustomer.FullName}!");

                bool sessionActive = true;

                // ATM session loop (checking balance, withdrawal, etc.)
                while (sessionActive)
                {
                    // Display menu options
                    Console.WriteLine("What would you like to do:");
                    Console.WriteLine("1. Check Balance\n2. Cash Withdrawal\n3. Cash Deposit");
                    string action = Console.ReadLine();

                    // Validating the menu option
                    if (action != "1" && action != "2" && action != "3")
                    {
                        Console.WriteLine("Invalid option, please choose again.");
                        continue; 
                    }

                    switch (action)
                    {
                        case "1":
                            Console.Clear();
                            Console.WriteLine($"Your balance is {currentCustomer.GetBalance()}$");
                            break;
                        case "2":
                            Console.Clear();
                            Console.Write("Enter amount to withdraw: ");
                            if (decimal.TryParse(Console.ReadLine(), out decimal withdrawAmount))
                            {
                                if (withdrawAmount <= 0)
                                {
                                    Console.WriteLine("Amount must be greater than zero.");
                                    continue;
                                }

                                if (currentCustomer.Withdraw(withdrawAmount))
                                {
                                    Console.WriteLine($"You withdrew {withdrawAmount}$. You have {currentCustomer.GetBalance()}$ left on your account.");
                                }
                                else
                                {
                                    Console.WriteLine("Insufficient funds.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid amount.");
                            }
                            break;
                        case "3":
                            Console.Clear();
                            Console.Write("Enter amount to deposit: ");
                            if (decimal.TryParse(Console.ReadLine(), out decimal depositAmount))
                            {
                                if (depositAmount <= 0)
                                {
                                    Console.WriteLine("Amount must be greater than zero.");
                                    continue;
                                }

                                currentCustomer.Deposit(depositAmount);
                                Console.WriteLine($"Deposit successful. Your new balance is {currentCustomer.GetBalance()}$.");
                            }
                            else
                            {
                                Console.WriteLine("Invalid amount.");
                            }
                            break;
                    }

                    // Asking the user if they want to perform another action
                    Console.WriteLine("Do you want to perform another action? (yes/no)");
                    if (Console.ReadLine().ToLower() != "yes")
                    {
                        Console.WriteLine("Thank you for using the ATM app. Goodbye!");
                        sessionActive = false; 
                    }
                    Console.Clear(); 
                }
            }
        }

        // Function to register a new customer
        static void RegisterCustomer(long cardNumber)
        {
            Console.Write("Enter your full name: ");
            string fullName = Console.ReadLine();

            // Checking if the full name is valid
            if (string.IsNullOrWhiteSpace(fullName))
            {
                Console.WriteLine("Name cannot be empty.");
                return;
            }

            // Checking if card number is already registered
            if (customers.Exists(c => c.CardNumber == cardNumber))
            {
                Console.WriteLine("Card number already registered.");
                return;
            }

            // Prompt user to set a 4-digit PIN
            Console.Write("Set your PIN (4 digits): ");
            if (!int.TryParse(Console.ReadLine(), out int newPin) || newPin.ToString().Length != 4)
            {
                Console.WriteLine("Invalid PIN format.");
                return;
            }

            // Prompt user to enter an initial deposit amount
            Console.Write("Enter initial deposit: ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal initialDeposit) || initialDeposit <= 0)
            {
                Console.WriteLine("Invalid deposit amount. It must be greater than zero.");
                return;
            }

            // Add the new customer to the list
            customers.Add(new Customer(fullName, cardNumber, newPin, initialDeposit));
            Console.WriteLine("Registration successful! You can now log in with your card.");
        }
    }
}
