using System;

namespace OOP_Workshop
{
    // Abstract class
    public abstract class Vehicle2
    {
        // Abstract methods
        public abstract void StartEngine();
        public abstract void StopEngine();

        // Concrete method
        public void Display()
        {
            Console.WriteLine("This is a vehicle");
        }
    }

    // Derived class Car
    public class Car2 : Vehicle2
    {
        public override void StartEngine()
        {
            Console.WriteLine("Car engine started with key ignition");
        }

        public override void StopEngine()
        {
            Console.WriteLine("Car engine stopped");
        }
    }

    // Derived class Bike
    public class Bike : Vehicle2
    {
        public override void StartEngine()
        {
            Console.WriteLine("Bike engine started with kick start");
        }

        public override void StopEngine()
        {
            Console.WriteLine("Bike engine stopped using kill switch");
        }
    }
}