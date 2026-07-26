//Create a program to find the bonus of 10 employees based on their years of service and the total bonus amount the company Zara has to pay, along with the old and new salary.
//Hint => 
//Zara decides to give a bonus of 5% to employees whose year of service is more than 5 years or 2% if less than 5 years
//Define a double array to save salary and years of service for each of the 10 employees
//Also define a double array to save the new salary and the bonus amount as well as variables to save the total bonus, total old salary, and new salary
//Define a loop to take input from the user. If salary or year of service is an invalid number then ask the user to enter again. Note in this case you will have to decrement the index counter
//Define another loop to calculate the bonus of 10 employees based on their years of service. Save the bonus in the array, compute the new salary, and save in the array. Also, the total bonus and total old and new salary can be calculated in the loop
//Print the total bonus payout as well as the total old and new salary of all the employees

using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays2
{
    internal class BonusCalculation
    { 
        public static void BonusCalculationMethod()
        {
            double[] salary = new double[10];
            double[] yearOfService = new double[10];
            double totalBonus = 0;
            double totalOldSalary = 0;
            double totalNewSalary = 0;
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter the salary of employee " + (i + 1) + ": ");
                salary[i] = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the years of service of employee " + (i + 1) + ": ");
                yearOfService[i] = double.Parse(Console.ReadLine());
                


            }
            double[] bonus = new double[10];
            double[] newSalary = new double[10];
            for(int i = 0;i < 10; i++)
            {
                if (yearOfService[i] > 5)
                {
                    bonus[i] = salary[i] * 0.05;
                }
                else
                {
                    bonus[i] = salary[i] * 0.02;
                }
                newSalary[i] = salary[i] + bonus[i];
                totalBonus += bonus[i];
                totalOldSalary += salary[i];
                totalNewSalary += newSalary[i];
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Employee " + (i + 1) + ": Old Salary: " + salary[i] + ", Bonus: " + bonus[i] + ", New Salary: " + newSalary[i]);
            }
            Console.WriteLine("Total Bonus Payout: " + totalBonus);
            Console.WriteLine("Total Old Salary: " + totalOldSalary);
            Console.WriteLine("Total New Salary: " + totalNewSalary);

        }
    }
}
