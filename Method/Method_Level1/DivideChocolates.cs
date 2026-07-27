//10.Create a program to divide N number of chocolates among M children. Print the number of chocolates each child will get and also the remaining chocolates
//Hint => 
//Get an integer value from the user for the numberOfchocolates and numberOfChildren.
//Write the method to find the number of chocolates each child gets and number of remaining chocolates
//public static int[] FindRemainderAndQuotient(int number, int divisor)


using System;
using System.Collections.Generic;
using System.Text;

namespace String
{
    internal class DivideChocolates
    {
        public static void CalculateChocolatesDistribution()
        {
            Console.WriteLine("Enter the number of chocolates:");
            int numberOfChocolates = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of children:");
            int numberOfChildren = Convert.ToInt32(Console.ReadLine());
            int[] result = FindRemainderAndQuotient(numberOfChocolates, numberOfChildren);
            Console.WriteLine($"Each child will get {result[0]} chocolates and there will be {result[1]} remaining chocolates.");
        }
        public static int[] FindRemainderAndQuotient(int numberOfChocolates, int numberOfChildren)
        {
            int chocolatesPerChild = numberOfChocolates / numberOfChildren;
            int remainingChocolates = numberOfChocolates % numberOfChildren;
            return new int[] { chocolatesPerChild, remainingChocolates };
        }
    }
}
