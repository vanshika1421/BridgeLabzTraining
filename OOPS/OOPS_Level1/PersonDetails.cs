//Person Class(Copy Constructor)
//Create a Person class with a copy constructor that clones another person's attributes.

using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS
{
    internal class PersonDetails
    {
        String name;
        int age;
        char gender;
      public  PersonDetails(String name, int age, char gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
        }
        public PersonDetails(PersonDetails person)
        {
            name = person.name;
            age = person.age;
            gender = person.gender;
        }
        public void Display()
        {
            Console.WriteLine($"Name is {name} ");
            Console.WriteLine($"age is {age} ");
            Console.WriteLine($"Gener is {gender}");
        }
    }
}
