//Queue Interface Problems
//1. Reverse a Queue
//Reverse the elements of a queue using only queue operations.
//Example:
//Input: [10, 20, 30]
//Output: [30, 20, 10]

using System;
using System.Collections.Generic;
using System.Text;

namespace Queuess
{
    internal class ReverseQueue
    {
        public void ReverseQueueMethod(Queue<int> Q) //1 2 3 4 5 
        {
            if (Q.Count == 0)
            {
                return;
            }

            int value = Q.Dequeue();//FrontValue  //1 2 3 4 5 

            ReverseQueueMethod(Q);

            Q.Enqueue(value); //5 4 3 2 1

        }
    }
}
