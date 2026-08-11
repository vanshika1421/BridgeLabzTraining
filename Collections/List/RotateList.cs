//using System.Xml.Linq;

//3. Rotate Elements in a List
//Rotate the elements of a list by a given number of positions.
//Example:
//Input: [10, 20, 30, 40, 50], rotate by 2
//Output: [30, 40, 50, 10, 20]
//3. Rotate Elements in a List
//Rotate the elements of a list by a given number of positions.
//Example:
//Input: [10, 20, 30, 40, 50], rotate by 2
//Output: [30, 40, 50, 10, 20]


using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    internal class RotateList
    {
        public void rotate(List<int> list)
        {
            Console.WriteLine("Enter the times for rotation");
            int n = int.Parse(Console.ReadLine());
            for (int i = n; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            for(int i = 0; i <= n-1; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}
