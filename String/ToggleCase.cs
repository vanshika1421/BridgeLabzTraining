using System;
using System.Text;

namespace String
{
    internal class ToggleCase
    {
        public static void ToggleCaseMethod()
        {
            Console.WriteLine("Enter String");
            string s = Console.ReadLine() ?? "";

            StringBuilder sb = new StringBuilder(s);

            for (int i = 0; i < sb.Length; i++)
            {
                if (char.IsUpper(sb[i]))
                {
                    sb[i] = char.ToLower(sb[i]);
                }
                else if (char.IsLower(sb[i]))
                {
                    sb[i] = char.ToUpper(sb[i]);
                }
            }

            Console.WriteLine("Toggled String: " + sb.ToString());
        }
    }
}