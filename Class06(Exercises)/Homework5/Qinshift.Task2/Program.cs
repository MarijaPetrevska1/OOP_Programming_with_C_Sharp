using Qinshift.Task2.Models;
using System.Drawing;

// Steps to resolve this task:
// 1) Creating the User Class (properties: id, userName, password, messages)
// 2) Creating an array of users
// 3) Creating a loop that displays a menu asking the user to choose between: login and register
// 4) Login
// 5) Registration
// 6) Adding new users, resize the array dynamically.
// 7) Repeat or Exit.
class Program
{
    // Array of pre-existing users
    static User[] users = new User[]
    {
        new User { Id = 1, Username = "Helen", Password = "helen123", Messages = new List<string> { "Helen, your task is pending.", "New job opportunity available." } },
        new User { Id = 2, Username = "Anna", Password = "a987", Messages = new List<string> { "Anna, your profile was updated.", "Team meeting at 10AM tomorrow." } },
        new User { Id = 3, Username = "Charlie", Password = "mypassword", Messages = new List<string> { "Welcome Charlie!", "Your invoice is ready." } },
        new User { Id = 4, Username = "David", Password = "david123", Messages = new List<string> { "David, you have a new notification.", "Check out the latest report." } },
        new User { Id = 5, Username = "Eve", Password = "evepassword", Messages = new List<string> { "Hey Eve, your account was updated.", "Don't forget to check your messages." } },
        new User { Id = 6, Username = "Frank", Password = "frank456", Messages = new List<string> { "Frank, your session is about to expire.", "Important update on your project." } },
        new User { Id = 7, Username = "Grace", Password = "grace789", Messages = new List<string> { "Grace, we need your input on the report.", "Your recent purchase was successful." } }
    };

    // Main method for running the program
    static void Main()
    {
        while (true)
        {
            // Displaying the menu and asking the user to select an option
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("");
            Console.WriteLine("   Homework 5 - Qinsfhit Task 2");
            Console.WriteLine("");
            Console.ResetColor();
            Console.WriteLine("Please select an option: \n\n    1. LOG IN  2. REGISTER  3. EXIT");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Login(); 
                    break;
                case "2":
                    Register();  
                    break;
                case "3":
                    return;  
                default:
                    Console.WriteLine("Invalid option. Try again."); 
                    break;
            }
        }
    }

    // Method for user login
    static void Login()
    {
        Console.Write("Enter username: ");
        string username = Console.ReadLine();  
        Console.Write("Enter password: ");
        string password = Console.ReadLine(); 

        // Loop through the users array 
        foreach (var user in users)
        {
            if (user.Username == username && user.Password == password)
            {
                // If a match is found, display the user's messages
                Console.WriteLine($"Welcome {user.Username}. Here are your messages:");
                foreach (var message in user.Messages)
                {
                    Console.WriteLine(message);  
                }
                return;  
            }
        }

        Console.WriteLine("Error: Invalid username or password.");
    }

    // Method for user registration
    static void Register()
    {
        Console.Write("Enter new user ID: ");
        if (!int.TryParse(Console.ReadLine(), out int id))
        {
            Console.WriteLine("Invalid ID.");
            return;
        }

        // Checking if the user ID already exists in the users array
        bool idExists = false;
        for (int i = 0; i < users.Length; i++)
        {
            if (users[i].Id == id)
            {
                idExists = true;  
                break;
            }
        }

        if (idExists)
        {
            Console.WriteLine("Error: The user ID already exists. Please choose a different ID.");
            return;  
        }

        string username;
        while (true)
        {
            Console.Write("Enter new username: ");
            username = Console.ReadLine();  

            if (string.IsNullOrWhiteSpace(username))
            {
                Console.WriteLine("Username cannot be empty. Please try again.");
                continue;   
            }

            // Checking if the username contains only letters (no numbers or special characters)
            bool isValidUsername = true;
            for (int i = 0; i < username.Length; i++)
            {
                if (!char.IsLetter(username[i]) && username[i] != '_')  
                {
                    isValidUsername = false;  
                    break;
                }
            }

            if (!isValidUsername)
            {
                Console.WriteLine("Error: Username can only contain letters and underscores (no numbers or special characters). Please try again.");
                continue;
            }

            // Checking if the username already exists in the users array
            bool usernameExists = false;
            for (int i = 0; i < users.Length; i++)
            {
                if (users[i].Username == username)
                {
                    usernameExists = true;  
                    break;
                }
            }
            if (usernameExists)
            {
                Console.WriteLine("Error: Username already exists. Please choose another one.");
                continue;  
            }
            break;
        }

        Console.Write("Enter new password: ");
        string password = Console.ReadLine(); 

        Array.Resize(ref users, users.Length + 1);
        users[users.Length - 1] = new User { Id = id, Username = username, Password = password, Messages = new List<string>() };

        // Display the updated list of users
        Console.WriteLine("The registration is complete! The Users are:");
        foreach (var user in users)
        {
            Console.WriteLine($"ID: {user.Id}, Username: {user.Username}");  // Print all user IDs and usernames
        }
    }
}
