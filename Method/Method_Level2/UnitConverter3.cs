//6.Extend or Create a UnitConvertor utility class similar to the one shown in the notes to do the following.  Please define static methods for all the UnitConvertor class methods. E.g.
//public static double convertFarhenheitToCelsius(double farhenheit) =>
//a.Method to convert Fahrenheit to Celsius and return the value. Use the following code  double farhenheit2celsius = (farhenheit - 32) * 5 / 9;
//b.Method to convert Celsius to Fahrenheit and return the value. Use the following code  double celsius2farhenheit = (celsius * 9 / 5) + 32;
//c.Method to convert pounds to kilograms and return the value. Use the following code  double pounds2kilograms = 0.453592;
//d.Method to convert kilograms to pounds and return the value. Use the following code  double kilograms2pounds = 2.20462; 
//e.Method to convert gallons to liters and return the value. Use following code to convert   double gallons2liters = 3.78541;
//f.Method to convert liters to gallons and return the value. Use following code to convert  double liters2gallons = 0.264172; 


using System;
using System.Collections.Generic;
using System.Text;

namespace Method_Level2
{
    internal class UnitConverter3
    {
        public static double ConvertFahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
        public static double ConvertCelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }
        public static double ConvertPoundsToKilograms(double pounds)
        {
            return pounds * 0.453592;
        }
        public static double ConvertKilogramsToPounds(double kilograms)
        {
            return kilograms * 2.20462;
        }
        public static double ConvertGallonsToLiters(double gallons)
        {
            return gallons * 3.78541;
        }
        public static double ConvertLitersToGallons(double liters)
        {
            return liters * 0.264172;
        }
        public static void DisplayResults(double fahrenheit, double celsius, double pounds, double kilograms, double gallons , double liters)
        {
            Console.WriteLine($"{fahrenheit} Fahrenheit is equal to {ConvertFahrenheitToCelsius(fahrenheit)} Celsius.");
            Console.WriteLine($"{celsius} Celsius is equal to {ConvertCelsiusToFahrenheit(celsius)} Fahrenheit.");
            Console.WriteLine($"{pounds} pounds is equal to {ConvertPoundsToKilograms(pounds)} kilograms.");
            Console.WriteLine($"{kilograms} kilograms is equal to {ConvertKilogramsToPounds(kilograms)} pounds.");
            Console.WriteLine($"{gallons} gallons is equal to {ConvertGallonsToLiters(gallons)} liters.");
            Console.WriteLine($"{liters} liters is equal to {ConvertLitersToGallons(liters)} gallons.");


        }
    }
}
