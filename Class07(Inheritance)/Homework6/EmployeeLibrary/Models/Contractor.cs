using EmployeeLibrary.Enums;

namespace EmployeeLibrary.Models
{
    public class Contractor : Employee
    {
        public double WorkHours { get; set; }
        public double PayPerHour { get; set; }
        public Manager Responsible { get; set; }

        // Constructor to initialize the contractor object
        public Contractor(string firstName, string lastName, double workHours, double payPerHour, Manager responsible)
            : base(firstName, lastName, Role.Other, 0) 
        {
            WorkHours = workHours;
            PayPerHour = payPerHour;
            Responsible = responsible;
        }

        // Override GetSalary to calculate salary based on WorkHours and PayPerHour
        public override double GetSalary()
        {
            double salary = WorkHours * PayPerHour;
            return salary;
        }

        // A method to return the manager's department
        public string CurrentPosition()
        {
            return Responsible != null ? Responsible.Role.ToString() : "No Manager Assigned";
        }
    }
}
