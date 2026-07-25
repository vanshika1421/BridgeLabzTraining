using System;
using System.Collections.Generic;
using System.Text;


//5.Write a TemperatureConversion program, given the temperature in
//Fahrenheit as input that outputs the temperature in Celsius
//Hint:
//Create a fahrenheit variable and take the user's input.
//Use the formula: Fahrenheit to Celsius: (°F − 32) x 5/9 = °C
//Assign the result to celsiusResult and print the result.
//I/P => fahrenheit
//O/P => The ___ Fahrenheit is ___ Celsius

namespace Basic_Programs_Level2
{
    internal class TemperatureConversion2
    {
        public static void TemperatureConversionFtoC()
        {
            Console.WriteLine("Enter temperature in Farenheit: ");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());
            double celsiusResult = fahrenheit - 32 * 5 / 9;
            Console.WriteLine($"The {fahrenheit} Fahrenheit is {celsiusResult} Celsius");

        }
    }
}
