//using System.Runtime.Intrinsics.X86;

//Implement a Queue Using Stacks
//Problem: Design a queue using two stacks such that enqueue and dequeue operations are performed efficiently.
//Hint: Use one stack for enqueue and another stack for dequeue. Transfer elements between stacks as needed.


using System;
using System.Collections.Generic;
using System.Text;

namespace Queue
{
    internal class ImplementQueue
    {
        Stack<int> stack1 = new Stack<int>();
        Stack<int> stack2 = new Stack<int>();
        public void Enqueue(int value)
        {
            stack1.Push(value);
        }

        public int Dequeue()
        {
            if (stack1.Count == 0 && stack2.Count == 0)
            {
                throw new InvalidOperationException("Queue is empty");
            }

            if (stack2.Count == 0)
            {
                while (stack1.Count > 0)
                {
                    stack2.Push(stack1.Pop());
                }
            }
            return stack2.Pop();
        }

        public int Peek()
        {
            if (stack1.Count == 0 && stack2.Count == 0)
            {
                throw new InvalidOperationException("Queue is Empty");
            }
            if (stack2.Count == 0)
            {
                while (stack1.Count > 0)
                {
                    stack2.Push(stack1.Pop());
                }
            }
            return stack2.Peek();
        }
        public bool isEmpty()
        {
            return stack1.Count==0 && stack2.Count==0;
        }

    }
}

