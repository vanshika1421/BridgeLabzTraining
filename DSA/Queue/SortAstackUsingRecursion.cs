//Sort a Stack Using Recursion
//Problem: Given a stack, sort its elements in ascending order using recursion.
//Hint: Pop elements recursively, sort the remaining stack, and insert the popped element back at the correct position.


using System;
using System.Collections.Generic;
using System.Text;

namespace Queue
{
    internal class SortAstackUsingRecursion
    {
       Stack<int> stack = new Stack<int>();
        public void Sort(Stack<int> stack)
        {
            if(stack.Count == 0)
            {
                return;
            }
            int val = stack.Pop();
            Sort(stack);
            InsertSorted(stack, val);

        }
        public void InsertSorted(Stack<int> stack, int val)
        {
            if(stack.Count ==0 || stack.Peek() > val)
            {
                stack.Push(val);
                return;
            }
            int temp = stack.Pop();
            InsertSorted(stack, val);
            stack.Push(temp);

        }
    }
}
