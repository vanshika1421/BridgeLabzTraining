using System;
using System.Collections.Generic;
using System.Text;

namespace Unit_testing_examples
{
    public class EvenOdd
    {
        public int CheckEven(int n)
        {
            if (n % 2 == 0)
            {
                return 1;

            }
            else
            {
                return 0;

            }
        }
        public int CheckOdd(int n)
        {
            if (n % 2 != 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
