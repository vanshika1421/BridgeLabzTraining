//Reverse(string str): Returns the reverse of a given string.

using System;
using System.Collections.Generic;
using System.Text;
using Unit_testing_examples;

namespace TestProject1
{
    internal class ReverseStringTesting
    {
        private ReverseString reverse;

        [SetUp]
        public void setUp()
        {
            reverse = new ReverseString();

        }

        [Test]
        public void check_if_the_string_is_reversed()
        {
            string str = "Hello";
            string ans = reverse.Reverse(str);
            string res = "olleH";
            Assert.That(res, Is.EqualTo(ans));
        }

    }
}
