using System;
using System.Collections.Generic;
using System.Text;

namespace BirdSentury
{
    internal class Eagle : Bird , IRunable , IFlyable
    {
        public Eagle(string name, int age , string species ,  int id , Gender gender)
      : base(name, age, "Eagle" , id , gender)
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
