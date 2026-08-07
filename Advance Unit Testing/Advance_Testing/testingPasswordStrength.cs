using Advance_Testing;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Text;
using Advance_Unit_Testing;
//2.Testing Password Strength Validator
//Problem:
//Create a PasswordValidator class with :
//Passwords must have at least 8 characters, one uppercase letter, and one digit.
//✅ Write unit tests for valid and invalid passwords.

namespace Advance_Testing
{
    internal class testingPasswordStrength
    {
        private PasswordStrength ps;

        [SetUp]
        public void setup()
        {
            ps = new PasswordStrength();
        }

        [Test]
        public void checking_password_Validation()
        {
            string str = "Vanshika21";
            bool res = ps.PasswordCheck(str);
            Assert.That(res, Is.True);
        }

    }
}
