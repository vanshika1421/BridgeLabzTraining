//Sample Problem 2: Smart Home Devices
//○ Description: Create a hierarchy for a smart home system where Device is the
//superclass and Thermostat is a subclass.
//○ Tasks:
//■ Define a superclass Device with attributes like DeviceId and Status.
//■ Create a subclass Thermostat with additional attributes like
//TemperatureSetting.
//■ Implement a method DisplayStatus() to show each device's current
//settings.
//○ Goal: Understand single inheritance by adding specific attributes to a subclass,
//keeping the superclass general.

using System;

namespace SmartHomeSystem
{
    // Base Class
    internal class Device
    {
        public int DeviceId { get; set; }
        public string Status { get; set; }

        public Device(int deviceId, string status)
        {
            DeviceId = deviceId;
            Status = status;
        }

        public virtual void DisplayStatus()
        {
            Console.WriteLine($"Device ID : {DeviceId}");
            Console.WriteLine($"Status    : {Status}");
        }
    }

    // Derived Class
    internal class Thermostat : Device
    {
        public double TemperatureSetting { get; set; }

        public Thermostat(int deviceId, string status, double temperatureSetting)
            : base(deviceId, status)
        {
            TemperatureSetting = temperatureSetting;
        }

        public override void DisplayStatus()
        {
            base.DisplayStatus();
            Console.WriteLine($"Temperature Setting : {TemperatureSetting}°C");
        }
    }

    // Program Class
}