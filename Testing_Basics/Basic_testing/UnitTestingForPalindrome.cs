using System;
using System.Collections.Generic;
using System.Text;
using Unit_testing_examples;
namespace TestProject1
{
    public class UnitTestingForPalindrome
    {
        private Palindrome palindrome;

        [SetUp]
        public void setUp()
        {
            palindrome = new Palindrome();
        }
        [Test]
        public void check_if_The_String_is_Palindrome()
        {
            string str = "abccba";
            bool ans = palindrome.isPalindrome(str);
            bool res = true;
            Assert.That(res, Is.True);
        }

    }
}
