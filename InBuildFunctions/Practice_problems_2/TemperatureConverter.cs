using System;

namespace Functions
{
    internal class TemperatureConverter
    {
        public static void Run()
        {
            Console.WriteLine("Temperature Converter");
            Console.WriteLine("1. Celsius to Fahrenheit");
            Console.WriteLine("2. Fahrenheit to Celsius");

            Console.Write("Enter your choice (1 or 2): ");
            int choice = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the temperature: ");
            double temperature = Convert.ToDouble(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    double fahrenheit = CelsiusToFahrenheit(temperature);
                    Console.WriteLine("Temperature in Fahrenheit: " + fahrenheit);
                    break;

                case 2:
                    double celsius = FahrenheitToCelsius(temperature);
                    Console.WriteLine("Temperature in Celsius: " + celsius);
                    break;

                default:
                    Console.WriteLine("Invalid Choice!");
                    break;
            }
        }

        // Method to convert Celsius to Fahrenheit
        public static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        // Method to convert Fahrenheit to Celsius
        public static double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
    }
}