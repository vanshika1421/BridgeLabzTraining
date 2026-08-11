//3.Hospital Triage System
//Simulate a hospital triage system using a PriorityQueue where patients with higher severity are treated first.
//Example:
//Patients: [ ("John", 3), ("Alice", 5), ("Bob", 2) ]
//Order: Alice, John, Bob


using System;
using System.Collections.Generic;
using System.Text;

namespace Queuess
{
    internal class HospitalTriageSystem
    {
        public void TriageSystem(PriorityQueue<string , int> pq)
        {
            while (pq.Count > 0)
            {
                Console.WriteLine(pq.Dequeue());
            }
           
        }
    }
}
