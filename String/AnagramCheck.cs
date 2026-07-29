using System;

namespace String
{
    internal class AnagramCheck
    {
        public static void CheckAnagram()
        {
            Console.Write("Enter first string: ");
            string s1 = Console.ReadLine() ?? "";

            Console.Write("Enter second string: ");
            string s2 = Console.ReadLine() ?? "";

            char[] arr1 = s1.ToLower().ToCharArray();
            char[] arr2 = s2.ToLower().ToCharArray();

            Array.Sort(arr1);
            Array.Sort(arr2);

            string sorted1 = new string(arr1);
            string sorted2 = new string(arr2);

            if (sorted1.Equals(sorted2))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}