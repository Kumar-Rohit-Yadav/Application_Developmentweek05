using System;

namespace OOP_Workshop
{
    // Base class
    public class Vehicle
    {
        public string Brand { get; set; }
        public double Speed { get; set; }

        public Vehicle(string brand, double speed)
        {
            Brand = brand;
            Speed = speed;
        }

        public void Start()
        {
            Console.WriteLine($"{Brand} is starting...");
        }

        public void Stop()
        {
            Console.WriteLine($"{Brand} is stopping...");
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Brand: {Brand}, Speed: {Speed} km/h");
        }
    }

    // Derived class Car
    public class Car : Vehicle
    {
        public int Seats { get; set; }

        public Car(string brand, double speed, int seats) : base(brand, speed)
        {
            Seats = seats;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Type: Car, Seats: {Seats}");
        }
    }

    // Derived class Motorcycle
    public class Motorcycle : Vehicle
    {
        public bool HasSidecar { get; set; }

        public Motorcycle(string brand, double speed, bool hasSidecar) : base(brand, speed)
        {
            HasSidecar = hasSidecar;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Type: Motorcycle, Has Sidecar: {HasSidecar}");
        }
    }
}