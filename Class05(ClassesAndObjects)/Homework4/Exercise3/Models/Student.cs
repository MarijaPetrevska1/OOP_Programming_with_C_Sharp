using System;

namespace Homework4.Models
{
    public class Student
    {
        // Properties for Name, Academy, and Group
        public string Name { get; set; }
        public string Academy { get; set; }
        public string Group { get; set; }

        // Default constructor
        public Student()
        {
        }

        // Constructor to initialize a Student object with parameters
        public Student(string name, string academy, string group)
        {
            Name = name;
            Academy = academy;
            Group = group;
        }

        // Method to display the student's information
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Academy: {Academy}");
            Console.WriteLine($"Group: {Group}");
        }
    }
}
