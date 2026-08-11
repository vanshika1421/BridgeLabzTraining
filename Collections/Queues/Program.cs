namespace Queuess
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Queue<int> q = new Queue<int>();

            //q.Enqueue(1);
            //q.Enqueue(2);
            //q.Enqueue(3);
            //q.Enqueue(4);
            //q.Enqueue(5);
            //ReverseQueue rq = new ReverseQueue();
            //rq.ReverseQueueMethod(q);
            //foreach (int i in q)
            //{
            //    Console.WriteLine(i);
            //GenerateBinaryNumbers gbn = new GenerateBinaryNumbers();
            //gbn.GeneratingBinaryNumber(5);
            PriorityQueue<string , int> pq = new PriorityQueue<string, int>();
            pq.Enqueue("Vanshika", -101);
            pq.Enqueue("Simran", -852);
            pq.Enqueue("Shivaay", -897);
            HospitalTriageSystem hts = new HospitalTriageSystem();
            hts.TriageSystem(pq);
        }
        }
}