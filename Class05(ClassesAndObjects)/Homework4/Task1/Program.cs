using System;

namespace Task1.Models
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("");
            Console.WriteLine("   Homework 4 - Task 1");
            Console.WriteLine("");
            Console.ResetColor();

            //  Driver objects
            Driver marija = new Driver("Marija", 5);
            Driver greg = new Driver("Greg", 6);
            Driver jill = new Driver("Jill", 7);
            Driver bob = new Driver("Bob", 8);

            //  Car objects
            Car bmw = new Car("BMW", 120);
            Car toyota = new Car("Toyota", 130);
            Car ferrari = new Car("Ferrari", 200);
            Car porsche = new Car("Porsche", 180);

            // Display Car choices and Driver choices
            while (true)
            {
                int car1Choice = GetCarChoice("Please choose a car for Car number 1: \n");
                int driver1Choice = GetDriverChoice("Please choose a driver for Car number 1: \n");

                Car car1 = GetCarObject(car1Choice);
                Driver driver1 = GetDriverObject(driver1Choice);

                car1.CarDriver = driver1;

                // Car no.2 selections
                int car2Choice = GetCarChoiceForSecondCar(car1Choice);
                int driver2Choice = GetDriverChoice("Please choose a driver for Car number 2:\n");

                Car car2 = GetCarObject(car2Choice);
                Driver driver2 = GetDriverObject(driver2Choice);

                car2.CarDriver = driver2;

                // Race the cars
                RaceCars(car1, car2);

                // Asking if the user wants to race again
                Console.WriteLine("\nDo you want to race again? (y/n):\n");
                char raceAgain = char.ToLower(Console.ReadKey().KeyChar);
                if (raceAgain != 'y')
                {
                    break;
                }
                Console.Clear();
            }
        }

        // Method to get a valid car choice
        static int GetCarChoice(string prompt)
        {
            int carChoice;
            while (true)
            {
                Console.WriteLine(prompt);
                Console.WriteLine("1. BMW");
                Console.WriteLine("2. Toyota");
                Console.WriteLine("3. Ferrari");
                Console.WriteLine("4. Porsche");
                if (int.TryParse(Console.ReadLine(), out carChoice) && carChoice >= 1 && carChoice <= 4)
                {
                    return carChoice;
                }
                else
                {
                    Console.WriteLine("Invalid option! Please choose a number between 1 and 4.");
                }
            }
        }

        // Method to get a valid driver choice
        static int GetDriverChoice(string prompt)
        {
            int driverChoice;
            while (true)
            {
                Console.WriteLine(prompt);
                Console.WriteLine("1. Marija");
                Console.WriteLine("2. Greg");
                Console.WriteLine("3. Jill");
                Console.WriteLine("4. Bob");

                if (int.TryParse(Console.ReadLine(), out driverChoice) && driverChoice >= 1 && driverChoice <= 4)
                {
                    return driverChoice;
                }
                else
                {
                    Console.WriteLine("Invalid option! Please choose a number between 1 and 4.");
                }
            }
        }

        // Method to get car object from car choice
        static Car GetCarObject(int carChoice)
        {
            switch (carChoice)
            {
                case 1: return new Car("BMW", 120);
                case 2: return new Car("Toyota", 130);
                case 3: return new Car("Ferrari", 200);
                case 4: return new Car("Porsche", 180);
                default: return null;
            }
        }

        // Method to get driver object from driver choice
        static Driver GetDriverObject(int driverChoice)
        {
            switch (driverChoice)
            {
                case 1: return new Driver("Marija", 5);
                case 2: return new Driver("Greg", 6);
                case 3: return new Driver("Jill", 7);
                case 4: return new Driver("Bob", 8);
                default: return null;
            }
        }

        // Method to handle car no.2 choices with exclusion of car1
        static int GetCarChoiceForSecondCar(int car1Choice)
        {
            int carChoice;
            while (true)
            {
                Console.WriteLine("Please choose a car for Car number 2:\n");
                if (car1Choice == 1) Console.WriteLine("1. Toyota\n2. Ferrari\n3. Porsche");
                if (car1Choice == 2) Console.WriteLine("1. BMW\n2. Ferrari\n3. Porsche");
                if (car1Choice == 3) Console.WriteLine("1. BMW\n2. Toyota\n3. Porsche");
                if (car1Choice == 4) Console.WriteLine("1. BMW\n2. Toyota\n3. Ferrari");

                if (int.TryParse(Console.ReadLine(), out carChoice) && carChoice >= 1 && carChoice <= 3)
                {
                    return carChoice;
                }
                else
                {
                    Console.WriteLine("Invalid option! Please choose a number between 1 and 3.");
                }
            }
        }

        // Method to race the cars and determine the winner
        static void RaceCars(Car car1, Car car2)
        {
            int car1Speed = car1.CalculateSpeed();
            int car2Speed = car2.CalculateSpeed();

            if (car1Speed > car2Speed)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"\nCar number 1 ({car1.Model}) was faster! Speed: {car1Speed} mph. Driver: {car1.CarDriver.Name}");
                Console.ResetColor();
            }
            else if (car2Speed > car1Speed)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"\nCar number 2 ({car2.Model}) was faster! Speed: {car2Speed} mph. Driver: {car2.CarDriver.Name}");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n Both cars hit the same top speed, showing equal power and skill on the track! ");
                Console.ResetColor();
            }
        }
    }
}
