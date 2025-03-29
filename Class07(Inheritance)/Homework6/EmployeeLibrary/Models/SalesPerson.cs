using EmployeeLibrary.Enums;

namespace EmployeeLibrary.Models
{
    public class SalesPerson : Employee
    {
        private double SuccessSaleRevenue; 

        // Constructor to set all the properties
        public SalesPerson(string firstName, string lastName, double successSaleRevenue)
            : base(firstName, lastName, Role.Sales, 500) 
        {
            SuccessSaleRevenue = successSaleRevenue; 
        }

        // Method to add success sale revenue
        public void AddSuccessRevenue(double revenue)
        {
            SuccessSaleRevenue = revenue; 
        }

        // Override GetSalary to include bonus logic here
        public override double GetSalary()
        {
            double bonus = 0;

            // Bonus calculation based on SuccessSaleRevenue
            if (SuccessSaleRevenue <= 2000)
            {
                bonus = 500; 
            }
            else if (SuccessSaleRevenue <= 5000)
            {
                bonus = 1000;
            }
            else
            {
                bonus = 1500; 
            }

            return Salary + bonus; 
        }
    }
}




