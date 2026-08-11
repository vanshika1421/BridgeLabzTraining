//4.Remove Duplicates While Preserving Order
//Remove duplicate elements from a list while maintaining the original order.
//Example:
//Input: [3, 1, 2, 2, 3, 4]
//Output: [3, 1, 2, 4]


using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    internal class RemoveDuplicates
    {
        public List<int> removeDuplicates(List<int> duplicates)
        {
            List<int> listAns = new List<int>();
            HashSet<int> set = new HashSet<int>();
            foreach (int dup in duplicates)
            {
                if (set.Add(dup))
                {
                    listAns.Add(dup);
                }
            }
            return listAns;

        }
    }
}
