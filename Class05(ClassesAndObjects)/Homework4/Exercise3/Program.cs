using Exercise3.Models;

class Program
{
    static void Main()
    {
        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("  Homework 4 - Exercise 3 ");
        Console.ResetColor();
        Console.WriteLine("");
        // Creating an array of 5 Student objects
        Student[] students = new Student[]
        {
            new Student("Marija", "Programming Academy", "G2"),
            new Student("Gabriel", "Digital Marketing Academy", "G1"),
            new Student("Luka", "Graphic Design Academy", "G3"),
            new Student("Sophia", "Data Science Academy", "G4"),
            new Student("Michael", "Web design Academy", "G5")
        };

        bool found = false;

        // Repeating the name search until we find a match
        while (!found)
        {
            // Asking the user to input a name
            Console.Write("Please enter a student's name: \n");
            string inputName = Console.ReadLine();
            // Data validation
            // Checking if the name is empty (only spaces are entered)
            if (inputName == "")
            {
                Console.WriteLine("Error message! Name cannot be empty. Please try again.");
                continue;
            }

            // Checking if the name contains any numbers 
            bool hasNumber = false;
            foreach (char c in inputName)
            {
                if (c >= '0' && c <= '9')
                {
                    hasNumber = true;
                    break;
                }
            }

            if (hasNumber)
            {
                Console.WriteLine("Error, the name cannot contain numbers. Please try again!");
                continue;
            }

            inputName = inputName.ToLower();

            // Loop through the array to find the student by name
            foreach (Student student in students)
            {
                if (student.Name.ToLower() == inputName)
                {
                    student.DisplayInfo();
                    found = true;
                    break;
                }
            }

            // If no student is found, show an error message
            if (!found)
            {
                Console.WriteLine("Error -  No student found with the name \"" + inputName + "\". Please try again!");
            }
            Console.ReadLine();
        }
    }
}