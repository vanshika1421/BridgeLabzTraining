using System;

namespace Unit_testing_examples
{
    public class ExceptionHandling
    {
        public int Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new ArithmeticException("Cannot divide by zero");
            }

            return a / b;
        }
    }
}