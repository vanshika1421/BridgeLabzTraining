using System;
using System.Collections.Generic;
using System.Text;

namespace Method_Level2
{
    internal class FindRoots
    {
        // Method to find and return the roots
        public static double[] FindRoot(double a, double b, double c)
        {
            double delta = Math.Pow(b, 2) - (4 * a * c);

            if (delta > 0)
            {
                double root1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double root2 = (-b - Math.Sqrt(delta)) / (2 * a);

                return new double[] { root1, root2 };
            }
            else if (delta == 0)
            {
                double root = -b / (2 * a);

                return new double[] { root };
            }
            else
            {
                return new double[] { };
            }
        }

        public static void QuadraticEquation()
        {
            Console.Write("Enter value of a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter value of b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter value of c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            if (a == 0)
            {
                Console.WriteLine("Not a quadratic equation.");
                return;
            }

            double[] roots = FindRoot(a, b, c);

            if (roots.Length == 2)
            {
                Console.WriteLine("The roots are:");
                Console.WriteLine("Root 1 = " + roots[0]);
                Console.WriteLine("Root 2 = " + roots[1]);
            }
            else if (roots.Length == 1)
            {
                Console.WriteLine("The root is: " + roots[0]);
            }
            else
            {
                Console.WriteLine("No real roots.");
            }
        }
    }
}