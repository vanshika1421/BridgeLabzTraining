//using static System.Net.Mime.MediaTypeNames;

//8.Ride - Hailing Application
//Description: Develop a ride - hailing application.
//Abstract Class:
//Define an abstract class Vehicle with fields: vehicleId, driverName, and ratePerKm.
//Add an abstract method CalculateFare(double distance).
//Implement a concrete method GetVehicleDetails().
//Subclasses:
//Extend Vehicle into Car, Bike, and Auto.
//Override CalculateFare() based on type-specific rates.
//Interface:
//Implement an interface IGPS.
//Define methods GetCurrentLocation() and UpdateLocation().
//Encapsulation:
//Secure driver and vehicle details using private fields and properties.
//Polymorphism:
//Create a method that processes multiple vehicle types dynamically.
//Calculate fares based on the Vehicle reference.

using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation
{
    internal abstract class Vehicle
    {
        public int vehicleId { get; private set; }
        public string driverName { get; private set; } = string.Empty;
        public double ratePerKm { get; private set; }
        public Vehicle(int vehicleId, string driverName, double ratePerKm)
        {
            this.vehicleId = vehicleId;
            this.driverName = driverName;
            this.ratePerKm = ratePerKm;
        }
        public abstract double CalculateFare(double distance);
        public void GetVehicleDetails()
        {
            Console.WriteLine($"Vehicle ID: {vehicleId}");
            Console.WriteLine($"Driver Name: {driverName}");
            Console.WriteLine($"Rate per Km: {ratePerKm}");
        }
    }
    internal class Car : Vehicle, IGPS
    {
        public Car(int vehicleId, string driverName, double ratePerKm) : base(vehicleId, driverName, ratePerKm)
        {
        }
        public override double CalculateFare(double distance)
        {
            return distance * ratePerKm;
        }
        public string GetCurrentLocation()
        {
            return "Current location of the car.";
        }
        public void UpdateLocation()
        {
            Console.WriteLine("Car location updated.");
        }
    }
    internal class Bike : Vehicle, IGPS
    {
        public Bike(int vehicleId, string driverName, double ratePerKm) : base(vehicleId, driverName, ratePerKm)
        {
        }
        public override double CalculateFare(double distance)
        {
            return distance * ratePerKm * 0.8; // Bikes have a 20% discount on fare
        }
        public string GetCurrentLocation()
        {
            return "Current location of the bike.";
        }
        public void UpdateLocation()
        {
            Console.WriteLine("Bike location updated.");
        }
    }
    internal class Auto : Vehicle, IGPS
    {
        public Auto(int vehicleId, string driverName, double ratePerKm) : base(vehicleId, driverName, ratePerKm)
        {
        }
        public override double CalculateFare(double distance)
        {
            return distance * ratePerKm * 1.2; // Autos have a 20% surcharge on fare
        }
        public string GetCurrentLocation()
        {
            return "Current location of the auto.";
        }
        public void UpdateLocation()
        {
            Console.WriteLine("Auto location updated.");
        }
    }
    internal interface IGPS
    {
        string GetCurrentLocation();
        void UpdateLocation();
    }
}
