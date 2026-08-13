using System;
namespace Queue
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //ImplementQueue queue = new ImplementQueue();

            //queue.Enqueue(10);
            //queue.Enqueue(20);
            //queue.Enqueue(30);

            //Console.WriteLine(queue.Peek());
            //Console.WriteLine(queue.Dequeue());
            //Console.WriteLine(queue.Dequeue());
            //Console.WriteLine(queue.Peek());
            //Console.WriteLine(queue.isEmpty());

            //Console.WriteLine(queue.Dequeue());


            Stack<int> stack = new Stack<int>();

            stack.Push(2);
            stack.Push(4);
            stack.Push(1);
            stack.Push(3);

            SortAstackUsingRecursion obj = new SortAstackUsingRecursion();

            obj.Sort(stack);

            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }
        }
    }
}