using System.Collections;

namespace Collections
{
    public class Program
    {
        public static void Main(String[] args)
        {

            //ArrayList list = new ArrayList();
            //LinkedList<int> LinkedList = new LinkedList<int>();
            //Console.WriteLine("Enter the number of elements");
            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Enter {n} elements");
            //for(int i = 0; i < n; i++)
            //{
            //    int value = int.Parse(Console.ReadLine());
            //    list.Add(value);
            //    LinkedList.AddLast(value);
            //}
            //ReverseList rv = new ReverseList();
            //rv.Reverse(list);
            //ReverseList ll = new ReverseList();
            //ll.ReverseLinkedList(LinkedList);
            //List<String> list = new List<String>();
            //Console.WriteLine("Enter number of elements : ");
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 0; i < n; i++)
            //{
            //    list.Add(Console.ReadLine());
            //}
            //Frequency frequency = new Frequency();
            //Dictionary<string, int> result = frequency.frequencyCal(list);
            //foreach (var i in result)
            //{
            //    Console.WriteLine(i);

            //}
            //List<int> list = new List<int>();
            //Console.WriteLine("Enter number of elements : ");
            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Enter {n} elements");
            //for (int i = 0; i < n; i++)
            //{
            //    list.Add(int.Parse(Console.ReadLine()));
            //}
            //RotateList rl = new RotateList();
            //rl.rotate(list);
            
            //RemoveDuplicates rd = new RemoveDuplicates();
            //List<int> ans = rd.removeDuplicates(list);  
            //foreach (int i in ans)
            //{
            //    Console.WriteLine(i);

            //}
            //LinkedList<int> l = new LinkedList<int>();
            //int m = int.Parse(Console.ReadLine());
            //for(int i = 0; i < n; i++)
            //{
            //    l.AddLast(int.Parse(Console.ReadLine()));
            //}
            HashSet<int> set = new HashSet<int>();
            HashSet<int > set2 = new HashSet<int>();

            Console.WriteLine("Enter the number of elements in list 1");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                set.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine("Elements in set 1 are : " + set.Count);
            Console.WriteLine("Enter the number of elements in list 2");
            int n2 = int.Parse(Console.ReadLine());
            for (int i = 0; i < n2; i++)
            {
                set2.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine("Elements in set 2 are : " + set2.Count);

            //checkTwoSetsAreEqual check = new checkTwoSetsAreEqual();
            //Console.Write(check.setsAreEqual(set, set2));
            UnnionAndIntersectionOfTwoSets union = new UnnionAndIntersectionOfTwoSets();
            union.UnionOfTwoSets(set , set2);

            HashSet<int> set1 = union.IntersectionOfTwoSets(set, set2);
            foreach(int i in set1){
                Console.WriteLine(i);
            }

        }
    }
}