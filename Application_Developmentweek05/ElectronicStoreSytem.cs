using System;
using System.Collections.Generic;

namespace OOP_Workshop
{
    // 1. Abstract Base Class
    public abstract class ElectronicDevice
    {
        // Private fields
        private string brand;
        private double price;

        // Public properties with encapsulation
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        // Constructor
        public ElectronicDevice(string brand, double price)
        {
            this.brand = brand;
            this.price = price;
        }

        // Abstract method
        public abstract void ShowInfo();
    }

    // 2. Derived Classes
    public class Laptop : ElectronicDevice
    {
        public Laptop(string brand, double price) : base(brand, price) { }

        // Extra method
        public void TurnOnBattery()
        {
            Console.WriteLine("Laptop battery is now turned on");
        }

        // Override method
        public override void ShowInfo()
        {
            Console.WriteLine($"Laptop - Brand: {Brand}, Price: ${Price}");
        }
    }

    public class Smartphone : ElectronicDevice
    {
        public Smartphone(string brand, double price) : base(brand, price) { }

        // Extra method
        public void EnableCamera()
        {
            Console.WriteLine("Smartphone camera is now enabled");
        }

        // Override method
        public override void ShowInfo()
        {
            Console.WriteLine($"Smartphone - Brand: {Brand}, Price: ${Price}");
        }
    }

    // 3. Store Class
    public class ElectronicsStore
    {
        private List<ElectronicDevice> devices = new List<ElectronicDevice>();

        public void AddDevice(ElectronicDevice device)
        {
            devices.Add(device);
            Console.WriteLine($"Added device: {device.Brand}");
        }

        public void RemoveDevice(ElectronicDevice device)
        {
            if (devices.Remove(device))
            {
                Console.WriteLine($"Removed device: {device.Brand}");
            }
            else
            {
                Console.WriteLine("Device not found in store");
            }
        }

        public void ShowAllDeviceDetails()
        {
            Console.WriteLine("\n=== All Devices in Store ===");
            foreach (var device in devices)
            {
                device.ShowInfo();

                // Downcast and call child-specific methods
                if (device is Laptop laptop)
                {
                    laptop.TurnOnBattery();
                }
                else if (device is Smartphone smartphone)
                {
                    smartphone.EnableCamera();
                }
                Console.WriteLine("---");
            }
        }
    }
}