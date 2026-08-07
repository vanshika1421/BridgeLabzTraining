using System;
using System.Collections.Generic;
using System.Text;
using Unit_testing_examples;

namespace TestProject1
{
    internal class UpperCaseTesting
    {
        private UpperCaseConversion upperCase;


        [SetUp]
        public void setUp()
        {
            upperCase = new UpperCaseConversion();
        }

        [Test]
        public void check_if_the_method_converts_string_to_uppercase()
        {
            string str = "hello";
            string ans = upperCase.ToUpperCase(str);
            string res = "HELLO";
            Assert.That(res, Is.EqualTo(ans));
        }

    }
}
