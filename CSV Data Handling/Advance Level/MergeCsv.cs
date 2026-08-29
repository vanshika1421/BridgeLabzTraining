using System;
using System.Collections.Generic;
using System.IO;

namespace Level2;

public class MergeCsv
{
    public void Merge()
    {
        string file1 = "students1.csv";
        string file2 = "students2.csv";
        string outputFile = "merged_students.csv";

        string[] students1 = File.ReadAllLines(file1);
        string[] students2 = File.ReadAllLines(file2);

        Dictionary<string, string[]> studentData =
            new Dictionary<string, string[]>();

        // Read students1
        for (int i = 1; i < students1.Length; i++)
        {
            string[] data = students1[i].Split(',');

            studentData[data[0]] = data;
        }

        List<string> output = new List<string>();

        output.Add("ID,Name,Age,Marks,Grade");

        // Read students2 and merge
        for (int i = 1; i < students2.Length; i++)
        {
            string[] data = students2[i].Split(',');

            string id = data[0];

            if (studentData.ContainsKey(id))
            {
                string[] firstData = studentData[id];

                string merged =
                    $"{firstData[0]},{firstData[1]},{firstData[2]},{data[1]},{data[2]}";

                output.Add(merged);
            }
        }

        File.WriteAllLines(outputFile, output);

        Console.WriteLine("CSV files merged successfully.");
    }
}