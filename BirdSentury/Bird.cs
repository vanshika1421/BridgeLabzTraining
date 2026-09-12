using System;
using System.Collections.Generic;
using System.Text;

namespace BirdSentury
{
    enum Gender
    {
        MALE,
        FEMALE
    }


    internal abstract class Bird
    {
        public String Name { get; set; }
        public int age { get; set; }
        public string species { get; set; }
        public int Id { get; set; }
        public Gender Gender { get; set; }
        public Bird(){
            
        }
        public Bird( int Id, Gender gender)
        {
         
            this.Id = Id;
            Gender = gender;
        }
        public override bool Equals(object? obj)
        {
            if (obj is not Bird other)
                return false;

            return Id == other.Id;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
     
    }
}
