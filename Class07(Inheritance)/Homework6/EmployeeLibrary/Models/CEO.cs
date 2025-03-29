using EmployeeLibrary.Enums;
using System;

namespace EmployeeLibrary.Models
{
    public class CEO : Employee
    {
        public Employee[] Employees { get; set; }  
        public int Shares { get; set; }  
        private double SharesPrice { get; set; } 

        // Constructor to initialize the CEO
        public CEO(string firstName, string lastName, double salary, int shares)
            : base(firstName, lastName, Role.Manager, salary)
        {
            Shares = shares;
            SharesPrice = 100.00;  
        }

        // Method to add and change the SharesPrice 
        public void AddSharesPrice(double newPrice)
        {
            SharesPrice = newPrice;
        }

        // Method to print all employees under the CEO
        public void PrintEmployees()
        {
            Console.WriteLine("Employees:");
            foreach (var employee in Employees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName}");
            }
        }

        // Override GetSalary to include Shares * SharesPrice
        public override double GetSalary()
        {
            return Salary + (Shares * SharesPrice);
        }
    }
}

