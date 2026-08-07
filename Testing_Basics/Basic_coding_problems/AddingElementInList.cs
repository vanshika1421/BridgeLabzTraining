//using System.Xml.Linq;

//3.Testing List Operations
//Problem:
//Create a ListManager class that has the following methods:
//AddElement(List<int> list, int element): Adds an element to a list.
//RemoveElement(List<int> list, int element): Removes an element from a list.
//GetSize(List<int> list): Returns the size of the list.

using System;
using System.Collections.Generic;
using System.Text;

namespace Unit_testing_examples
{
    public class AddingElementInList
    {
        public List<int> list = new List<int>();
        public void AddElements(List<int> list, int element)
        {
            list.Add(element);
        }
        public void RemoveElements(List<int> list, int element)
        {
            list.Remove(element);
        }
        public int GetSize(List<int> list)
        {
            return list.Count;
        }

    }
}
