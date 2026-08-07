//2.Validate a License Plate Number
//License plate format: Starts with two uppercase letters, followed by four digits.
//Example: "AB1234" is valid, but "A12345" is invalid.

using System;
using System.Collections.Generic;
using System.Text;
using regex_code;
namespace Regex_code_testing
{
    internal class License_validation
    {
        private License_validator lv;
        [SetUp]
        public void setUp()
        {
            lv = new License_validator();
        }
        [Test]
        public void testing_License_Validation()
        {
            string str = "AB1234";
            Assert.That(lv.License_validate(str), Is.True);
        }


    }
}
