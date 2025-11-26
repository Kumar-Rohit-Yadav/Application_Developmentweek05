using System;

namespace OOP_Workshop
{
    // Part A: Method Overloading
    public class Printer
    {
        // Overloaded methods
        public void Print(string message)
        {
            Console.WriteLine($"Printing message: {message}");
        }

        public void Print(int number)
        {
            Console.WriteLine($"Printing number: {number}");
        }

        public void Print(string message, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"{i + 1}. {message}");
            }
        }
    }

    // Part B: Method Overriding
    public class Teacher
    {
        public string Name { get; set; }

        public Teacher(string name)
        {
            Name = name;
        }

        public virtual void Teaching()
        {
            Console.WriteLine("Teacher teaches in English");
        }

        public sealed void SalaryInfo()
        {
            Console.WriteLine("Salary information is confidential");
        }
    }

    public class NepaliTeacher : Teacher
    {
        public NepaliTeacher(string name) : base(name) { }

        public override void Teaching()
        {
            Console.WriteLine($"{Name} teaches in Nepali");
        }
    }

    public class EnglishTeacher : Teacher
    {
        public EnglishTeacher(string name) : base(name) { }

        // Not overriding Teaching() method - using base implementation
    }
}