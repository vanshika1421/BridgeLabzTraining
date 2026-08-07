using System;
using System.Collections.Generic;
using System.Text;

namespace Unit_testing_examples
{
    public class Palindrome
    {
        public bool isPalindrome(string str)
        {
            int left = 0;
            int right = str.Length - 1;
            while (left < right)
            {
                if (str[left] != str[right])
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;    
        }
    }
}
