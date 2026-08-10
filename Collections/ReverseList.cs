/*1.Reverse a List
Write a program to reverse the elements of a given list without using built-in reverse methods. Implement it for both ArrayList and LinkedList.
Example:
Input: [1, 2, 3, 4, 5]
Output: [5, 4, 3, 2, 1]
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Collections
{
    internal class ReverseList
    {
       public void Reverse(ArrayList list)
        {
            Console.WriteLine("Implementing ArrayList ");
            for (int i = list.Count-1; i >=0; i--)
            {
                Console.WriteLine(list[i]);
            }

        }
        public void ReverseLinkedList(LinkedList<int> List)
        {
            Console.WriteLine("Implementing LinkedList :");
            LinkedListNode<int> current = List.Last;
            while(current != null) {
                Console.WriteLine(current.Value);
                current = current.Previous;
            }

        }
    }
}
