//3.Testing Temperature Converter
//Problem:
//Create a TemperatureConverter class with :
//CelsiusToFahrenheit(double celsius): Converts Celsius to Fahrenheit.
//FahrenheitToCelsius(double fahrenheit): Converts Fahrenheit to Celsius.
//✅ Write unit tests to validate conversions.
using System;
using System.Collections.Generic;
using System.Text;

namespace Advance_Unit_Testing
{
    public class Temperature
    {
        public double CelsiusToFahrenheit(double celsius)
        {
            return ( celsius*9/5)+32 ;
        }

        public double FahrenheittoCelsius(double fahrenheit)
        {
            return (fahrenheit - 32)*5/9;
        }
    }
}
