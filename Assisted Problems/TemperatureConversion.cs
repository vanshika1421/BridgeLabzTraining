//3.Celsius to Fahrenheit Conversion
//Write a program that takes the temperature in Celsius as input and converts
//it to Fahrenheit using the formula:
//Fahrenheit = (Celsius * 9 / 5) + 32.
using System;
using System.Collections.Generic;
using System.Text;

namespace Assisted_Problems
{
    internal class TemperatureConversion
    {
        public static void TempratureConversion()
        {
            Console.WriteLine("Enter temperature in Celsius: ");
            double celsius = double.Parse(Console.ReadLine());
            double fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine("Temperature in Fahrenheit is: {0}", fahrenheit);
        }
    }
}
