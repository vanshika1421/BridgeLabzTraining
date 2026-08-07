using System;
using System.Collections.Generic;
using System.Text;
using Unit_testing_examples;

namespace TestProject1
{
    internal class ExceptionHandlingTesting
    {
        private ExceptionHandling e;
        [SetUp]
        public void setUp()
        {
            e = new ExceptionHandling();
        }
        [TestCase(10 , 2 , 5)]
        public void Testing_Exception_Handling()
        {
            //int a = 10;
            //int b = 0;
            Assert.Throws<ArithmeticException>(() =>
            {
                
            });
        }
    }
}
