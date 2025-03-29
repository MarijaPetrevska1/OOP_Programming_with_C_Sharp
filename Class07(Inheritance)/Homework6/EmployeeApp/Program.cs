using System;
using EmployeeLibrary.Models;
using EmployeeLibrary.Enums;

class Program
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\n   HOMEWORK 6  \n");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("========= Exercise 1, 2, 3, Task 1, Task 2 ========== \n");
        Console.ResetColor();

        // EXERCISE 1 - Employee
        //Console.ForegroundColor = ConsoleColor.Magenta;
        //Console.WriteLine("Exercise 1: EMPLOYEE\n");
        //Console.ResetColor();
        //Employee emp = new Employee("Bob", "Bobsky", Role.Manager, 85000.00);
        //emp.PrintInfo();
        //double salary = emp.GetSalary();
        //Console.WriteLine($"The salary is: {salary}.\n");

        // EXERCISE 2 - SalesPerson
        //Console.ForegroundColor = ConsoleColor.Magenta;
        //Console.WriteLine("Exercise 2: SALESPERSON\n");
        //Console.ResetColor();
        SalesPerson salesperson = new SalesPerson("Jane", "Smith", 3000.00);
        Console.WriteLine("SalesPerson Information:\n");
        salesperson.PrintInfo();
        double salaryWithBonus = salesperson.GetSalary();
        Console.WriteLine($"Salary with Bonus: {salaryWithBonus}\n");
        salesperson.AddSuccessRevenue(6000.00);
        Console.WriteLine("Updated SalesPerson Information:\n");
        salesperson.PrintInfo();
        Console.WriteLine($"Updated Salary with Bonus: {salesperson.GetSalary()}\n");

        // EXERCISE 3 - Manager
        //Console.ForegroundColor = ConsoleColor.Magenta;
        //Console.WriteLine("Exercise 3: MANAGER\n");
        //Console.ResetColor();
        //Manager manager = new Manager("Analia", "Johnson", 90000.00);
        //manager.PrintManagerInfo(); 
        //manager.AddBonus(5000.00); 
        //Console.WriteLine("\nUpdated Manager Information:\n");
        //manager.PrintManagerInfo(); 
        //Console.WriteLine($"Total Salary with Bonus: {manager.GetSalary()}\n");

        // HOMEWORK TASK 1 - Contractor
        //Console.ForegroundColor = ConsoleColor.Magenta;
        //Console.WriteLine("TASK 1: Contractor\n");
        //Console.ResetColor();
        //Contractor contractor = new Contractor("David", "Green", 120.0, 50, manager); 
        //Console.WriteLine("Contractor Information:\n");
        //contractor.PrintInfo(); 
        //double contractorSalary = contractor.GetSalary();
        //Console.WriteLine($"Contractor Salary: {contractorSalary}");
        //string position = contractor.CurrentPosition();
        //Console.WriteLine($"Contractor's Responsible Manager's Department: {position}\n");


        // EXERCISE 3 - Manager
        Manager manager1 = new Manager("Bob", "Bobert", 5000.00);
        Manager manager2 = new Manager("Rick", "Rickert", 5500.00);

        // TASK 1 - Contractor
        Contractor contractor1 = new Contractor("Mona", "Monalisa", 150.0, 40, manager1);  
        Contractor contractor2 = new Contractor("Igor", "Igorsky", 160.0, 35, manager2);  

        // Create another SalesPerson
        SalesPerson salesperson2 = new SalesPerson("Lea", "Leova", 3000.00);

        // TASK 2 - CEO
        // Create an array of employees (Company)
        Employee[] company = new Employee[]
        {
            contractor1,
            contractor2,
            manager1,
            manager2,
            salesperson2
        };

        // Create a CEO instance
        CEO ceo = new CEO("Ron", "Ronsky", 1500.00, 1000);  
        ceo.Employees = company; 

        // Test the CEO
        Console.WriteLine("\nCEO:");
        ceo.PrintInfo();  
        ceo.PrintEmployees();  
        Console.WriteLine($"Salary of CEO is: {ceo.GetSalary()}");  

        // Change the shares price
        ceo.AddSharesPrice(120.00);  

        // Print updated CEO information with the new shares price
        Console.WriteLine("\nUpdated Salary of CEO:");
        Console.WriteLine($"Salary of CEO is: {ceo.GetSalary()}");


        Console.ReadLine();
    }
}
