using System;
using System.Collections.Generic;
using System.Text;

namespace Reflection.Basic_Questions
{
    internal class DisplayClassInfo
    {
        int a;
        int b;
        public DisplayClassInfo(int a  , int b)
        {
            this.a = a;
            this.b = b;
        }
        public void Add()
        {
            Console.WriteLine(a + b);
        }
        public void Subtract()
        {
            Console.WriteLine(a - b);
        }
        public void Divide()
        {
            Console.WriteLine(a/b);
        }
        public void remainder()
        {
            Console.WriteLine(a % b);
        }
    }
}
