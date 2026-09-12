using System;
using System.Collections.Generic;
using System.Text;

namespace BirdSentury
{
    internal class Eagle : Bird , IRunable , IFlyable
    {
        public Eagle( int id , Gender gender)
      : base( id , gender)
        {
        }

        public void Fly()
        {
            Console.WriteLine("Eagle is flying.");
        }

        public void Run()
        {
            Console.WriteLine("Eagle is running.");
        }
    }
}
