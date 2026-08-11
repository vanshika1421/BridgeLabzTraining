//2.Generate Binary Numbers Using a Queue
//Generate the first N binary numbers using a queue.
//Example:
//Input: N = 5
//Output: { "1", "10", "11", "100", "101"}


using System;
using System.Collections.Generic;
using System.Text;

namespace Queuess
{
    internal class GenerateBinaryNumbers
    {
        public void GeneratingBinaryNumber(int n)
        {
            Queue<String> q = new Queue<String>();
            q.Enqueue("1");
            for (int i = 0; i < n; i++)
            {
                string curr = q.Dequeue();
                Console.Write(curr+" ");
                q.Enqueue(curr+"0");
                q.Enqueue(curr+"1");
            }
        }
    }
}
