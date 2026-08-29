using System;
using System.Collections.Generic;
using System.IO;

namespace Level2;

public class DetectDuplicates
{
    public void FindDuplicates()
    {
        string fileName = "students.csv";

        string[] lines = File.ReadAllLines(fileName);

        HashSet<string> ids = new HashSet<string>();
        HashSet<string> duplicates = new HashSet<string>();

        for (int i = 1; i < lines.Length; i++)
        {
            string[] data = lines[i].Split(',');

            string id = data[0];

            if (!ids.Add(id))
            {
                duplicates.Add(id);
            }
        }

        Console.WriteLine("Duplicate Records:");

        for (int i = 1; i < lines.Length; i++)
        {
            string[] data = lines[i].Split(',');

            if (duplicates.Contains(data[0]))
            {
                Console.WriteLine(lines[i]);
            }
        }
    }
}