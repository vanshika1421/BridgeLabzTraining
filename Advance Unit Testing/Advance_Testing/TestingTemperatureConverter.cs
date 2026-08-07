using System;
using System.Collections.Generic;
using System.Text;
using Advance_Unit_Testing;
namespace Advance_Testing
{
    internal class TestingTemperatureConverter
    {
        private Temperature tc;

        [SetUp]
        public void setup()
        {
            tc = new Temperature();
        }
    }
}
