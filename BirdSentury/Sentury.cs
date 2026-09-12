using System;
using System.Collections.Generic;
using System.Text;

namespace BirdSentury
{
    internal class Sentury
    {
        private HashSet<Bird> birds = new HashSet<Bird>();

        public void AddBird(Bird bird)
        {
            birds.Add(bird);
            
        }

        public void CountBirds(String species)
        {
            int Count = 0;   

            foreach (var bird in birds)
            {
                if (bird.species == species)
                    Count++;

            }

            Console.WriteLine($"{species} count is {Count}");
        }
        public void RemoveBird(int id)
        {
            foreach (var bird in birds)
            {
               
                    if (bird.Id == id)
                    {
                        birds.Remove(bird);
                    }
                
            }
            Console.WriteLine("Removed Successfully!");
        }
    }
}
