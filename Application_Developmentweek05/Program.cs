using System;

namespace OOP_Workshop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== OOP WORKSHOP - ALL TASKS ===\n");

            // Run Task 1
            RunTask1();

            // Run Task 2
            RunTask2();

            // Run Task 3
            RunTask3();

            // Run Task 4
            RunTask4();

            // Run Task 5
            RunTask5();

            Console.WriteLine("\n=== ALL TASKS COMPLETED ===");
            Console.ReadLine();
        }

        static void RunTask1()
        {
            Console.WriteLine("\n" + new string('=', 50));
            Console.WriteLine("TASK 1: ENCAPSULATION - BANK ACCOUNT");
            Console.WriteLine(new string('=', 50));

            // Create bank account object
            BankAccount myAccount = new BankAccount("123456789", 1000.0);

            // Display account number
            Console.WriteLine($"Account Number: {myAccount.AccountNumber}");
            Console.WriteLine($"Initial Balance: ${myAccount.Balance}");

            // Perform transactions
            myAccount.Deposit(500.0);
            myAccount.Withdraw(200.0);
            myAccount.Withdraw(1500.0); // This should show insufficient funds

            // Print remaining balance
            Console.WriteLine($"Final Balance: ${myAccount.Balance}");
        }

        static void RunTask2()
        {
            Console.WriteLine("\n" + new string('=', 50));
            Console.WriteLine("TASK 2: INHERITANCE - VEHICLE SYSTEM");
            Console.WriteLine(new string('=', 50));

            // Create objects of derived classes
            Car myCar = new Car("Toyota", 180.0, 5);
            Motorcycle myMotorcycle = new Motorcycle("Honda", 120.0, false);

            // Demonstrate code reusability
            Console.WriteLine("=== Car Operations ===");
            myCar.Start();
            myCar.DisplayInfo();
            myCar.Stop();

            Console.WriteLine("\n=== Motorcycle Operations ===");
            myMotorcycle.Start();
            myMotorcycle.DisplayInfo();
            myMotorcycle.Stop();
        }

        static void RunTask3()
        {
            Console.WriteLine("\n" + new string('=', 50));
            Console.WriteLine("TASK 3: POLYMORPHISM");
            Console.WriteLine(new string('=', 50));

            RunTask3A(); // Method Overloading
            RunTask3B(); // Method Overriding
        }

        static void RunTask3A()
        {
            Console.WriteLine("\n--- Part A: Method Overloading ---");
            Printer printer = new Printer();

            // Call all overloaded methods
            printer.Print("Hello World");
            printer.Print(42);
            printer.Print("Repeat", 3);
        }

        static void RunTask3B()
        {
            Console.WriteLine("\n--- Part B: Method Overriding ---");

            // Create objects of derived classes
            NepaliTeacher nepaliTeacher = new NepaliTeacher("Ram Shrestha");
            EnglishTeacher englishTeacher = new EnglishTeacher("John Smith");

            Console.WriteLine("=== Nepali Teacher ===");
            nepaliTeacher.Teaching();
            nepaliTeacher.SalaryInfo();

            Console.WriteLine("\n=== English Teacher ===");
            englishTeacher.Teaching(); // Uses base implementation
            englishTeacher.SalaryInfo();
        }

        static void RunTask4()
        {
            Console.WriteLine("\n" + new string('=', 50));
            Console.WriteLine("TASK 4: ABSTRACTION - VEHICLE SYSTEM");
            Console.WriteLine(new string('=', 50));

            // Create objects of both derived classes
            Car2 car = new Car2();
            Bike bike = new Bike();

            Console.WriteLine("=== Car Operations ===");
            car.Display();
            car.StartEngine();
            car.StopEngine();

            Console.WriteLine("\n=== Bike Operations ===");
            bike.Display();
            bike.StartEngine();
            bike.StopEngine();
        }

        static void RunTask5()
        {
            Console.WriteLine("\n" + new string('=', 50));
            Console.WriteLine("TASK 5: COMPLETE OOP SYSTEM - ELECTRONICS STORE");
            Console.WriteLine(new string('=', 50));

            // Create ElectronicsStore object
            ElectronicsStore store = new ElectronicsStore();

            // Create Laptop and Smartphone objects
            Laptop laptop = new Laptop("Dell", 1200.0);
            Smartphone smartphone = new Smartphone("Samsung", 800.0);
            Laptop laptop2 = new Laptop("Apple", 2000.0);

            // Add them to the store
            store.AddDevice(laptop);
            store.AddDevice(smartphone);
            store.AddDevice(laptop2);

            // Display all device details and child-specific behavior
            store.ShowAllDeviceDetails();

            // Demonstrate removal
            Console.WriteLine("\n=== After Removal ===");
            store.RemoveDevice(laptop2);
            store.ShowAllDeviceDetails();
        }
    }
}