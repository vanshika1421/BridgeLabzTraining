//10.Create a program to divide N number of chocolates among M children.
//Hint:
//Get an integer value from the user for numberOfChocolates and
//numberOfChildren.
//Find the number of chocolates each child gets and the number of remaining
//chocolates.
//Display the results.
//I/P => numberOfChocolates, numberOfChildren
//O/P => The number of chocolates each child gets is ___ and the number of
//remaining chocolates is ___
using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_Programs_Level2
{
    internal class DivideChocolates
    {
        public static void DivideChocolatesAmongChildren()
        {
            Console.WriteLine("Enter the number of chocolates: ");
            int numberOfChocolates = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of children: ");
            int numberOfChildren = Convert.ToInt32(Console.ReadLine());
            int chocolatesPerChild = numberOfChocolates / numberOfChildren;
            int remainingChocolates = numberOfChocolates % numberOfChildren;
            Console.WriteLine($"The number of chocolates each child gets is {chocolatesPerChild} and the number of remaining chocolates is {remainingChocolates}");
        }
    }
}
