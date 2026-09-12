using System;
using System.Collections.Generic;
using System.Text;

namespace BirdSentury
{
    internal class Penguin : Bird , ISwimable  , IRunable
    {
        
        public Penguin(string name, int age , string species , int id , Gender gender)
        : base(name, age, "Duck" , id , gender)
        {
        }

        public void Fly()
        {
            Console.WriteLine("Penguin is flying.");
        }

        public void swim()
        {
            Console.WriteLine("Penguin is swimming.");
        }

        public void Run()
        {
            Console.WriteLine("Penguin is running.");
        }
    }
    }

