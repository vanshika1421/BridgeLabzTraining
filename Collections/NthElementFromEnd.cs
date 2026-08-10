//5.Find the Nth Element from the End
//Given a singly linked list (LinkedList), find the Nth element from the end without calculating its size.
//Example:
//Input: [A, B, C, D, E], N = 2
//Output: D


using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    internal class NthElementFromEnd
    {
        public void NthElement(LinkedList<String> list , int n)
        {
             LinkedListNode<string> first = list.First;
            LinkedListNode<string> second = list.First;
            for(int i = 0; i < n; i++)
            {
                if (first == null)
                {
                    throw new ArgumentNullException("Invalid N");
                }
                first = first.Next;
            }
            while (first!= null)
            {
                first = first.Next;
                second = second.Next;
            }
            Console.WriteLine($"Nth element from last is {second.Value}");
        }
    }
}
