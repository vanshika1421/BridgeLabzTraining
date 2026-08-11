//Set Interface Problems
//1. Check if Two Sets Are Equal
//Compare two sets and determine if they contain the same elements, regardless of order.
//Example:
//Set1: { 1, 2, 3}, Set2: { 3, 2, 1}
//Output: true


using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    internal class checkTwoSetsAreEqual
    {
        public bool setsAreEqual(HashSet<int> set1, HashSet<int> set2)
        {

            return set1.SetEquals(set2);
            //return true;
        }
    }
}
