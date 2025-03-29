using EmployeeLibrary.Enums;

namespace EmployeeLibrary.Models
{
    public class Manager : Employee
    {
        private double Bonus; 

        // Constructor to set all properties 
        public Manager(string firstName, string lastName, double salary)
            : base(firstName, lastName, Role.Manager, salary) 
        {
            Bonus = 0; 
        }

        // Method to add bonus to the Manager
        public void AddBonus(double bonusAmount)
        {
            Bonus += bonusAmount; 
        }

        // Override GetSalary to return Salary + Bonus
        public override double GetSalary()
        {
            return Salary + Bonus; 
        }

        public void PrintManagerInfo()
        {
            Console.WriteLine($"First Name: {FirstName}, Last Name: {LastName}, Role: Manager, Salary: {Salary}, Bonus: {Bonus}");
        }
    }
}


