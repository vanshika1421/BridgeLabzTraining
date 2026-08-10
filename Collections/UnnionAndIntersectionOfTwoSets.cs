//2.Union and Intersection of Two Sets
//Compute the union and intersection of two sets.
//Example:
//Set1: { 1, 2, 3}, Set2: { 3, 4, 5}
//Output:
//Union: { 1, 2, 3, 4, 5}
//Intersection: { 3}


using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    internal class UnnionAndIntersectionOfTwoSets
    {
        public void UnionOfTwoSets(HashSet<int> set1 , HashSet<int> set2)
        {
            HashSet<int> union = new HashSet<int>();
           foreach(int i in set1) {
                union.Add(i);
            }
            foreach (int i in set2) {
                union.Add(i);
            }
            foreach (int i in union) {
                Console.WriteLine(i);
            }

        }
        public HashSet<int> IntersectionOfTwoSets(HashSet<int> set1 , HashSet<int> set2)
        {
            set1.IntersectWith(set2);
            return set1;
        }
    }
}
