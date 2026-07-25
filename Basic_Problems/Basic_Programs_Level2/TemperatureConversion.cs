using System;
using System.Collections.Generic;
using System.Text;

//4.Write a TemperatureConversion program, given the temperature in Celsius
//as input that outputs the temperature in Fahrenheit
//Hint:
//Create a celsius variable and take the temperature as user input.
//Use the formula: Celsius to Fahrenheit: (°C × 9/5) + 32 = °F
//Assign the result to fahrenheitResult and print the result.
//I/P => celsius
//O/P => The ___ Celsius is ___ Fahrenheit

namespace Basic_Programs_Level2
{
    internal class TemperatureConversion
    {
        public static void ConvertTemperature()
        {
            Console.WriteLine("Enter the temperature in Celsius: ");
            double celsius = Convert.ToDouble(Console.ReadLine());
            double fahrenheitResult = (celsius * 9 / 5) + 32;
            Console.WriteLine($"The {celsius} Celsius is {fahrenheitResult} Fahrenheit");
        }
    }
}
