using System;

namespace Functions
{
    internal class BasicCalculator
    {
        public static void Run()
        {
            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nChoose an operation:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");

            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Result = " + Add(num1, num2));
                    break;

                case 2:
                    Console.WriteLine("Result = " + Subtract(num1, num2));
                    break;

                case 3:
                    Console.WriteLine("Result = " + Multiply(num1, num2));
                    break;

                case 4:
                    if (num2 == 0)
                    {
                        Console.WriteLine("Division by zero is not possible.");
                    }
                    else
                    {
                        Console.WriteLine("Result = " + Divide(num1, num2));
                    }
                    break;

                default:
                    Console.WriteLine("Invalid Choice!");
                    break;
            }
        }

        // Method for addition
        public static double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        // Method for subtraction
        public static double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }

        // Method for multiplication
        public static double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }

        // Method for division
        public static double Divide(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}